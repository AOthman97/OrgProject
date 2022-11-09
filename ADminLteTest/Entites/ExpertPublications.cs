using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ADminLteTest.Entites
{
    public class ExpertPublications
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "الخبير مطلوب!")]
        [Display(Name = "الخبير")]
        public int ExpertNo { get; set; }
        [ForeignKey("ExpertNo")]
        public Expert? Expert { get; set; }
        [Required(ErrorMessage = "العنوان مطلوب!")]
        [Display(Name = "العنوان")]
        public string Title { get; set; }
        [Required(ErrorMessage = "الناشر مطلوب!")]
        [Display(Name = "الناشر")]
        public string Publisher { get; set; }
        [Required(ErrorMessage = "سنة النشر مطلوبة!")]
        [DataType(DataType.Date)]
        [Display(Name = "سنة النشر")]
        public DateTime PublishYear { get; set; }
    }
}