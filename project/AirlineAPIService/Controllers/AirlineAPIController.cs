using AirlineAPIService.Models;
using AirlineAPIService.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AirlineAPIService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    [EnableCors("AllowOrigin")]
    public class AirlineAPIController : ControllerBase
    {
        private readonly IAirlineInterface airlineService;
        public AirlineAPIController(IAirlineInterface airlineS)
        {
            airlineService = airlineS;
        }
       
        [HttpGet]
        [Route("[action]")]
        //   [Route("api/AirlineAPI/GetAirline")] airline
        [Route("api/airline/GetAirline")] 
        public IEnumerable<TblAirlineDetail> GetAirline()
        {
            return airlineService.GetAirlineDetails();
        }
        [HttpPost]
        [Route("[action]")]
        [Route("api/v1.0/flight/airline/register")]
        public string AddAirline(TblAirlineDetail airlineD)
        {
            if (airlineD != null)
            {
                 airlineService.AddAirlineDetails(airlineD);
                return airlineD.AlId;
            }
            return null;
        }
        [HttpPut]
        [Route("[action]")]
        [Route("api/airline/EditAirline")]
        public TblAirlineDetail EditAirline(TblAirlineDetail airlineD)
        {
            return airlineService.UpdateAirlineDetails(airlineD);
        }
        [HttpDelete]
        [Route("[action]")]
        [Route("api/airline/DeleteAirline")]
        public TblAirlineDetail DeleteAirline(string id)
        {
            return airlineService.DeleteAirline(id);
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/airline/GetAirlineById")]
        public TblAirlineDetail GetAirlineById(string id)
        {
            return airlineService.GetGetAirlineDetailsById(id);
        }


    }
}
