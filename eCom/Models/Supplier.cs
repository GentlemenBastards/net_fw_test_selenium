using System.ComponentModel.DataAnnotations;

namespace eCom.Models
{
    public class Supplier
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Address { get; set; }

        [Required]
        [MaxLength(12)]
        [RegularExpression("^[0-9 ]*$", ErrorMessage = "zipcode must be numeric")]
        public string zipcode { get; set; }

        [Required]
        [MaxLength(36)]
        public string City { get; set; }
    }
}