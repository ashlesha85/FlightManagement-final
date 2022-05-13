using System;
using System.Collections.Generic;
using System.Text.Json;

#nullable disable

namespace FlightAPIService.Models
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
        public decimal FlightTktPrice { get; set; }
        public string BookingStatus { get; set; }
    }
}
