using System;
using System.Collections.Generic;

#nullable disable

namespace AirlineAPIService.Models
{
    public partial class TblFlightBookingDetail
    {
        public string FlightPnrNo { get; set; }
        public string FlightNo { get; set; }
        public string AirlineId { get; set; }
        public string AirportCode { get; set; }
        public string FlightSeatNo { get; set; }
        public string PassengerName { get; set; }
        public string PassengerMobileNo { get; set; }
        public string PassengerEmailId { get; set; }
        public string PassengerIdProof { get; set; }
        public decimal? FlightTotaltktPrice { get; set; }
        public string BookingStatus { get; set; }
        public string FlightSrcAirportcode { get; set; }
        public string FlightDestAirportcode { get; set; }
        public int? TotalBookedtickets { get; set; }
        public string DiscountCode { get; set; }
        public decimal? FinalTicketPrice { get; set; }
        public DateTime? DepartureDate { get; set; }
        public DateTime? BookingDate { get; set; }
    }
}
