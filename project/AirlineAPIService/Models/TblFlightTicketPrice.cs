using System;
using System.Collections.Generic;

#nullable disable

namespace AirlineAPIService.Models
{
    public partial class TblFlightTicketPrice
    {
        public string FlightNo { get; set; }
        public string FlightSeatNo { get; set; }
        public DateTime? FlightDepartDt { get; set; }
        public byte[] FlightDepartTime { get; set; }
        public string FlightTktClass { get; set; }
        public decimal? FlightTktActPrice { get; set; }
        public decimal? FlightTktDiscountPrice { get; set; }
        public decimal? FlightTktFinalPrice { get; set; }
        public bool? FlightIsbooked { get; set; }
        public string FlightMealType { get; set; }
    }
}
