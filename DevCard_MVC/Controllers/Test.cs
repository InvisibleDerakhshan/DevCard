using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace DevCard_MVC.Controllers
{
    public class Test : Controller
    {
        //public IActionResult Index()
        //{
        //    return PartialView("Footer");
        //}
        //public IActionResult Index()
        //{
        //    return View("Footer");
        //}
        //public ContentResult Index()
        //{
        //    return Content("<h1> Hello  Asp.net Core MVC Student</h1><script>confirm('این سوال من است؟')</script>", "text/html ");
        //}
        //public EmptyResult Index()
        //{
        //    return null;
        //}
        //public FileResult Index()
        //{
        //    //return File("~/test.txt", "text/html");
        //    var filebyte = System.IO.File.ReadAllBytes("wwwroot/test.txt");
        //    const string fileName = "testfile.txt";//nam bad download
        //    return File(filebyte,MediaTypeNames.Text.Plain,fileName);
        //}
        //public JsonResult Index()
        //{
        //    return Json(new { 
        //        id = 1, 
        //        name = "Mohammad", 
        //        job = "WebDeveloper", 
        //        site = "invisible.com" 
        //    });
        //}
        //public JavascriptResult Index()
        //{
        //    return new JavascriptResult("alert('سلام به سایت من خوش آمدید !!!!')");
        //}
        //public RedirectResult Index()
        //{
        //    return Redirect("https://translate.google.com/");
        //}
        //public RedirectToActionResult Index()
        //{
        //    return RedirectToAction("Contact", "Home");
        //}

        public IActionResult Index()
        {
            //return new OkResult();
            //return new NotFoundResult();
            //return new BadRequestResult();
            //return new  NoContentResult();
            return new StatusCodeResult(401);

        }


    }

    //public class JavascriptResult : ContentResult
    //{
    //    public JavascriptResult(string data)
    //    {
    //        Content = data;
    //        ContentType = "applicatin/javascript";

    //    }
    //}
}
