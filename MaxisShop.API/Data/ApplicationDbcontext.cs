using MaxisShop.API.Models;
using Microsoft.EntityFrameworkCore;

namespace MaxisShop.API.Data
{
public class ApplicationDbcontext : DbContext
{
    public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
    {
    }
    public DbSet<Products> Products { get; set; }

}
}