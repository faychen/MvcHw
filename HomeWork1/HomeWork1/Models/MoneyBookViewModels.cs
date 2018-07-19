using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HomeWork1.Models
{
    public class MoneyBookViewModels
    {
        [Range(1,int.MaxValue,ErrorMessage ="類別未選擇")]
        [DisplayName("類別")]
        public CategoryEnum Category { get; set; }

        [Required]
        [Range(1,int.MaxValue, ErrorMessage = "金額只能輸入正整數")]
        [DisplayName("金額")]
        [DisplayFormat(DataFormatString ="{0:N0}")]
        public int Money { get; set; }

        [Required]
        [DisplayName("日期")]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}")]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "備註最多輸入100個字元")]
        [DisplayName("備註")]
        public string Description { get; set; }

    }

    public enum CategoryEnum
    {
        收入 = 1,
        支出 = 2
    }
   
}