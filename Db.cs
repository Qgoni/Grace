using System.Data.Entity;
using System.Runtime.InteropServices;
using Grace.Model;

namespace Grace;
public class DbUsers : DbContext
{
    public DbUsers(string connectionString)
        : base(connectionString) { }
    public DbSet<User> Users { get; set; } = null!;
}
