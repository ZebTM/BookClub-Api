using Microsoft.EntityFrameworkCore;
using BookClub.Models;

namespace BookClub.DatabaseContext;

public class MyDatabaseContext : DbContext
{

    protected readonly IConfiguration _configuration;

    public MyDatabaseContext(IConfiguration configuration, DbContextOptions<MyDatabaseContext> options) : base(options)
    {
        _configuration = configuration;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Author> Authors { get; set; }
}
