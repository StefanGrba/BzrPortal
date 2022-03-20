namespace BZRForumMedia.Server.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class VideoViewModel
    {
        [Required]
        public string Naslov { get; set; }
        [Required]
        public string VideoPath { get; set; }
    }
}
