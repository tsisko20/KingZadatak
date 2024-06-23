using System.ComponentModel.DataAnnotations;

namespace KingZadatak.Models
{
    public class Product
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public double Price { get; set; }
        [StringLength(100, ErrorMessage = "Description can't be longer than 100 characters.")]
        public string Description { get; set; }
        public string Thumbnail { get; set; }
    }
}
