using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Odevler.Controllers
{
    public class UygulamaController : Controller
    {
        public IActionResult Index()
        {
            List<string> dizi = new() { "Ankara","Izmir", "Ïstanbul","Bursa" };
            return View();
        }

        //gorev/yahoo
        [Route("gorev/{id}")]
        //uygulama/ara/yahoo
        public IActionResult Ara(string id)
        {
            string site = "https://";
            switch (id)
            {
                case "yandex": site += "www.yandex.com"; break;
                case "google": site += "www.google.com"; break;
                case "yahoo": site += "www.yahoo.com"; break;
                default:
                    site += "www.google.com";
                    break;
            }
            return Redirect(site);
        }

       
        



    }
}
