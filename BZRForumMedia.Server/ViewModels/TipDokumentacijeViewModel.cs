namespace BZRForumMedia.Server.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class TipDokumentacijeViewModel
    {
        [Required(ErrorMessage = "Morate popuniti ovo polje")]
        [Display(Name = "Naziv tipa")]
        public string ImeTipa { get; set; }
    }
}
