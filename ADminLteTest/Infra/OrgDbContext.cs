using ADminLteTest.Entites;
using Microsoft.EntityFrameworkCore;

namespace ADminLteTest.Infra
{
    public class OrgDbContext :DbContext
    {
        public OrgDbContext(DbContextOptions<OrgDbContext> options)
            : base(options)
    {

    }

        public DbSet<User> Users { get; set; }
        public DbSet<OrgType> OrgTypes { get; set; }
        public DbSet<OrgDetails> OrgDetails { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<OrgnaizationsApplication> OrgnaizationsApplications { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Age> Ages { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<WorkNature> WorkNatures { get; set; }
        public DbSet<HandicappedCategory> HandicappedCategory { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<CommunicationType> CommunicationType { get; set; }
        public DbSet<ProgressType> ProgressTypes { get; set; }
        public DbSet<AccommodationType> AccommodationType { get; set; }
        public DbSet<EducationalStatus> EducationalStatus { get; set; }
        public DbSet<EconomicLevel> EconomicLevel { get; set; }
        public DbSet<HandicappedInfo> HandicappedInfo { get; set; }
    }
}