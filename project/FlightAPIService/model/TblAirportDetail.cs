using System;
using System.Collections.Generic;

#nullable disable

namespace FlightAPIService.model
{
    public partial class TblAirportDetail
    {
        public string AirportCode { get; set; }
        public string AirportName { get; set; }
        public string AirportState { get; set; }
        public string AirportCity { get; set; }
        public bool? IsairportOperational { get; set; }
    }
}
