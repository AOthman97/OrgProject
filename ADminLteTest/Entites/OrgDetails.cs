using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ADminLteTest.Entites
{
    public class OrgDetails
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "الإسم إنجليزي مطلوب!")]
        [Display(Name = "الإسم إنجليزي")]
        public string Name { get; set; }
        [Required(ErrorMessage = "الإسم عربي مطلوب!")]
        [Display(Name = "الإسم عربي")]
        public string NameAr { get; set; }
        [Required(ErrorMessage = "إسم المدير مطلوب!")]
        [Display(Name = "إسم المدير")]
        public string DirectorName { get; set; }
        [Required(ErrorMessage = "رقم الهاتف مطلوب!")]
        [Display(Name = "رقم الهاتف")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "البريد الإليكتروني مطلوب!")]
        [Display(Name = "البريد الإليكتروني")]
        public string Email { get; set; }
        [Required(ErrorMessage = "تاريخ التأسيس مطلوب!")]
        [Display(Name = "تاريخ التأسيس")]
        public DateTime FaoundationDate { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "المدينة مطلوبة!")]
        [Display(Name = "المدينة")]
        public int CityNo { get; set; }
        [ForeignKey("CityNo")]
        public City? City { get; set; }
        [Required(ErrorMessage = "المحلية مطلوبة!")]
        [Display(Name = "المحلية")]
        public int DistrictNo { get; set; }
        [ForeignKey("DistrictNo")]
        public District? District { get; set; }
        [Required(ErrorMessage = "نوع المنظمة مطلوب!")]
        [Display(Name = "نوع المنظمة")]
        public int OrgTypeNo { get; set; }
        [ForeignKey("OrgTypeNo")]
        public OrgType? OrgType { get; set; }
    }
}
