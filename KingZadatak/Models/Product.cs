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
        public string Description { get; set; }
        public string Thumbnail { get; set; }
    }
}
