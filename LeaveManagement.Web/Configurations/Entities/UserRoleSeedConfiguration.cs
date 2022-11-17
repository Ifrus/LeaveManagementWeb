using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId= "8432f4e8-ccba-4b69-a8f5-5e618e38cfa1",
                    UserId= "4708398e-57e3-4517-b9de-e50c5814508a"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "7453f4c8-bbca-4c69-a7a5-6e418e37fcd1",
                    UserId = "8442f4e8-ccea-4b69-a8f5-5e418e37ffd1"
                }
                );
        }
    }
}