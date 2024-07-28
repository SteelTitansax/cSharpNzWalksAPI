using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NZWalks.API.Data
{
    public class NZWalksAuthDbContext : IdentityDbContext
    {
        public NZWalksAuthDbContext(DbContextOptions<NZWalksAuthDbContext> options) : base(options) 
        {
            
        }

        protected override void OnModelCreating( ModelBuilder builder )
        {
            base.OnModelCreating( builder );
            var readerRoleId = "c94ea0e7-73a1-4d36-a08d-f71b5d1f1590";
            var writerRoleId = "dcbc67b3-1990-4f0c-9356-2db886fd87c7";
            var readerWriterId = "23dc2ae2-abeb-457b-9a2d-4172a91375a3";
            var roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Id = readerRoleId,
                    ConcurrencyStamp = readerRoleId,
                    Name = "Reader",
                    NormalizedName = "Reader".ToUpper()
                },
                new IdentityRole
                {
                    Id = writerRoleId,
                    ConcurrencyStamp = writerRoleId,
                    Name = "Writer",
                    NormalizedName = "Writer".ToUpper()
                },
                 new IdentityRole
                {
                    Id = readerWriterId,
                    ConcurrencyStamp = readerWriterId,
                    Name = "ReaderWriter",
                    NormalizedName = "ReaderWriter".ToUpper()
                }
            };

            builder.Entity<IdentityRole>().HasData( roles );

        }

    }
}
