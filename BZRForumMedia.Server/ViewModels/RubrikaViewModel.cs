namespace BZRForumMedia.Server.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class RubrikaViewModel
    {
        [Required(ErrorMessage = "Polje mora biti popunjeno")]
        public string Naziv { get; set; }
    }
}
