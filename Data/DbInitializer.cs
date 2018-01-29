using EClinicApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EClinicApi.Data
{
    public static class DbInitializer
    {
        public static void Initialize(EclinicData context)
        {
            context.Database.EnsureCreated();

            if (context.UserProfiles.Any())
            {
                return;
            }
            else
            {
                var User = new UserProfile
                {
                    FirstName = "Oladimeji",
                    UserName = "Insight",
                    LastName = "Insight",
                    Password = "Oladimeji_insight",
                    Email = "Oladimeji@Eclinic.com",
                    AccessLevel = "Admin",
                    Gender = "Male",
                    IsActive = true,
                    PhoneNumber = "069850505",
                    DateCreated = DateTime.Now


                };
                context.UserProfiles.Add(User);
                context.SaveChanges();  
            }
        }
    }
}
