using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ADminLteTest.Entites
{
    public class HandicappedInfo
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Weaknesses { get; set; }
        public string FatherMobile { get; set; }
        public string MotherMobile { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public int GenderNo { get; set; }
        [ForeignKey("GenderNo")]
        public Gender? Genders { get; set; }
        public int OrgDetailsNo { get; set; }
        [ForeignKey("OrgDetailsNo")]
        public OrgDetails? OrgDetails { get; set; }
        public int CityNo { get; set; }
        [ForeignKey("CityNo")]
        public City? Cities { get; set; }
        public int DistrictNo { get; set; }
        [ForeignKey("DistrictNo")]
        public District? Districts { get; set; }
        public int CategoryNo { get; set; }
        [ForeignKey("CategoryNo")]
        public Category? Categories { get; set; }
        public int WorkNatureNo { get; set; }
        [ForeignKey("WorkNatureNo")]
        public WorkNature? WorkNatures { get; set; }
        public int EconomicLevelNo { get; set; }
        [ForeignKey("EconomicLevelNo")]
        public EconomicLevel? EconomicLevels { get; set; }
        public int AccommodationTypeNo { get; set; }
        [ForeignKey("AccommodationTypeNo")]
        public AccommodationType? AccommodationTypes { get; set; }
        public int EducationalStatusNo { get; set; }
        [ForeignKey("EducationalStatusNo")]
        public EducationalStatus? PersonalEducationalStatuses { get; set; }
        public int FatherEducationalStatusNo { get; set; }
        [ForeignKey("FatherEducationalStatusNo")]
        public EducationalStatus? FatherEducationalStatuses { get; set; }
        public int MotherEducationalStatusNo { get; set; }
        [ForeignKey("MotherEducationalStatusNo")]
        public EducationalStatus? MotherEducationalStatuses { get; set; }
        public bool IsWorking { get; set; }
        public bool HafezCapability { get; set; }
        public bool SwimmingCapability { get; set; }
        public bool DrawAndColoringCapability { get; set; }
        public bool LiteratureCapability { get; set; }
    }
}