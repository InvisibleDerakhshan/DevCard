using DevCard_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {


        private readonly List<Service> Services = new List<Service> 
        {
            new Service (1 , "نقره ای"),
            new Service (2 ,"طلایی"),
            new Service (3 ,"پلاتین"),
            new Service(4 ,"الماس"),
            
        };

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact
            {
                Services = new SelectList(Services,"Id","Name")
            };
            return View(model);
        }

        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    var name = form["name"];
        //    return Json(Ok());
        //}
        //[HttpPost]
        //public JsonResult Contact(Contact form)//زمانی استفاده میکنیم که دقیقا میدونیم چه فیلد هایی میخوایم
        //{
        //    Console.WriteLine(form.ToString());
        //    return Json(Ok());
        //}// miad baar asas name form ma field hamon ro map mikone be formemon ke mign binding

        [HttpPost]
        
        public IActionResult Contact(Contact model)
        {
            model.Services= new SelectList(Services,"Id","Name");
            //if (ModelState.IsValid == false) ;
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات وارد شده صحیح نیست ، لطفا دوباره تلاش کنید";
                return View(model);
            }
            ModelState.Clear();
            model = new Contact
            {
                Services = new SelectList(Services, "Id", "Name")//ba in kar oon proprety ha pak mishan va clear ham ke hast badesh barmigarde safhe aval
            };
            ViewBag.success = "پیغام شما با موفقیت ارسال شد ، با تشکر";
            return View(model);
            //return RedirectToAction("Index");
            
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
