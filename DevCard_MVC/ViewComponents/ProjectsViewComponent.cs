using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string name)
        {
            var projects = new List<Project>
            {

                new Project( 1,"تاکسی","درخواست آنلاین تاکسی برای سفر های درون شهری","project-1.jpg","Invisible"),
                new Project( 2,"فروشگاه گیم","خرید انواع بازی ها و آیتم های داخل بازی","project-2.jpg","Gameshop"),
                new Project( 3,"شرکت","سیستم مدیریت و حسابداری شرکت ها","project-3.jpg","CompanySoftware"),
                new Project( 4,"فضاپیما","برنامه مدیریت فضا پیما های ناسا","project-4.jpg","Nasa"),
            };
            return View("_Projects", projects);
        }
    }
}
