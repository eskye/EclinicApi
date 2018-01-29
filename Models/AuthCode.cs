﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EClinicApi.Models
{
    public class AuthCode
    {
        public long Id { get; set; }
        public string Passcode { get; set; }
        public DateTime DateCreated { get; set; }
        public long DoctorId { get; set; }
        public long PatientId { get; set; }
        public long NurseId { get; set; }
        public virtual Nurse Nurse { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
    }
}