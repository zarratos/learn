using System;
using System.Web.Mvc;

namespace Shop.Extensions
{
    public static class HtmlExtensions
    {
        public static MvcHtmlString Image(this HtmlHelper html, byte[] image)
        {
            var img = string.Format("data:image/jpg;base64,{0}", Convert.ToBase64String(image));
            return new MvcHtmlString("<img id='RoundedCorner' src='" + img + "'/>");
        }
    }
}