using com.npo.business.model;
using com.npo.business.model.Association;
using com.npo.business.model.Base;
using com.npo.business.model.Contact;
using com.npo.business.model.Finance;
using com.npo.business.model.Gift;
using Com.Npo.Common;
using System.Data.Entity;

namespace Com.Npo.Data
{
    public class NpoDBContext : System.Data.Entity.DbContext
    {
        private ILogger logger;
        public NpoDBContext(ILogger logger)
            : base("name=NpoDBContext")
        {
            this.logger = logger;
            Database.Log = log => this.logger.Debug(log);
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            this.Database.CommandTimeout = 180;
        }

        public NpoDBContext()
          : base("name=NpoDBContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            this.Database.CommandTimeout = 180;
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionType> TransactionType { get; set; }
        public DbSet<Commitment> Commitments { get; set; }
        public DbSet<CommitmentType> CommitmentTypes { get; set; }
        public DbSet<MemberShip> Memberships { get; set; }
        public DbSet<MemberType> MemberShipTypes { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<MemberType> MemberTypes { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Ignore<PayslipBatchView>();
        }
    }
}
