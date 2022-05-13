//using AirlineAPIService.Models;
using FlightAPIService.model;
using FlightAPIService.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FlightAPIService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   // [Authorize]
    [EnableCors("AllowOrigin")]
    public class FlightAPIController : ControllerBase
    {
        private readonly IFlightInterface flightService;
        private IConfiguration _config;
        public FlightAPIController(IConfiguration config, IFlightInterface flightS)
        {
            _config = config;
            flightService = flightS;
        }
        private string GenerateJSONWebToken()
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              null,
              expires: DateTime.Now.AddMinutes(120),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }      

        [HttpGet]
        [Route("[action]")]
        [EnableCors("AllowOrigin")]
        public IEnumerable<TblFlightDetail> GetFlightDetails()
        {
            return (IEnumerable<TblFlightDetail>)flightService.GetFlightDetails();
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/v1.0/flight/booking/history/")]
        public TblFlightBookingDetail GetBookingFlightDetailsByEmailId(string emailId)
        {
            return flightService.GetBookingFlightDetails(emailId);
        }


        [HttpPost]
        [Route("[action]")]
        [Route("api/v1.0/flight/search")]
        public List<TblFlightDetail> GetSearch(string frmdt, string todt, string fromplace, string toplace)
        {
            return flightService.GetFlightDetailsBySearch(frmdt, todt, fromplace, toplace);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/v1.0/flight/ticket")]
        public TblFlightBookingDetail GetFlightDetailsByPnr(string pnr)
        {
            return flightService.GetGetFlightDetailsByPnr(pnr);
        }
        [AllowAnonymous]
        [HttpGet]
        [Route("[action]")]
        [Route("api/v1.0/flight/admin/login")]
        [EnableCors("AllowOrigin")]
        public List<string> Login(string LoginId, string Password)
        {
            string response = "";
            List<string> responseData = new List<string>();
            //  var user = AuthenticateUser(login);           
            // string usertype = null;
            var user = flightService.Login(LoginId, Password);
            if (user != null)
            {
                var tokenString = GenerateJSONWebToken();
                response = tokenString;
                responseData.Add(response);
                responseData.Add(user.FirstName + "" + user.LastName);
                if ((bool)user.IsAdmin)
                { responseData.Add("admin"); }
                else { responseData.Add("user"); }
            }
            else
            {
                responseData.Add("Wrong Credentials");
            }
            return responseData;
        }
        [HttpPut]
        [Route("[action]")]
        [Route("api/v1.0/flight/booking/cancel/")]
        public bool Cancelflight(string pnr)
        {
            return flightService.Cancelflight(pnr);
        }

        [HttpPost]
        [Route("[action]")]
        //  [Route("api/v1.0/flight/booking/")]
        public string BookaTicket([FromBody] TblFlightBookingDetail bookflight)
        {
            return flightService.BookATicket(bookflight);
        }

        [HttpPost]
        [Route("[action]")]
        // [Route("api/v1.0/flight/airline/inventory/add")]
        public string AddFlight([FromBody] TblFlightDetail flightdetails)
        {
            if (flightdetails != null)
            {
                //flightdetails.FlightInstUsed="Boeing797"
                
                return flightService.AddFlightDetails(flightdetails);
            }
            return "record is empty";
        }
    }
}
