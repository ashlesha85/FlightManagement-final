using AirlineAPIService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirlineAPIService.Repository
{
    public interface IAirlineInterface
    {

        IEnumerable<TblAirlineDetail> GetAirlineDetails();
        TblAirlineDetail GetGetAirlineDetailsById(string id);
        string AddAirlineDetails(TblAirlineDetail airline);
        TblAirlineDetail UpdateAirlineDetails(TblAirlineDetail airline);
        TblAirlineDetail DeleteAirline(string id);
    }
}
