namespace BZRForumMedia.Server.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class PitanjaIOdgovoriViewModel
    {
        [Required(ErrorMessage ="Ovo polje je obavezno")]
        public string Naslov { get; set; }
        [Required(ErrorMessage = "Ovo polje je obavezno")]
        public string Pitanje { get; set; }
        [Required(ErrorMessage = "Ovo polje je obavezno")]
        public string Odgovor { get; set; }
    }
}
