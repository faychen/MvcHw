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
                    No = i,
                    BookDate = DateTime.Now.AddDays(-i),
                    FeeType=(i%2==1 ? FeeTypes.支出 : FeeTypes.收入),
                    Fee=i*100
                };
                fakeData.Add(item);
            }
            return View(fakeData);
        }


    }
}