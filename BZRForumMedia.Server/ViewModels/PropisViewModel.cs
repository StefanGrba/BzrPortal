namespace BZRForumMedia.Server.ViewModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class PropisViewModel
    {
        public string Naslov { get; set; }
        [Display(Name = "Glasilo i datum")]
        public string GlasiloIDatum { get; set; }
        [Display(Name = "Tekst propisa")]
        public string TekstPropisa { get; set; }
        [Display(Name = "Vrsta propisa")]
        public int? IdVrstaPropis { get; set; }
        public string Donosilac { get; set; }
        [Display(Name = "Nivo važenja")]
        public string NivoVazenja { get; set; }
        [Display(Name = "Datum stupanja na snagu propisa")]
        public DateTime? DatumStupanjaNaSnaguPropisa { get; set; }
        [Display(Name = "Datum prestanka verzije")]
        public DateTime? DatumPrestankaVerzije { get; set; }
        [Display(Name = "Datum objavljivanja verzije")]
        public DateTime? DatumObjavljivanjeVerzije { get; set; }
        [Display(Name = "Datum objavljivanja osnovnog teksta")]
        public DateTime? DatumObjavljivanjaOsnovnogTeksta { get; set; }
        [Display(Name = "Datum stupanja na snagu međunarodnog ugovora")]
        public DateTime? DatumStupanjaNaSnaguMedjunarodnogUgovora { get; set; }
        [Display(Name = "Datum stupanja na snagu osnovnog teksta propisa")]
        public DateTime? DatumStupanjaNaSnaguOsnovnogTeksta { get; set; }
        [Display(Name = "Datum prestanka važenja propisa")]
        public DateTime? DatumPrestankaVazenjaPropisa { get; set; }
        [Display(Name = "Datum početka primene")]
        public DateTime? DatumPocetkaPrimene { get; set; }
        [Display(Name = "Pravni osnov za donošenje propisa")]
        public string PravniOsnovZaDonosenjePropisa { get; set; }
        [Display(Name = "Norma osnova za donošenje")]
        public string NormaOsnovaZaDonosenje { get; set; }
        [Display(Name = "Propis koji je prestao da važi")]
        public string PropisKojiJePrestaoDaVazi { get; set; }
        [Display(Name = "Norma za prestanak važenja")]
        public string NormaOsnovaZaPrestanakVazenja { get; set; }
        [Display(Name = "Datum prestanka važenja pravnog prethodnika")]
        public DateTime? DatumPrestankaVazenjaPravnogPrethodnika { get; set; }
        [Display(Name = "Istorijska verzija propisa")]
        public string IstorijskaVerzijaPropisa { get; set; }
        public string Napomena { get; set; }
        [Display(Name = "Napomena glasnika")]
        public string NapomenaGlasnika { get; set; }
    }
}
