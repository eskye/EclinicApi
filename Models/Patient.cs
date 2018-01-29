using System;
using System.Collections.Generic;

namespace EClinicApi.Models
{
    public class Patient
    {
        public long Id { get; set; }  
        public string PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }
        public string PhoneNumber { get; set; }
        public Marital Marital { get; set; }
        public string ImageUrl { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Type { get; set; }
        public DateTime? LastLoginTime { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public virtual ICollection<AuditRecord> AuditRecords { get; set; }
        public virtual ICollection<LabResult> LabResults { get; set; }
        public virtual ICollection<AuthCode> AuthCodes { get; set; }


    }
    public enum Marital
    {
        Single,
        Married,
        Divorced,
        Widowed,
        Complicated
    }
}