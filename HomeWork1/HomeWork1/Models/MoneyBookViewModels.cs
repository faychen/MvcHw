using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HomeWork1.Models
{
    public class MoneyBookViewModels
    {
        [DisplayName("類別")]
        public CategoryEnum Category { get; set; }
        
        [DisplayName("金額")]
        [DisplayFormat(DataFormatString ="{0:N0}")]
        public int Money { get; set; }
        [DisplayName("日期")]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}")]
        public DateTime Date { get; set; }

        [DisplayName("備註")]
        public string Description { get; set; }

    }

    public enum CategoryEnum
    {
        收入 = 1,
        支出 = 2
    }
   
}