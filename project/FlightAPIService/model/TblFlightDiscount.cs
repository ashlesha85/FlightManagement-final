using System;
using System.Collections.Generic;

#nullable disable

namespace FlightAPIService.model
{
    public partial class TblFlightDiscount
    {
        public int DiscountId { get; set; }
        public string DiscountCode { get; set; }
        public decimal? DiscountPercentage { get; set; }
    }
}
