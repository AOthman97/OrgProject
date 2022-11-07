using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ADminLteTest.Entites
{
    public class ExpertTraining
    {
        [Key]
        public int Id { get; set; }
        public int ExpertNo { get; set; }
        [ForeignKey("ExpertNo")]
        public Expert? Expert { get; set; }
        public string TrainingName { get; set; }
        public string Address { get; set; }
        public int Period { get; set; }
        public DateTime Date { get; set; }
    }
}