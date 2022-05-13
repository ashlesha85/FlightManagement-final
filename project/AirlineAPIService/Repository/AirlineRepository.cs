using AirlineAPIService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirlineAPIService.Repository
{
    public class AirlineRepository :IAirlineInterface
    {
        AirlineReservationContext dbContext;
        public AirlineRepository(AirlineReservationContext _db)
        {
            dbContext = _db;
        }
        //api/v1.0/flight/airline/register
        public string AddAirlineDetails(TblAirlineDetail airline)
        {
            if (airline != null)
            {
                dbContext.TblAirlineDetails.Add(airline);
                dbContext.SaveChanges();
                return airline.AlId;
            }
            return null;
        }

        public TblAirlineDetail DeleteAirline(string id)
        {
            var airline = dbContext.TblAirlineDetails.FirstOrDefault(x => x.AlId == id);
            dbContext.Entry(airline).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return airline;
        }

        public IEnumerable<TblAirlineDetail> GetAirlineDetails()
        {
            var airlineDetails = dbContext.TblAirlineDetails.ToList();
            return airlineDetails;
            //throw new NotImplementedException();
        }

        public TblAirlineDetail GetGetAirlineDetailsById(string id)
        {
            var airline = dbContext.TblAirlineDetails.FirstOrDefault(x => x.AlId == id);
            return airline;
        }

        public TblAirlineDetail UpdateAirlineDetails(TblAirlineDetail airline)
        {
            // var airline = dbContext.TblAirlineDetails.FirstOrDefault(x => x.AlId == id);
            dbContext.Entry(airline).State = EntityState.Modified;
            dbContext.SaveChanges();
            return airline;
        }
    }
}
