namespace BZRForumMedia.Server.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Podrubrika
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(2000)]
        public string Naziv { get; set; }

        public IEnumerable<Propis> Propisi { get; set; } = new HashSet<Propis>();
    }
}
