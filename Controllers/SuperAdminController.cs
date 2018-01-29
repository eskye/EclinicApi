using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using EClinicApi.Data;
using EClinicApi.DTO;
using EClinicApi.Models;
using AutoMapper;

namespace EClinicApi.Controllers
{
    [Produces("application/json")]
    [Route("api/SuperAdmin")]
    [Authorize]
    public class SuperAdminController : Controller
    {


       private EclinicData data;
        private readonly IMapper _mapper;
        public SuperAdminController(EclinicData _data, IMapper mapper)
        {
            data = _data;
            _mapper = mapper;
        }
       
        //public IActionResult DashboardData()
        //{
        //    return Ok("Empty for now");
        //}
        public IActionResult GetUserData()
        {
            
            if(User == null)
            {
                return BadRequest("User Failed");
            }
            var username = User.Identity.Name;
            if (username != "")
            {
                var user = data.UserProfiles.Where(x => x.UserName.Equals(username)).FirstOrDefault();
                if (user != null)
                {
                    return Ok(user);
                }
               
            }
            return BadRequest("Request is bad");
        }
        [HttpGet]
        [Route("DashboardData")]
        public IActionResult DashboardData()
        {
            return Ok("dashboard data not ready!");
        }
    [Route("CreateNewUser")]
        public IActionResult CreateNewUser(UserProfileDTO userProfile)
        {
            if (!ModelState.IsValid)
                return BadRequest("Model is Invalid");

            var user = _mapper.Map<UserProfile>(userProfile);
            Random rand = new Random();

            user.Id = rand.Next(10,15);
            data.UserProfiles.Add(user);
            switch (userProfile.AccessLevel)
            {
                case "Doctor":
                    Doctor NewDoctor = new Doctor
                    {
                        FirstName = userProfile.FirstName,
                        LastName = userProfile.LastName,
                        Email = userProfile.Email,
                        Gender = userProfile.Gender,
                        PhoneNumber = userProfile.PhoneNumber,
                        Id = user.Id



                    };
                    break;
                case "Nurse":
                    Nurse NewNurse = new Nurse
                    {
                        FirstName = userProfile.FirstName,
                        LastName = userProfile.LastName,
                        Email = userProfile.Email,
                        Gender = userProfile.Gender,
                        PhoneNumber = userProfile.PhoneNumber,
                        Id = user.Id



                    };
                    break;
                case "Patient":
                    Patient NewPatient = new Patient
                    {
                        FirstName = userProfile.FirstName,
                        LastName = userProfile.LastName,
                        Email = userProfile.Email,
                        Gender = userProfile.Gender,
                        PhoneNumber = userProfile.PhoneNumber,
                        Id = user.Id



                    };
                    break;
                case "Admin":
                    Superadmin superadmin = new Superadmin
                    {
                        FirstName = userProfile.FirstName,
                        LastName = userProfile.LastName,
                        Email = userProfile.Email,
                        Gender = userProfile.Gender,
                        PhoneNumber = userProfile.PhoneNumber,
                        Id = user.Id



                    };
                    break;
                default:
                    return BadRequest("User Type Unkown");
            }
            int i = data.SaveChanges();
            if(i == 1)
            {
                return Ok("User Created");
            }
            return BadRequest("OOps something happened try again!");
                


        }

    }
}