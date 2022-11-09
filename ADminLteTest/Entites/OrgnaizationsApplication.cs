using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ADminLteTest.Entites
{
    public class OrgnaizationsApplication
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "الإسم مطلوب!")]
        [Display(Name = "الإسم")]
        public string ApplicantName { get; set; }
        [Required(ErrorMessage = "تاريخ التقديم مطلوب!")]
        [DataType(DataType.Date)]
        [Display(Name = "تاريخ التقديم")]
        public DateTime ApplicationDate { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "المنظمة مطلوب!")]
        [Display(Name = "المنظمة")]
        public int OrgDetailsNo { get; set; }
        [ForeignKey("OrgDetailsNo")]
        public OrgDetails? OrgDetails { get; set; }
        [Required(ErrorMessage = "طبيعة العمل مطلوبة!")]
        [Display(Name = "طبيعة العمل")]
        public int WorkNutureNo { get; set; }
        [ForeignKey("WorkNutureNo")]
        public WorkNature? WorkNature { get; set; }
        [Required(ErrorMessage = "التوظيف مطلوب!")]
        [Display(Name = "التوظيف إنجليزي")]
        public int StaffNo { get; set; }
        [ForeignKey("StaffNo")]
        public Staff? Staff { get; set; }
        [Display(Name = "هل تم التواصل")]
        public bool IsApproched { get; set; }
        [Required(ErrorMessage = "طبيعة التواصل مطلوبة!")]
        [Display(Name = "طبيعة التواصل")]
        public string ApprochNature { get; set; }
        [Display(Name = "غرفة موارد")]
        public  bool ResourcesRoom { get; set; }
        [Required(ErrorMessage = "مدة المؤهلات مطلوب!")]
        [Display(Name = "مدة المؤهلات")]
        public int QualificationPeriod { get; set; }
        [Display(Name = "هل هو متقدم")]
        public bool IsProgreessed { get; set; }
        [Required(ErrorMessage = "نوع التقدم مطلوب!")]
        [Display(Name = "نوع التقدم")]
        public int ProgressTypeNo { get; set; }
        [ForeignKey("ProgressTypeNo")]
        public ProgressType? ProgressType { get; set; }
        [Required(ErrorMessage = "التعليق مطلوب!")]
        [Display(Name = "التعليق")]
        public string Comment { get; set; }
        [Required(ErrorMessage = "نوع التواصل مطلوب!")]
        [Display(Name = "نوع التواصل")]
        public int CommunicationTypeNo { get; set; }
        [ForeignKey("CommunicationTypeNo")]
        public CommunicationType? CommunicationType { get; set; }
        [Required(ErrorMessage = "الأفكار والمقترحات مطلوبة!")]
        [Display(Name = "الأفكار والمقترحات")]
        public string IdeasAndRecommondaions { get; set; }
    }
}
