namespace BZRForumMedia.Server.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Dokumentacija
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Naslov { get; set; }
        public string Autor { get; set; }
        public DateTime? DatumObjavljivanja { get; set; }
        public string Tekst { get; set; }
        public string Napomena { get; set; }
        public string PdfPutanja { get; set; }
        public string WordPutanja { get; set; }
        public int IdTipa { get; set; }

        public TipDokumentacije IdTipaNavigation { get; set; }
    }
}
