using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace FlightAPIService.Models
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
      //  [JsonConverter(typeof(DateTimeToStringConverter))]
        public DateTime? FlightDeptDt { get; set; }
      //  [JsonConverter(typeof(DateTimeToStringConverter))]
        public DateTime? FlightArrivDt { get; set; }
       
    }
}
