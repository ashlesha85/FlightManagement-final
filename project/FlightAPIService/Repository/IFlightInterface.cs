using System.Collections.Generic;
//using AirlineAPIService.Models;
using FlightAPIService.model;


namespace FlightAPIService.Repository
{
    public interface IFlightInterface
    {
        IEnumerable<TblFlightDetail> GetFlightDetails();
        List<TblFlightDetail> GetFlightDetailsBySearch(string frmdt, string todt, string fromplace, string toplace);
        TblFlightBookingDetail GetGetFlightDetailsByPnr(string pnr);
        string AddFlightDetails(TblFlightDetail flight);
        string BookATicket(TblFlightBookingDetail bookflight);
        TblFlightBookingDetail GetBookingFlightDetails(string emailId);
        bool Cancelflight(string pnr);
        TblUserDetail Login(string LoginId, string Password);
    }
}
