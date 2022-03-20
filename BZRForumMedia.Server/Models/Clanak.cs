namespace BZRForumMedia.Server.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
   
    public class Clanak
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Naslov { get; set; }
        public string Autor { get; set; }
        public DateTime DatumObjavljivanja { get; set; }
        public string TekstClanka { get; set; }
    }
}
