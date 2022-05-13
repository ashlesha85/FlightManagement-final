using FlightAPIService.model;
//using AirlineAPIService.Models;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Threading.Tasks;

namespace FlightAPIService.Repository
{
    public class FlightRepository :IFlightInterface
    {
        AirlineReservationContext dbContext;
        public FlightRepository(AirlineReservationContext _db)
        {
            dbContext = _db;
        }
        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        //api/v1.0/flight/airline/inventory/add
        public string AddFlightDetails(TblFlightDetail flightdetails)
        {
            if (flightdetails != null)
            {
                dbContext.TblFlightDetails.Add(flightdetails);
                dbContext.SaveChanges();               
                var seatdetails = dbContext.TblFlightInstrumentDetails.Where(x => x.InstName == flightdetails.FlightInstUsed).ToList();
                    if(seatdetails.Count>0)
                    {
                        foreach(var item in seatdetails)
                        {
                            TblFlightSeatsDetail objseatdetails = new TblFlightSeatsDetail();
                            objseatdetails.FlightNo = flightdetails.FlightNo;
                            objseatdetails.FlightDepartDt = flightdetails.FlightDeptDt;
                            objseatdetails.FlightSeatNo = item.SeatNo;
                            objseatdetails.FlightTktClass = item.Class;
                            objseatdetails.FlightReservedSeat = "NA";
                            objseatdetails.FlightIsbooked = null;
                            objseatdetails.FlightMealType = null;
                            dbContext.TblFlightSeatsDetails.Add(objseatdetails);
                        }
                    }
                
                return flightdetails.FlightNo;
            }
            return null;
        }

        //api/v1.0/flight/booking/{flightid)
        public string BookATicket(TblFlightBookingDetail bookflight)
        {

            if (bookflight != null)
            {
                // int randomNumber = UnityEngine.Random.Range(1, 100);
                string pnr = RandomString(10);
                bookflight.FlightPnrNo = pnr;
                dbContext.TblFlightBookingDetails.Add(bookflight);
                dbContext.SaveChanges();
                return bookflight.FlightPnrNo;
            }
            return null;
        }

        //api/v1.0/flight/booking/cancel/{pnr}
        public bool Cancelflight(string pnr)
        {
            bool Iscancelled = false;
            if (pnr != null)
            {
                var flight = dbContext.TblFlightBookingDetails.Where(x => x.FlightPnrNo == pnr).SingleOrDefault();
                if (flight != null)
                {
                    flight.BookingStatus = "Cancelled";
                    dbContext.SaveChanges();
                    Iscancelled = true;
                }

            }
            return Iscancelled;
        }
        //api/v1.0/flight/booking/history/{emailId}
        public TblFlightBookingDetail GetBookingFlightDetails(string emailId)
        {
            var bookingflight = dbContext.TblFlightBookingDetails.FirstOrDefault(x => x.PassengerEmailId == emailId);
            return bookingflight;

        }

        public IEnumerable<TblFlightDetail> GetFlightDetails()
        {
            var flightDetails = dbContext.TblFlightDetails.ToList();
            return flightDetails;
        }
        //api/v1.0/flight/search
        public List<TblFlightDetail> GetFlightDetailsBySearch(string frmdt, string todt, string fromplace, string toplace)
        {
            var predicate = PredicateBuilder.True<TblFlightDetail>();
            if (!string.IsNullOrEmpty(frmdt))
            {
                DateTime frmdate;
                DateTime.TryParse(frmdt, out frmdate);
                // predicate = predicate.And(i => EntityFunctions.TruncateTime(i.BirthDate) == EntityFunctions.TruncateTime(dob));
                predicate = predicate.And(i => i.FlightDeptDt == frmdate);

            }
            if (!string.IsNullOrEmpty(fromplace) && !string.IsNullOrEmpty(toplace))
            {
                predicate = predicate.And(i => i.FlightSrcAirportcode == fromplace && i.FlightDestAirportcode == toplace);
            }
            var bookingflight = dbContext.TblFlightDetails.Where(predicate).ToList();

            return bookingflight;
        }
        //api/v1.0/flight/ticket/{pnr}
        public TblFlightBookingDetail GetGetFlightDetailsByPnr(string pnr)
        {

            var bookingflight = dbContext.TblFlightBookingDetails.Where(x => x.FlightPnrNo == pnr).FirstOrDefault();
            return bookingflight;


        }

        public TblUserDetail Login(string LoginId, string Password)
        {
            var userdetails = dbContext.TblUserDetails.Where(x => x.LoginId == LoginId && x.Password == Password).FirstOrDefault();
            return userdetails;
        }
    }

}
