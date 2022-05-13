using System;
using System.Collections.Generic;

#nullable disable

namespace AirlineAPIService.Models
{
    public partial class TblFlightInstrumentDetail
    {
        public string InstName { get; set; }
        public string SeatNo { get; set; }
        public string Class { get; set; }
        public int InstId { get; set; }
    }
}
