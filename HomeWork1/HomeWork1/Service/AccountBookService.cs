using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HomeWork1.Models;
using HomeWork1.Repository;


namespace HomeWork1.Service
{
    public class AccountBookService
    {
        //private readonly AccountBookModel _db;
        private readonly IRepository<AccountBook> _accountBookRepository;

        public AccountBookService(IUnitOfWork unitOfWork)
        {
            //_db = new AccountBookModel();
            _accountBookRepository = new Repository<AccountBook>(unitOfWork);
        }
       

        public IEnumerable<MoneyBookViewModels> LookupMoney()
        {
            var source = _accountBookRepository.LookupAll();
            var result = new List<MoneyBookViewModels>();

            foreach (var item in source)
            {
                var moneyItem = new MoneyBookViewModels
                {
                    Date = item.Dateee,
                    Category = (item.Categoryyy == 1 ? CategoryEnum.收入 : CategoryEnum.支出),
                    Money = item.Amounttt
                };
                result.Add(moneyItem);
            }
            return result.OrderByDescending(d => d.Date);
        }


        public void Add(AccountBook accountBook)
        {
            //_db.AccountBook.Add(accountBook);
            _accountBookRepository.Create(accountBook);
        }

        //public void Save()
        //{
        //    _db.SaveChanges();
        //}
    }
}