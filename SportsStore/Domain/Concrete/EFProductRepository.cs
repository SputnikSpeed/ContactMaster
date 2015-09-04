using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Concrete
{
    public class EFProductRepository : IProductRepository {
        private Datenverbindung2 context = new Datenverbindung2();
        public IEnumerable<Product> Products {
            get {return context.Products;}
        }
        public void SaveProduct(Product product) {
            if (product.ProductID == 0)
            {
                context.Products.Add(product);
            }
            else
            {
                Product dbEntry =
                context.Products.Find(product.ProductID);
                if (dbEntry != null)
                {
                    dbEntry.Vorname = product.Vorname;
                    dbEntry.Datum = product.Datum;
                    dbEntry.Veranstaltung = product.Veranstaltung;
                    dbEntry.BrancheID = product.BrancheID;
                    dbEntry.Firma = product.Firma;
                    dbEntry.Nachname = product.Nachname;
                    dbEntry.USP = product.USP;
                    dbEntry.Zielkunde = product.Zielkunde;
                    dbEntry.ich = product.ich;
                    dbEntry.er = product.er;
                    dbEntry.Empfehlungen = product.Empfehlungen;
                    dbEntry.Mitgliedschaften = product.Mitgliedschaften;
                    dbEntry.Sonstiges = product.Sonstiges;
                    dbEntry.TelPriv = product.TelPriv;
                    dbEntry.TelDienst = product.TelDienst;
                    dbEntry.Mobil = product.Mobil;
                    dbEntry.EMail = product.EMail;
                    dbEntry.Straße = product.Straße;
                    dbEntry.Nummer = product.Nummer;
                    dbEntry.Adresszusatz = product.Adresszusatz;
                    dbEntry.PLZ = product.PLZ;
                    dbEntry.Stadt = product.Stadt;
                    dbEntry.Wiedervorlage = product.Wiedervorlage;
                    dbEntry.ImageData = product.ImageData;
                    dbEntry.ImageMimeType = product.ImageMimeType;
                   
                  
                }
            }
            context.SaveChanges();
        }

    }
    
}