using System.ComponentModel.DataAnnotations;

namespace xiaoPage.Model
{
    public class Actor
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [Range(1950, 2023, ErrorMessage = "Birthday must be between 1-100")]
        public int Birthday { get; set; }
    }
}
