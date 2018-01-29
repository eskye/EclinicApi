using System;
using System.Collections.Generic;

namespace EClinicApi.Models
{
    public class Nurse
    {
        public long Id { get; set; }
        public string NurseId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public bool Availability { get; set; }
        public string State { get; set; }
        public string YearOfExperience { get; set; }
        public DateTime PracticeStartDate { get; set; }
        public int DepartmentId { get; set; }
        public bool IsActive { get; set; }
        public string ImageUrl { get; set; }
        public string RoleName { get; set; }
        public string Specialization { get; set; }
        public DateTime? LastLoginTime { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
        public virtual ICollection<AuditRecord> AuditRecords { get; set; }
        public virtual ICollection<AuthCode> AuthCodes { get; set; }
    }
}