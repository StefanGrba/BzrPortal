namespace BZRForumMedia.Server.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class TipDokumentacije
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string ImeTipa { get; set; }

        public IEnumerable<Dokumentacija> Dokumentacije { get; set; } = new HashSet<Dokumentacija>();
    }
}
