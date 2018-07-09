using System;
using System.Linq;
using System.Collections.Generic;
using System.Web.Mvc;
using HomeWork1.Models;

namespace HomeWork1.Controllers
{
    public class MoneyBookController : Controller
    {
        // GET: MoneyBook
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult ListAll()
        {
            var fakeData = new List<MoneyBookViewModels>();
            for (int i = 1; i < 51; i++)
            {
                var item = new MoneyBookViewModels
                {
                    Date = DateTime.Now.AddDays(-i),
                    Category=(i%2==1 ? CategoryEnum.支出 : CategoryEnum.收入),
                    Money=i*100
                };
                fakeData.Add(item);
            }
            return View(fakeData);
        }


    }
}