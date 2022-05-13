using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirlineAPIService.Models;

namespace AirlineAPIService.Repository
{
    public interface IAirlineService
    {
        IEnumerable<TblAirlineDetail> GetAirlineDetails();
        TblAirlineDetail GetGetAirlineDetailsById(string id);
        TblAirlineDetail AddAirlineDetails(TblAirlineDetail airline);
        TblAirlineDetail UpdateAirlineDetails(TblAirlineDetail airline);
        TblAirlineDetail DeleteAirline(string id);
    }
}
