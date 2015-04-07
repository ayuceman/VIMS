using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace Bipa.Models
{
    public class MvcDbContext : DbContext
    {
       // DefaultConnection
        public MvcDbContext() : base("name=DefaultConnection") { }

        public DbSet<ReferralTable> ReferralTables { get; set; }

    }
}