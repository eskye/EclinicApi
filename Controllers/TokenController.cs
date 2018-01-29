using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EClinicApi.Data;
using EClinicApi.Models;
using Microsoft.AspNetCore.Authorization;
using System.IdentityModel.Tokens.Jwt;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EClinicApi.Controllers
{
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class TokenController : Controller
    {
        public readonly EclinicData eclinicData;
       public TokenController(EclinicData data)
        {
            eclinicData = data;
        }

        public IActionResult GetToken(string username, string password)
        {
            EclinicSecurity security = new EclinicSecurity(eclinicData);
            var user = security.ValidateUser(username, password);
            if(user != null)
            {
              var token  = EclinicSecurity.GenerateToken(user.username, user.email, user.Role);
                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });
            }
            else
            {
                return NotFound();
            }
            

        }
    }
}
