namespace BZRForumMedia.Server.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class RegisterViewModel
    {
        [Required]
        public string Ime { get; set; }

        [Required]
        public string Prezime{ get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Broj telefona")]
        public string BrojTelefona { get; set; }

        [Required]
        [Display(Name = "Naziv kompanije")]
        public string NazivKompanije { get; set; }

        [Required]
        [Display(Name = "Naziv pozicije")]
        public string NazivPozivije { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Lozinka")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Ponovi lozinku")]
        [Compare("Password",
            ErrorMessage = "Lozinke se ne poklapaju")]
        public string ConfirmPassword { get; set; }


    }
}
