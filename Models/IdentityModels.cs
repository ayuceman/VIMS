using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Bipa.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer<ApplicationDbContext>(null);
            //Database.SetInitializer(new CreateDatabaseIfNotExists<ApplicationDbContext>());
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<CodeTable> CodeTables { get; set; }
        public DbSet<ReferralList> ReferralListTable { get; set; }

        public System.Data.Entity.DbSet<Bipa.EditModels.AppGenInfo> AppGenInfoes { get; set; }

        public System.Data.Entity.DbSet<Bipa.EditModels.AppHealthInfo> AppHealthInfoes { get; set; }

        public System.Data.Entity.DbSet<Bipa.EditModels.AppContactInfo> AppContactInfoes { get; set; }

        public System.Data.Entity.DbSet<Bipa.EditModels.AppExtraInfo> AppExtraInfoes { get; set; }

        public System.Data.Entity.DbSet<Bipa.EditModels.AppHistoryInfo> AppHistoryInfoes { get; set; }

        public System.Data.Entity.DbSet<Bipa.EditModels.AppTrainInfo> AppTrainInfoes { get; set; }

        public void ReferralListInsert(string app_no, string course_no,string codeid, string casedesc,string remarks,int? depday)
        {
            this.Database.ExecuteSqlCommand("VIPA.dbo.s_InsertReferralDetails @APP_NO,@TRAIN_S_N,@CodeID,@CaseDesc,@Remarks,@DepDay",

                 new SqlParameter("APP_NO", app_no),
                 new SqlParameter("TRAIN_S_N", course_no),
                 new SqlParameter("CodeID", codeid),
                 new SqlParameter("CaseDesc", casedesc),
                 new SqlParameter("Remarks", remarks),
                 new SqlParameter("DepDay",depday)




                );

        }


    }
}