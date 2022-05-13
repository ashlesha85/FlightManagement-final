using System;
using System.Collections.Generic;

#nullable disable

namespace AirlineAPIService.Models
{
    public partial class TblFlightDetail
    {
        public int FlightId { get; set; }
        public string FlightNo { get; set; }
        public string AirlineId { get; set; }
        public string FlightSrcAirportcode { get; set; }
        public string FlightDestAirportcode { get; set; }
        public string FlightTotalNoofseats { get; set; }
        public string FlightTotalBusSeats { get; set; }
        public string FlightTotalEcoSeats { get; set; }
        public string FlightNoOfRows { get; set; }
        public string FlightInstUsed { get; set; }
        public DateTime? FlightDeptDt { get; set; }
        public DateTime? FlightArrivDt { get; set; }
        public decimal? FlightBusTicketPrice { get; set; }
        public decimal? FlightEcoTicketPrice { get; set; }
    }
}
