using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace EClinicApi.Models
{
    public class Doctor
    {
        [Key]
        public long Id { get; set; }
        public string DoctorIdent { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Qualification { get; set; }
        public bool Availability { get; set; }
        public bool IsActive { get; set; }
        public string YearOfExperience { get; set; }
        public DateTime PracticeStartDate { get; set; }
        public string Specialization { get; set; }
        public int DepartmentId { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public bool DataVerified { get; set; }
        public bool isFirstLogin { get; set; }
        public int StaffDocumentId { get; set; }
        public virtual ICollection<StaffDocument> StaffDocuments { get; set; }
       


        

    }

   
}