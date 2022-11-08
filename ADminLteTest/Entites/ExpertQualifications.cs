using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ADminLteTest.Entites
{
    public class ExpertQualifications
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "الخبير مطلوب!")]
        [Display(Name = "الخبير")]
        public int ExpertNo { get; set; }
        [ForeignKey("ExpertNo")]
        public Expert? Expert { get; set; }
        [Required(ErrorMessage = "المؤهل العلمي مطلوب!")]
        [Display(Name = "المؤهل العلمي")]
        public int QualificationsNo { get; set; }
        [ForeignKey("QualificationsNo")]
        public Qualifications? Qualification { get; set; }
        [Required(ErrorMessage = "القسم مطلوب!")]
        [Display(Name = "القسم")]
        public string Division { get; set; }
        [Required(ErrorMessage = "الكلية مطلوبة!")]
        [Display(Name = "الكلية")]
        public string Faculty { get; set; }
        [Required(ErrorMessage = "الجامعة مطلوبة!")]
        [Display(Name = "الجامعة")]
        public string University { get; set; }
        [Required(ErrorMessage = "تاريخ التخرج مطلوب!")]
        [Display(Name = "تاريخ التخرج")]
        public DateTime GraduationDate { get; set; }
    }
}