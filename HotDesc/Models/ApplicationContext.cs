using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotDesc.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Workplace> Workplaces { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Device> Devices { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Workplace workplace1 = new Workplace { Id = 1, Description = "First workplace", IsInUse = false };
            Workplace workplace2 = new Workplace { Id = 2, Description = "Second workplace", IsInUse = false };
            Workplace workplace3 = new Workplace { Id = 3, Description = "Third workplace", IsInUse = false };
            Workplace workplace4 = new Workplace { Id = 4, Description = "Fourth workplace", IsInUse = false };
            Workplace workplace5 = new Workplace { Id = 5, Description = "Fifth workplace", IsInUse = false };

            Device device1 = new Device { Id = 1, Name = "Клавиатура" };
            Device device2 = new Device { Id = 2, Name = "Мышь" };
            Device device3 = new Device { Id = 3, Name = "Монитор" };
            Device device4 = new Device { Id = 4, Name = "Второй монитор" };
            Device device5 = new Device { Id = 5, Name = "Системный блок" };
            Device device6 = new Device { Id = 6, Name = "Бесперебойник" };



            Role adminRole = new Role { Id = 1, Name = "admin" };
            Role userRole = new Role { Id = 2, Name = "user" };

            Employee admin = new Employee { Id = 1, Surname = "Admin", Name = "Admin", Login = "Administrator", Password = "admin", RoleId = adminRole.Id };
            Employee user1 = new Employee { Id = 2, Surname = "Webster", Name = "Junior", Login = "Webster", Password = "123", RoleId = userRole.Id };
            Employee user2 = new Employee { Id = 3, Surname = "McDaniel", Name = "Brice", Login = "McDaniel", Password = "123", RoleId = userRole.Id };
            Employee user3 = new Employee { Id = 4, Surname = "Wilkerson", Name = "Steven", Login = "Wilkerson", Password = "123", RoleId = userRole.Id };
            Employee user4 = new Employee { Id = 5, Surname = "Doyle", Name = "Kristopher", Login = "Doyle", Password = "123", RoleId = userRole.Id };
            Employee user5 = new Employee { Id = 6, Surname = "Thompson", Name = "Anthony", Login = "Thompson", Password = "123", RoleId = userRole.Id };

            modelBuilder.Entity<Role>().HasData(new Role[] { adminRole, userRole });
            modelBuilder.Entity<Employee>().HasData(new Employee[] { admin, user1, user2, user3, user4, user5 });
            modelBuilder.Entity<Workplace>().HasData(new Workplace[] { workplace1, workplace2, workplace3, workplace4, workplace5 });
            modelBuilder.Entity<Device>().HasData(new Device[] { device1, device2, device3, device4, device5, device6 });
            base.OnModelCreating(modelBuilder);
        }
    }
}
