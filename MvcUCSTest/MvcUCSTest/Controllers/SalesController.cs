using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcUCSTest.Models;
using MvcUCSTest.Models.Repositories;
namespace MvcUCSTest.Controllers
{
    public class SalesController : Controller
    {
       
       

        private ISalesRepository repository;
        
        public SalesController(ISalesRepository repo)
        {
            this.repository = repo;
        }


        public ActionResult Index()
        {
            return View(repository.SalesData);
            
        }

    }
}
