using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ADminLteTest.Entites
{
    public class ExpertQualifications
    {
        [Key]
        public int Id { get; set; }
        public int ExpertNo { get; set; }
        [ForeignKey("ExpertNo")]
        public Expert? Expert { get; set; }
        public int QualificationsNo { get; set; }
        [ForeignKey("QualificationsNo")]
        public Qualifications? Qualification { get; set; }
        public string Division { get; set; }
        public string Faculty { get; set; }
        public string University { get; set; }
        public DateTime GraduationDate { get; set; }
    }
}