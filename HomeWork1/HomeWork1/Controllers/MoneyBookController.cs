using System;
using System.Linq;
using System.Collections.Generic;
using System.Web.Mvc;
using HomeWork1.Models;
using HomeWork1.Service;
using HomeWork1.Helper;

namespace HomeWork1.Controllers
{
    public class MoneyBookController : Controller
    {
        private readonly AccountBookService _accountBookService;

        public MoneyBookController()
        {
            _accountBookService = new AccountBookService();
        }
        // GET: MoneyBook
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult ListAll()
        {
            return View(_accountBookService.LookupMoney());
        }

        [HttpPost]
        public ActionResult Create(MoneyBookViewModels moneyBook)
        {
            if (ModelState.IsValid)
            {
                //驗證日期不能=今
                if (moneyBook.Date.CompareTo(DateTime.Now) >0)
                {
                    ModelState.AddModelError("Date", "日期不得大於今天");
                    return View("Index");
                }

                _accountBookService.Add(ModelHelper.ConvertToAccountBookModel(moneyBook));
                _accountBookService.Save();
                return RedirectToAction("Index");
            }

            return View("Index");
        }




    }
}