using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace WebApplication1.Data
{
    public class AppDbContext(DbContextOptions options) : IdentityDbContext<ApplicationUser>(options)
    {
    }
}
