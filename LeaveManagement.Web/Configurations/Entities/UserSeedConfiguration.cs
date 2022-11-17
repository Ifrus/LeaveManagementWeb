using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
               new Employee
               {
                   Id = "4708398e-57e3-4517-b9de-e50c5814508a",
                   Email = "admin@test.com",
                   NormalizedEmail = "ADMIN@TEST.COM",
                   NormalizedUserName = "ADMIN@TEST.COM",
                   UserName = "admin@test.com",
                   FirstName = "System",
                   LastName = "Admin",
                   PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                   EmailConfirmed = true
               },
               new Employee
               {
                   Id = "8442f4e8-ccea-4b69-a8f5-5e418e37ffd1",
                   Email = "user@yahoo.com",
                   NormalizedEmail = "USER@YAHOO.COM",
                   NormalizedUserName = "USER@YAHOO.COM",
                   UserName = "user@yahoo.com",
                   FirstName = "System",
                   LastName = "User",
                   PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                   EmailConfirmed = true
               }
            );
        }
    }
}