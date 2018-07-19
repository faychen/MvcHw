using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeWork1.Models;

namespace HomeWork1.Helper
{
    public static class CategoryHelper
    {
        public static HtmlString DisplayCatrgoryColor(this HtmlHelper htmlHelper, CategoryEnum catrgory)
        {
            var className = "";
            if (catrgory.Equals(CategoryEnum.收入))
            {
                className = "primary";
            }
            else
            {
                className = "danger";
            }

            return new MvcHtmlString($"<span class='text-{className}'>{catrgory}</span>");
        }
    }
}