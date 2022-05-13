using System;
using System.Collections.Generic;

#nullable disable

namespace FlightAPIService.Models
{
    public partial class TblUserDetail
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PanNo { get; set; }
        public string AdharNo { get; set; }
        public string Gender { get; set; }
        public string LoginId { get; set; }
        public string Password { get; set; }
        public bool? IsAdmin { get; set; }
        public bool? IsActive { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PinCode { get; set; }
    }
}
