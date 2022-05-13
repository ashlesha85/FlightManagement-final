using System;
using System.Collections.Generic;

#nullable disable

namespace FlightAPIService.model
{
    public partial class TblPassengerDetail
    {
        public int Id { get; set; }
        public string FlightNo { get; set; }
        public string FlightPnrNo { get; set; }
        public DateTime? DepartureDate { get; set; }
        public string PassengerName { get; set; }
        public string PassengerMobileNo { get; set; }
        public string BookingStatus { get; set; }
        public string SeatNo { get; set; }
        public string Class { get; set; }
    }
}
