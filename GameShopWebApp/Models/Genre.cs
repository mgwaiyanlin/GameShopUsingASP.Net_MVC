using System.ComponentModel.DataAnnotations;

namespace GameShopWebApp.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "You must fill the genre input box!")]
        public string? Name { get; set; }

    }
}
