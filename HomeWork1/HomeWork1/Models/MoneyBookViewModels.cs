using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HomeWork1.Models
{
    public class MoneyBookViewModels
    {
        [DisplayName("#")]
        public int No { get; set; }
        [DisplayName("類別")]
        public FeeTypes FeeType { get; set; }
        
        [DisplayName("金額")]
        [DisplayFormat(DataFormatString ="{0:N0}")]
        public int Fee { get; set; }
        [DisplayName("日期")]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}")]
        public DateTime BookDate { get; set; }

        [DisplayName("備註")]
        public string Remarks { get; set; }

    }

    public enum FeeTypes
    {
        收入 = 1,
        支出 = 2
    }
   
}