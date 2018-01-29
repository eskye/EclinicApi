using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EClinicApi.Models
{
    public class AppSetup
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Tagline { get; set; }
        public string Logo { get; set; }
        public bool IsSetup { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string RcNumber { get; set; }
        public string Location { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public DateTime DateCreated { get; set; }
      
    }
}