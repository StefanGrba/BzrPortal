namespace BZRForumMedia.Server.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class CreateRoleViewModel
    {
        [Required]
        [Display(Name = "Ime role")]
        public string RoleName { get; set; }
    }
}
