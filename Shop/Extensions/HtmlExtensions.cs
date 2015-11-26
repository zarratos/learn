using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AutoMapper.Internal;

namespace Shop.Extensions
{
    public static class HtmlExtensions
    {
        public static MvcHtmlString Image(this HtmlHelper html, byte[] image)
        {
            var img = string.Format("data:image/jpg;base64,{0}", Convert.ToBase64String(image));
            return new MvcHtmlString("<img id='RoundedCorner' src='" + img + "'/>");
        }

        public static MvcHtmlString DropDownListCustom(this HtmlHelper html, int? id, IEnumerable<SelectListItem> values)
        {
            var result = string.Empty;
            string selectedValue = string.Empty;
            bool hasSelectedValue = false;
            foreach (var value in values)
            {
                var selected = string.Empty;
                if (Convert.ToInt32(value.Value) == id)
                {
                    selected = "selected='selected'";
                    hasSelectedValue = true;
                }
                result = string.Format("{0}<option {2}>{1}</option>", result, value.Text, selected);
            }
            if (!hasSelectedValue)
                selectedValue = "<option selected='selected'>--Значение не выбрано--</option>";
            result += selectedValue;
            return new MvcHtmlString(string.Format("<select class='form-control'>{0}</select>", result));
        }
    }
}