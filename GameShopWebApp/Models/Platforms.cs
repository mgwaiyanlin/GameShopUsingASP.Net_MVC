using System.ComponentModel.DataAnnotations;

namespace GameShopWebApp.Models
{
    public class Platforms
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
    }
}
