using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using SportsStore.Models;
using Microsoft.AspNet.Identity;


namespace SportsStore.Controllers
{
    [Authorize]
    public class DatenController : Controller
    {
        private IProductRepository repository;
        public DatenController(IProductRepository repo)
        {
            repository = repo;
        }
        public ViewResult List(string category, string branche, string vorname)
        {
           
            /*repositorym.Products.Where(x => branche ==null || x.Branche == branche)*/
            return View(repository.Products.Where(p => p.Besitzer == User.Identity.GetUserId()));
        }



        public FileContentResult GetImage(int productId)
        {
            Product prod = repository.Products
            .FirstOrDefault(p => p.ProductID == productId);
            if (prod != null)
            {
                return File(prod.ImageData, prod.ImageMimeType);
            }
            else
            {
                return null;
            }
        }


        public ViewResult Edit(int productId)
        {
            Product product = repository.Products
            .FirstOrDefault(p => p.ProductID == productId)
            ;
            return View(product);
        }
        [HttpPost]
        public ActionResult Edit(Product product, HttpPostedFileBase image = null)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    product.ImageMimeType = image.ContentType;
                    product.ImageData = new byte[image.ContentLength];
                    product.Besitzer = User.Identity.GetUserId();
                    image.InputStream.Read(product.ImageData, 0, image.ContentLength);
                 
                }
                product.Besitzer = User.Identity.GetUserId();
                repository.SaveProduct(product);
              //  TempData["message"] = string.Format("{0} wurde gespeichert", product.Vorname);
                return RedirectToAction("List");
            }
            else
            {
                // there is something wrong with the data values
                return View(product);
            }
        }
        public ViewResult Create()
        {
            return View("Edit", new Product());
        }
        public ViewResult Profil(int productId)
        {
            Product product = repository.Products
            .FirstOrDefault(p => p.ProductID == productId);
            return View(product);
            
        }

   
    }
}