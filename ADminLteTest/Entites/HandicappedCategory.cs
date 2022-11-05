using System.ComponentModel.DataAnnotations.Schema;

namespace ADminLteTest.Entites
{
    public class HandicappedCategory
    {
        public int Id { get; set; }
        public int OrgDetailsNo { get; set; }
        [ForeignKey("OrgDetailsNo")]
        public OrgDetails? OrgDetails { get; set; }
        public int CategoryNo { get; set; }
        [ForeignKey("CategoryNo")]
        public Category? Categories { get; set; }
        public int AgeNo { get; set; }
        [ForeignKey("AgeNo")]
        public Age? Ages { get; set; }
        public int GenderNo { get; set; }
        [ForeignKey("GenderNo")]
        public Gender? Genders { get; set; }
        public int Quantity { get; set; }
    }
}