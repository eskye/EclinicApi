using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace EClinicApi.Models
{
    public class TokenSafe
    {
        public int id { get; set; }
        public JwtSecurityToken token { get; set; }
        public string AudienceName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}


