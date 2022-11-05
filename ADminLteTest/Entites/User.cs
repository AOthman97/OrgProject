using System.ComponentModel.DataAnnotations;

namespace ADminLteTest.Entites
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]

        [MaxLength(12)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Required, MaxLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public DateTime? CreationDate { get; set; } = DateTime.Now;
        public DateTime? DeleteDate { get; set; }
        public DateTime? UpdateDate { get; set; } 
    }
}
