using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EClinicApi.Models
{
    public class Appointment
    {
        public long Id { get; set; }
       public string[] TimeSlots { get; set; } 
       public long PatientId { get; set; }
       public bool IsAvailable { get; set; }
       public virtual Patient Patient { get; set; }
       
    }
}   