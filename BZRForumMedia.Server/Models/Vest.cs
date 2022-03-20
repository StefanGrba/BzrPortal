namespace BZRForumMedia.Server.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Vest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Naslov { get; set; }
        public string Tekst { get; set; }
        public DateTime? DatumObjavljivanja { get; set; }
        public string Podnaslov { get; set; }
        public string Sazetak { get; set; }
        public string PutanjaDoSlike { get; set; }
    }
}
