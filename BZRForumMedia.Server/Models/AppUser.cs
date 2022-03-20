namespace BZRForumMedia.Server.Models
{
    using Microsoft.AspNetCore.Identity;
 
    public class AppUser : IdentityUser
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojTelefona { get; set; }
        public string NazivKompanije { get; set; }
        public string NazivRadnogMesta { get; set; }
    }
}
