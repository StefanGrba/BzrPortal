namespace BZRForumMedia.Server.ViewModels
{
    using Microsoft.AspNetCore.Http;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class DokumentViewModel
    {
        public string Naslov { get; set; }
        public string Autor { get; set; }
        [Display(Name = "Datum objavljivanja")]
        public DateTime? DatumObjavljivanja { get; set; }
        public string Tekst { get; set; }
        public string Napomena { get; set; }
        [Display(Name = "Pdf")]
        public IFormFile PdfPutanja { get; set; }
        public IFormFile WordPutanja { get; set; }
        public int IdTipa { get; set; }
    }
}
