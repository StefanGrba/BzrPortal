namespace BZRForumMedia.Server.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Propis
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? IdRubrika { get; set; }
        public int? IdPodrubrika { get; set; }
        public string Naslov { get; set; }
        public string GlasiloIDatum { get; set; }
        public string TekstPropisa { get; set; }
        public int? IdVrstaPropis { get; set; }
        public string Donosilac { get; set; }
        public string NivoVazenja { get; set; }
        public DateTime? DatumStupanjaNaSnaguPropisa{ get; set; }
        public DateTime? DatumPrestankaVerzije { get; set; }
        public DateTime? DatumObjavljivanjeVerzije { get; set; }
        public DateTime? DatumObjavljivanjaOsnovnogTeksta { get; set; }
        public DateTime? DatumStupanjaNaSnaguMedjunarodnogUgovora { get; set; }
        public DateTime? DatumStupanjaNaSnaguOsnovnogTeksta { get; set; }
        public DateTime? DatumPrestankaVazenjaPropisa { get; set; }
        public DateTime? DatumPocetkaPrimene { get; set; }
        public string PravniOsnovZaDonosenjePropisa { get; set; }
        public string NormaOsnovaZaDonosenje { get; set; }
        public string PropisKojiJePrestaoDaVazi { get; set; }
        public string NormaOsnovaZaPrestanakVazenja { get; set; }
        public DateTime? DatumPrestankaVazenjaPravnogPrethodnika { get; set; }
        public string IstorijskaVerzijaPropisa { get; set; }
        public string Napomena { get; set; }
        public string NapomenaGlasnika { get; set; }

        public Rubrika IdRubrikaNavigation { get; set; }
        public Podrubrika IdPodrubrikaNavigation { get; set; }
        public VrstaPropisa IdVrstaPropisaNavigation { get; set; }

    }
}
