using System;
using System.Collections.Generic;

#nullable disable

namespace AirlineAPIService.Models
{
    public partial class TblAirlineDetail
    {
        public string AlId { get; set; }
        public string AlName { get; set; }
        public string AlLogo { get; set; }
        public decimal? AlCustCareNo { get; set; }
        public string AlAddr1 { get; set; }
        public string AlCity { get; set; }
        public string AlState { get; set; }
        public string AlEmail { get; set; }
        public string AlIsBlocked { get; set; }
    }
}
