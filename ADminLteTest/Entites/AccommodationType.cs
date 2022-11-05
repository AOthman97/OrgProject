using System.ComponentModel.DataAnnotations;

namespace ADminLteTest.Entites
{
    public class AccommodationType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameAr { get; set; }
    }
}