namespace BZRForumMedia.Server.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
  
    public class PitanjaIOdgovori
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Naslov { get; set; }
        [Required]
        public string Pitanje { get; set; }
        [Required]
        public string Odgovor { get; set; }
    }
}
