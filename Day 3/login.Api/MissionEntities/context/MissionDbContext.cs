using Microsoft.EntityFrameworkCore;
using MissionEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionEntities.context
{
    public class MissionDbContext : DbContext
    {
        public MissionDbContext(DbContextOptions<MissionDbContext> options): base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AppContext.SetSwitch("Npgsql.EnableLegancyTimestampBehavior", true);
            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = 1,
                FirstName = "Preksha",
                LastName = "Divaraniya",
                EmailAddress = "preksha@tatvasoft.com",
                UserType = "admin",
                Password = "preksha@123",
                PhoneNumber = "9876543210",
                CreatedDate = new DateTime(2019, 1, 1, 0, 0, 0, DateTimeKind.Utc)
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
