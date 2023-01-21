using System.ComponentModel.DataAnnotations;

namespace WebAPIApp.Models
{
    public class Posts
    {
        [Required]
        public int UserId { get; set; }
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public String? Title { get; set; }
        [Required]
        [MaxLength(250)]
        public String? Body { get; set; }
    }
}