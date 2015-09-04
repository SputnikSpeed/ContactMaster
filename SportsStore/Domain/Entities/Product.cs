namespace SportsStore.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Web.Mvc;
    


    public class Product
    {
        [HiddenInput(DisplayValue = false)]
       
        [Key] public int ProductID { get; set; }
        [Required(ErrorMessage="Bitte geben Sie ein Datum ein")]
        [Display(Name = "Datum")]
        public string Datum { get; set; }
          [Required(ErrorMessage = "Bitte geben Sie den Namen der Veranstaltung an")]
          [Display(Name = "Auf welcher Veranstaltung kennengelernt")]
        public string Veranstaltung { get; set; }


          [Required(ErrorMessage = "Bitte geben Sie die Branche an")]
          [Display(Name = "Branche")]

        public int BrancheID {get; set;}
    [Display(Name = "Firmenname")]

        public string Firma { get; set; }
         
          [Display(Name = "Vorname")]
        public string Vorname { get; set; }
          [Required(ErrorMessage = "Bitte geben Sie einen Nachnamen an")]
          [Display(Name = "Nachname")]
        public string Nachname { get; set; }
        [Display(Name = "USP")]

        public string USP { get; set; }
         [Required(ErrorMessage = "Bitte geben Sie den Zielkunden an")]
         [Display(Name = "Was ist der Zielkunde")]
        public string Zielkunde { get; set; }
        [DataType(DataType.MultilineText)]
        [Display(Name = "Wie kann ich helfen")]
        public string ich { get; set; }
        [DataType(DataType.MultilineText)]
        [Display(Name = "Wie kann sie/er mir helfen")]
        public string er { get; set; }
        [Display(Name = "Mögliche Empfehlungen")]
        public string Empfehlungen { get; set; }
        [Display(Name = "Mitgliedschaften")]
        public string Mitgliedschaften { get; set; }
        [Display(Name = "Sonstiges")]
        public string Sonstiges { get; set; }
        [Display(Name = "Telefon privat")]
        public string TelPriv { get; set; }
        [Display(Name = "Telefon dienstlich")]
        public string TelDienst { get; set; }
        [Display(Name = "Telefon Mobil")]
        public string Mobil { get; set; }
        [Display(Name = "E-Mail Adresse")]
        public string EMail { get; set; }
        [Display(Name = "Straße")]
        public string Straße { get; set; }
        [Display(Name = "Hausnummer")]
        public string Nummer { get; set; }
        [Display(Name = "ggf Adresszusatz")]
        public string Adresszusatz { get; set; }
        [Display(Name = "PLZ")]
        public string PLZ { get; set; }
        [Display(Name = "Stadt")]
        public string Stadt { get; set; }
        [Display(Name = "Wiedervorlage")]
        public string Wiedervorlage { get; set; }
             [HiddenInput(DisplayValue = false)]
        public byte[] ImageData { get; set; }
         [HiddenInput(DisplayValue = false)]
        public string ImageMimeType { get; set; }
         [HiddenInput(DisplayValue = false)]
         [Display(Name = "Besitzer")]
         public string Besitzer { get; set; } 
      
    }
}
