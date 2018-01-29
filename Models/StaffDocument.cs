using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EClinicApi.Models
{
    public class StaffDocument
    {
        public int StaffDocumentId { get; set; }
        public string DocumentName { get; set; }
        public string DocumentUrl { get; set; }
        public DateTime? DateIssued { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string IssuerNamee { get; set; }
        public bool isVerified { get; set; }
    }
}
