namespace BZRForumMedia.Server.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class VrstaPropisaViewModel
    {
        [Required(ErrorMessage = "Polje mora biti popunjeno")]
        [StringLength(2000)]
        public string Naziv { get; set; }
    }
}
