using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EClinicApi.Models
{
    public class UserProfile : BaseEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string AccessLevel { get; set; }
        public string Email { get; set; }       
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string ImageUrl { get; set; }
        public string RoleName { get; set; }
        public string RoleId { get; set; }
        public DateTime? LastLoginTime { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsActive { get; set; }

    
    }
}