namespace SportsStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products
    {
        [Key]
        public int ProductID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Category { get; set; }

        public decimal? Price { get; set; }

        [StringLength(50)]
        public string Datum { get; set; }

        [StringLength(50)]
        public string Veranstaltung { get; set; }

        [StringLength(50)]
        public string Branche { get; set; }

        [StringLength(50)]
        public string Firma { get; set; }

        [StringLength(50)]
        public string Vorname { get; set; }

        [StringLength(50)]
        public string Nachname { get; set; }

        [StringLength(50)]
        public string USP { get; set; }

        [StringLength(50)]
        public string Zielkunde { get; set; }

        [StringLength(50)]
        public string ich { get; set; }

        [StringLength(50)]
        public string er { get; set; }

        [StringLength(50)]
        public string Empfehlungen { get; set; }

        [StringLength(50)]
        public string Mitgliedschaften { get; set; }

        [StringLength(50)]
        public string Sonstiges { get; set; }

        [StringLength(50)]
        public string TelPriv { get; set; }

        [StringLength(50)]
        public string TelDienst { get; set; }

        [StringLength(50)]
        public string Mobil { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Straße { get; set; }

        [StringLength(50)]
        public string Nummer { get; set; }

        [StringLength(50)]
        public string Adresszusatz { get; set; }

        [StringLength(50)]
        public string PLZ { get; set; }

        [StringLength(50)]
        public string Stadt { get; set; }

        [StringLength(50)]
        public string Wiedervorlage { get; set; }

        public byte[] ImageData { get; set; }

        [StringLength(50)]
        public string ImageMimeType { get; set; }
    }
}
