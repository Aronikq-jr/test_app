using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;

using test_app.Models;

 

namespace test_app.Data;

 

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)

{

    public DbSet<Product> Products { get; set; }

}