using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace ASP.NET_MVC
{
    
    public class CustomHelper
    {
        public static class CustomImageHelper
        {

            
            //Method 1: static class and static methods
            public static IHtmlString Image(string src, string alt,string width, string height)
            {
                return new MvcHtmlString(string.Format("<img src='{0}' alt='{1}' width='{2}' height='{3}'></img>", src, alt,width,height));
            }

            /*
            //Method 2: using extension method - only difference is we pass reference to connect
            //Not working
            public static IHtmlString Img(this HtmlHelper helper, string src, string alt, string width, string height)
            {
                return new MvcHtmlString(string.Format("<img src='{0}' alt='{1}' width='{2}' height='{3}'></img>", src, alt, width, height));
            }
            */

        }
    }
}