using System.ComponentModel.DataAnnotations;

namespace eCom.Models
{
    public class Status
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(16)]
        public string Name { get; set; }
    }
}