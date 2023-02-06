using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Test1.Models
{
    public class StaffParam
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;

    }
}
