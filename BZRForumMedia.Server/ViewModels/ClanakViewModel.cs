namespace BZRForumMedia.Server.ViewModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class ClanakViewModel
    {
        [Required]
        public string Naslov { get; set; }
        public string Autor { get; set; }
        [Display(Name = "Datum objavljivanja")]
        public DateTime DatumObjavljivanja { get; set; }
        [Display(Name = "Tekst članka")]
        public string TekstClanka { get; set; }
    }
}
