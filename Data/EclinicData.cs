using Microsoft.EntityFrameworkCore;
using EClinicApi.Models;
namespace EClinicApi.Data
{
    public class EclinicData : DbContext
    {
        public EclinicData(DbContextOptions<EclinicData> options) : base(options)
        {

        }
        public DbSet<UserProfile> UserProfiles { get; set; }
   
    }
}