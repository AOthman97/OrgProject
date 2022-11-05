using System.ComponentModel.DataAnnotations;

namespace ADminLteTest.Entites
{
    public class Qualifications
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameAr { get; set; }
        public bool IsBsc { get; set; }
        public bool IsMsc { get; set; }
        public bool IsPhd { get; set; }
    }
}