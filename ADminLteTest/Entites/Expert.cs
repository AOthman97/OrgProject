using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ADminLteTest.Entites
{
    public class Expert
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "الإسم الكامل مطلوب!")]
        [Display(Name = "الإسم الكامل")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "العنوان مطلوب!")]
        [Display(Name = "العنوان")]
        public string Address { get; set; }
        [Required(ErrorMessage = "رقم الهاتف مطلوب!")]
        [Display(Name = "رقم الهاتف")]
        public string PersonalMobile { get; set; }
        [Required(ErrorMessage = "رقم العمل مطلوب!")]
        [Display(Name = "رقم العمل")]
        public string WorkMobile { get; set; }
        [Required(ErrorMessage = "البريد مطلوب!")]
        [Display(Name = "البريد")]
        public string RegularMail { get; set; }
        [Required(ErrorMessage = "البريد الإليكتروني مطلوب!")]
        [Display(Name = "البريد الإليكتروني")]
        public string Email { get; set; }
        [Required(ErrorMessage = "جهة العمل مطلوبة!")]
        [Display(Name = "جهة العمل")]
        public string WorkingFor { get; set; }
        [Required(ErrorMessage = "طبيعة العمل مطلوبة!")]
        [Display(Name = "طبيعة العمل")]
        public int WorkNatureNo { get; set; }
        [ForeignKey("WorkNatureNo")]
        public WorkNature? WorkNature { get; set; }
    }
}