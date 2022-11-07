using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ADminLteTest.Entites
{
    public class ExpertPublications
    {
        [Key]
        public int Id { get; set; }
        public int ExpertNo { get; set; }
        [ForeignKey("ExpertNo")]
        public Expert? Expert { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public DateTime PublishYear { get; set; }
    }
}