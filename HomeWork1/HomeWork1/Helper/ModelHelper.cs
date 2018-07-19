using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HomeWork1.Models;

namespace HomeWork1.Helper
{
    public static class ModelHelper
    {

        public static AccountBook ConvertToAccountBookModel(MoneyBookViewModels moneyBookViewModels)
        {

            var accountBook = new AccountBook
            {
                Id = Guid.NewGuid(),
                Dateee = moneyBookViewModels.Date,
                Categoryyy = moneyBookViewModels.Category.Equals(CategoryEnum.收入) ? 1 : 0,
                Amounttt = moneyBookViewModels.Money,
                Remarkkk = moneyBookViewModels.Description
            };

            return accountBook;
        }
    }
}