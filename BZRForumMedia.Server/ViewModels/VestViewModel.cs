namespace BZRForumMedia.Server.ViewModels
{
    using Microsoft.AspNetCore.Http;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class VestViewModel
    {
        [Required(ErrorMessage = "Ovo polje je obavezno")]
        public string Naslov { get; set; }
        public string Podnaslov { get; set; }
        [Required(ErrorMessage = "Ovo polje je obavezno")]
        public string Tekst { get; set; }
        [Required(ErrorMessage = "Ovo polje je obavezno")]
        [Display(Name = "Sažetak")]
        public string Sazetak { get; set; }
        [Display(Name = "Datum objavljivanja")]
        public DateTime? DatumObjavljivanja { get; set; }
        [Display(Name = "Slika")]
        public IFormFile PutanjaDoSlike { get; set; }
    }
}
