using System.ComponentModel.DataAnnotations;

namespace ADminLteTest.Entites
{
    public class EconomicLevel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameAr { get; set; }
    }
}