using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FYPSwaggerApi.Datalayer
{
    public class ApiDbContext : IdentityDbContext

    {
        public ApiDbContext(DbContextOptions options) : base(options)
        {


        }
    }
}
