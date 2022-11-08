using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ADminLteTest.Entites
{
    public class HandicappedCategory
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "المنظمة مطلوبة!")]
        [Display(Name = "المنظمة")]
        public int OrgDetailsNo { get; set; }
        [ForeignKey("OrgDetailsNo")]
        public OrgDetails? OrgDetails { get; set; }
        [Required(ErrorMessage = "نوع الحالة الخاصة مطلوب!")]
        [Display(Name = "نوع الحالة الخاصة")]
        public int CategoryNo { get; set; }
        [ForeignKey("CategoryNo")]
        public Category? Categories { get; set; }
        [Required(ErrorMessage = "الفئة العمرية مطلوبة!")]
        [Display(Name = "الفئة العمرية")]
        public int AgeNo { get; set; }
        [ForeignKey("AgeNo")]
        public Age? Ages { get; set; }
        [Required(ErrorMessage = "النوع مطلوب!")]
        [Display(Name = "النوع")]
        public int GenderNo { get; set; }
        [ForeignKey("GenderNo")]
        public Gender? Genders { get; set; }
        [Required(ErrorMessage = "العدد مطلوب!")]
        [Display(Name = "العدد")]
        public int Quantity { get; set; }
    }
}