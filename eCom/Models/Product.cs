using System.ComponentModel.DataAnnotations;

namespace eCom.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        public Genre Genre { get; set; }
        [Required]
        public int GenreId { get; set; }

        public Supplier Supplier { get; set; }
        [Required]
        public int SupplierId { get; set; }
    }
}