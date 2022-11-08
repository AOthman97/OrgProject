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
        [Required(ErrorMessage = "العنوان مطلوب!")]
        [Display(Name = "العنوان")]
        public string Address { get; set; }
        [Required(ErrorMessage = "نقاط الضعف مطلوب!")]
        [Display(Name = "نقاط الضعف")]
        public string Weaknesses { get; set; }
        [Required(ErrorMessage = "رقم هاتف الأب مطلوب!")]
        [Display(Name = "رقم هاتف الأب")]
        public string FatherMobile { get; set; }
        [Required(ErrorMessage = "رقم هاتف الأم مطلوب!")]
        [Display(Name = "رقم هاتف الأم")]
        public string MotherMobile { get; set; }
        [Required(ErrorMessage = "تاريخ الميلاد مطلوب!")]
        [Display(Name = "تاريخ الميلاد")]
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "العمر مطلوب!")]
        [Display(Name = "العمر")]
        public int Age { get; set; }
        [Required(ErrorMessage = "النوع مطلوب!")]
        [Display(Name = "النوع")]
        public int GenderNo { get; set; }
        [ForeignKey("GenderNo")]
        public Gender? Genders { get; set; }
        [Required(ErrorMessage = "المنظمة مطلوبة!")]
        [Display(Name = "المنظمة")]
        public int OrgDetailsNo { get; set; }
        [ForeignKey("OrgDetailsNo")]
        public OrgDetails? OrgDetails { get; set; }
        [Required(ErrorMessage = "المدينة مطلوبة!")]
        [Display(Name = "المدينة")]
        public int CityNo { get; set; }
        [ForeignKey("CityNo")]
        public City? Cities { get; set; }
        [Required(ErrorMessage = "المحلية مطلوبة!")]
        [Display(Name = "المحلية")]
        public int DistrictNo { get; set; }
        [ForeignKey("DistrictNo")]
        public District? Districts { get; set; }
        [Required(ErrorMessage = "نوع الحالة الخاصة مطلوب!")]
        [Display(Name = "نوع الحالة الخاصة")]
        public int CategoryNo { get; set; }
        [ForeignKey("CategoryNo")]
        public Category? Categories { get; set; }
        [Required(ErrorMessage = "طبيعة العمل مطلوبة!")]
        [Display(Name = "طبيعة العمل")]
        public int WorkNatureNo { get; set; }
        [ForeignKey("WorkNatureNo")]
        public WorkNature? WorkNatures { get; set; }
        [Required(ErrorMessage = "الحالة الإقتصادية مطلوبة!")]
        [Display(Name = "الحالة الإقتصادية")]
        public int EconomicLevelNo { get; set; }
        [ForeignKey("EconomicLevelNo")]
        public EconomicLevel? EconomicLevels { get; set; }
        [Required(ErrorMessage = "نوع السكن مطلوب!")]
        [Display(Name = "نوع السكن")]
        public int AccommodationTypeNo { get; set; }
        [ForeignKey("AccommodationTypeNo")]
        public AccommodationType? AccommodationTypes { get; set; }
        [Required(ErrorMessage = "الحالة التعليمية مطلوبة!")]
        [Display(Name = "الحالة التعليمية")]
        public int EducationalStatusNo { get; set; }
        [ForeignKey("EducationalStatusNo")]
        public EducationalStatus? PersonalEducationalStatuses { get; set; }
        [Required(ErrorMessage = "حالة الأب التعليمية مطلوبة!")]
        [Display(Name = "حالة الأب التعليمية")]
        public int FatherEducationalStatusNo { get; set; }
        [ForeignKey("FatherEducationalStatusNo")]
        public EducationalStatus? FatherEducationalStatuses { get; set; }
        [Required(ErrorMessage = "حالة الأم التعليمية مطلوبة!")]
        [Display(Name = "حالة الأم التعليمية")]
        public int MotherEducationalStatusNo { get; set; }
        [ForeignKey("MotherEducationalStatusNo")]
        public EducationalStatus? MotherEducationalStatuses { get; set; }
        [Display(Name = "هل يعمل حاليا")]
        public bool IsWorking { get; set; }
        [Display(Name = "حافظ للقرآن")]
        public bool HafezCapability { get; set; }
        [Display(Name = "السباحة")]
        public bool SwimmingCapability { get; set; }
        [Display(Name = "التلوين والرسم")]
        public bool DrawAndColoringCapability { get; set; }
        [Display(Name = "قدرات أدبية")]
        public bool LiteratureCapability { get; set; }
    }
}