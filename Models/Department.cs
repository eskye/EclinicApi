using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EClinicApi.Models
{
    public class Department
    {
        public int Id { get; set; }
        public int DepartmentIdentity { get; set; }
        public string DepartmentName { get; set; }

        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        
        public virtual ICollection<Doctor> Doctors { get; set; }
        public virtual ICollection<Nurse> Nurses { get; set; }
   

    }
}