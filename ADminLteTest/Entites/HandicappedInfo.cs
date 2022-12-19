using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ADminLteTest.Entites
{
    public class HandicappedInfo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "الإسم الكامل مطلوب!")]
        [Display(Name = "الإسم الكامل")]
        public string FullName { get; set; }
        //[Required(ErrorMessage = "عنوان السكن مطلوب!")]
        [Display(Name = "عنوان السكن")]
        public string? Address { get; set; }
        //[Required(ErrorMessage = "نقاط الضعف عند المعاق مطلوبة!")]
        [Display(Name = "نقاط الضعف عند المعاق")]
        public string? Weaknesses { get; set; }
        //[Required(ErrorMessage = "رقم هاتف الأب مطلوب!")]
        [Display(Name = "رقم هاتف الأب")]
        public string? FatherMobile { get; set; }
        //[Required(ErrorMessage = "رقم هاتف الأم مطلوب!")]
        [Display(Name = "رقم هاتف الأم")]
        public string? MotherMobile { get; set; }
        //[Required(ErrorMessage = "تاريخ الميلاد مطلوب!")]
        [DataType(DataType.Date)]
        [Display(Name = "تاريخ الميلاد")]
        public DateTime? BirthDate { get; set; }
        //[Required(ErrorMessage = "العمر مطلوب!")]
        [Display(Name = "العمر")]
        public int? Age { get; set; }
        //[Required(ErrorMessage = "النوع مطلوب!")]
        [Display(Name = "الجنس")]
        public int GenderNo { get; set; }
        [ForeignKey("GenderNo")]
        public Gender? Genders { get; set; }
        //[Required(ErrorMessage = "المركز أو الجمعية الملتحق بها مطلوبة!")]
        [Display(Name = "المركز أو الجمعية الملتحق بها")]
        public int? OrgDetailsNo { get; set; }
        [ForeignKey("OrgDetailsNo")]
        public OrgDetails? OrgDetails { get; set; }
        //[Required(ErrorMessage = "المدينة مطلوبة!")]
        [Display(Name = "المدينة")]
        public int? CityNo { get; set; }
        [ForeignKey("CityNo")]
        public City? Cities { get; set; }
        //[Required(ErrorMessage = "المحلية مطلوبة!")]
        [Display(Name = "المحلية")]
        public int? DistrictNo { get; set; }
        [ForeignKey("DistrictNo")]
        public District? Districts { get; set; }
        //[Required(ErrorMessage = "نوع الإعاقة الذهنية مطلوب!")]
        [Display(Name = "نوع الإعاقة الذهنية")]
        public int? CategoryNo { get; set; }
        [ForeignKey("CategoryNo")]
        public Category? Categories { get; set; }
        //[Required(ErrorMessage = "طبيعة العمل مطلوبة!")]
        [Display(Name = "إذا كانت الإجابة بنعم اذكري نوع العمل")]
        public int? WorkNatureNo { get; set; }
        [ForeignKey("WorkNatureNo")]
        public WorkNature? WorkNatures { get; set; }
        //[Required(ErrorMessage = "المستوى الإقتصادي للأسرة مطلوب!")]
        [Display(Name = "المستوى الإقتصادي للأسرة")]
        public int? EconomicLevelNo { get; set; }
        [ForeignKey("EconomicLevelNo")]
        public EconomicLevel? EconomicLevels { get; set; }
        //[Required(ErrorMessage = "السكن مطلوب!")]
        [Display(Name = "السكن")]
        public int? AccommodationTypeNo { get; set; }
        [ForeignKey("AccommodationTypeNo")]
        public AccommodationType? AccommodationTypes { get; set; }
        //[Required(ErrorMessage = "المستوى التعليمي للمعاق مطلوب!")]
        [Display(Name = "المستوى التعليمي للمعاق")]
        public int? EducationalStatusNo { get; set; }
        [ForeignKey("EducationalStatusNo")]
        public EducationalStatus? PersonalEducationalStatuses { get; set; }
        //[Required(ErrorMessage = "المستوى التعليمي للوالد مطلوب!")]
        [Display(Name = "المستوى التعليمي للوالد")]
        public int? FatherEducationalStatusNo { get; set; }
        [ForeignKey("FatherEducationalStatusNo")]
        public EducationalStatus? FatherEducationalStatuses { get; set; }
        //[Required(ErrorMessage = "المستوى التعليمي للوالدة مطلوب!")]
        [Display(Name = "المستوى التعليمي للوالدة")]
        public int? MotherEducationalStatusNo { get; set; }
        [ForeignKey("MotherEducationalStatusNo")]
        public EducationalStatus? MotherEducationalStatuses { get; set; }
        [Display(Name = "هل انت أم عاملة؟")]
        public bool IsWorking { get; set; }
        [Display(Name = "حافظ للقرآن")]
        public bool HafezCapability { get; set; }
        [Display(Name = "السباحة")]
        public bool SwimmingCapability { get; set; }
        [Display(Name = "التلوين والرسم")]
        public bool DrawAndColoringCapability { get; set; }
        [Display(Name = "قدرات أدبية")]
        public bool LiteratureCapability { get; set; }
        [Display(Name = "ترتيب المعاق بين إخوانه")]
        public int? OrderInFamily { get; set; }
    }
}