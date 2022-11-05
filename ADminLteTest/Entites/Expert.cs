using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ADminLteTest.Entites
{
    public class Expert
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PersonalMobile { get; set; }
        public string WorkMobile { get; set; }
        public string RegularMail { get; set; }
        public string Email { get; set; }
        public string WorkingFor { get; set; }
        public int WorkNatureNo { get; set; }
        [ForeignKey("WorkNatureNo")]
        public WorkNature? WorkNature { get; set; }
    }
}