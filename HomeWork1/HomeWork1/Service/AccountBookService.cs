using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HomeWork1.Models;


namespace HomeWork1.Service
{
    public class AccountBookService
    {
        private readonly AccountBookModel _db;

        public AccountBookService()
        {
            _db = new AccountBookModel();
        }

        public IEnumerable<AccountBook> Lookup()
        {
            var dbList = _db.AccountBook.ToList();
            return dbList;
        }

        public IEnumerable<MoneyBookViewModels> LookupMoney()
        {
            var dbList = _db.AccountBook.OrderByDescending(d=>d.Dateee);
            var result = new List<MoneyBookViewModels>();

            foreach (var item in dbList)
            {
                var moneyItem = new MoneyBookViewModels
                {
                    Date = item.Dateee,
                    Category = (item.Categoryyy == 1 ? CategoryEnum.收入 : CategoryEnum.支出),
                    Money = item.Amounttt
                };
                result.Add(moneyItem);
            }
            return result;
        }


        public void Add(AccountBook accountBook)
        {
            _db.AccountBook.Add(accountBook);

        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}