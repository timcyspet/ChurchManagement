using com.npo.business.model;
using com.npo.business.model.Association;
using com.npo.business.model.Base;
using com.npo.business.model.Contact;
using com.npo.business.model.Finance;
using com.npo.business.model.Gift;
using Com.Npo.Common;
using Com.Npo.Data.DataSeed;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


namespace Com.Npo.Data
{
    public class NpoDBContext : DbContext
    {
        //private ILogger logger;
        public NpoDBContext(DbContextOptions<NpoDBContext> options)
            : base(options)
        {
            //this.logger = logger;
            //Database.Log = log => this.logger.Debug(log);
            //this.Configuration.LazyLoadingEnabled = false;
            //this.Configuration.ProxyCreationEnabled = false;
            //this.Database.CommandTimeout = 180;
        }

        //public NpoDBContext()
        //  : base()
        //{
        //    //this.Configuration.LazyLoadingEnabled = false;
        //    //this.Configuration.ProxyCreationEnabled = false;
        //   // this.Database.CommandTimeout = 180;
        //}

        public DbSet<Person> People { get; set; }
        public DbSet<PersonAttribute> PeopleAttributes { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactAttribute> ContactAttributes { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionAttribute> TransactionAttributes { get; set; }
        public DbSet<TransactionType> TransactionType { get; set; }
        public DbSet<Commitment> Commitments { get; set; }
        public DbSet<CommitmentType> CommitmentTypes { get; set; }
        public DbSet<MemberShip> Memberships { get; set; }
        public DbSet<MemberShipAttribute> MemberShipAttributes { get; set; }
        public DbSet<MemberType> MemberShipTypes { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<MemberType> MemberTypes { get; set; }
        public DbSet<com.npo.business.model.Base.Attribute> Attributes { get; set; }
        public DbSet<com.npo.business.model.Base.AttributeKey> AttributeKeys { get; set; }
        public DbSet<com.npo.business.model.Base.AttributeType> AttributeTypes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {           
            base.OnModelCreating(modelBuilder);

            //CommitmentSeed.SeedCommitments(modelBuilder);
        }
    }
}
