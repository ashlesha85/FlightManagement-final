using System;
using System.Collections.Generic;

#nullable disable

namespace AirlineAPIService.Models
{
    public partial class TblFlightSeatsDetail
    {
        public string FlightNo { get; set; }
        public DateTime? FlightDepartDt { get; set; }
        public string FlightSeatNo { get; set; }
        public string FlightTktClass { get; set; }
        public string FlightReservedSeat { get; set; }
        public string FlightIsbooked { get; set; }
        public string FlightMealType { get; set; }
    }
}
