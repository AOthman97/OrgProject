using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ADminLteTest.Entites
{
    public class ExpertTraining
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "الخبير مطلوب!")]
        [Display(Name = "الخبير")]
        public int ExpertNo { get; set; }
        [ForeignKey("ExpertNo")]
        public Expert? Expert { get; set; }
        [Required(ErrorMessage = "عنوان الدورة مطلوب!")]
        [Display(Name = "عنوان الدورة")]
        public string TrainingName { get; set; }
        [Required(ErrorMessage = "العنوان مطلوب!")]
        [Display(Name = "العنوان")]
        public string Address { get; set; }
        [Required(ErrorMessage = "المدة مطلوبة!")]
        [Display(Name = "المدة")]
        public int Period { get; set; }
        [Required(ErrorMessage = "التاريخ مطلوب!")]
        [DataType(DataType.Date)]
        [Display(Name = "التاريخ")]
        public DateTime Date { get; set; }
    }
}