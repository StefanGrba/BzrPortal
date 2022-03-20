namespace BZRForumMedia.Server.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class PodrubrikaViewModel
    {
        [Required(ErrorMessage = "Polje mora biti popunjeno")]
        public string Naziv
        {
            get; set;
        }
    }
}
