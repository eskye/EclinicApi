using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using EClinicApi.Data;
namespace EClinicApi.Models
{
    public  class EclinicSecurity
    {
        public  readonly EclinicData eclinicData;
      public EclinicSecurity(EclinicData data)
        {
            eclinicData = data;
        }
        public static JwtSecurityToken GenerateToken(string username, string email, string role)
        {
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("VQWHGHHdd2743830chcwefjihw72467823gfwbcwfugf4"));
            var claims = new Claim[]
            {
                new Claim(ClaimTypes.Name,username),
                new Claim(ClaimTypes.Email, email),
                new Claim(ClaimTypes.Role, role)
            };

            var token = new JwtSecurityToken(
                issuer: "Eclinic",
                audience: "Eclinic_Client",   
                claims: claims,
                notBefore: DateTime.Now,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: new SigningCredentials(secretKey,SecurityAlgorithms.HmacSha256)
            


                );
            return token;
        }
       
        public  tokenData ValidateUser(string username, string password)
        {
            if(username == null && password == null)
            {
                return null;
            }

            var User = eclinicData.UserProfiles.Where(s => s.UserName == username && s.Password == password).FirstOrDefault();
            if (User != null)
                return new tokenData {
                    username = User.UserName,
                    email = User.Email,
                    Role = User.AccessLevel
                };
            else
                return null;
        }
    }
    public class tokenData
    {
       public string username { get; set; }
       public string email { get; set; }
       public string Role { get; set; }
    }
}
