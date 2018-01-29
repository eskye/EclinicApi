using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EClinicApi.Models
{
    public class LabResult
    {
        public long Id { get; set; }
        public long PatientId { get; set; }
        public long DoctorId { get; set; }
        public string TestType { get; set; }
        public string TestTitle { get; set; }
        public string ResultFile { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual ICollection<AuditRecord> AuditRecords { get; set; }

    }
}