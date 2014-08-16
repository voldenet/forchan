using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace forchan.Helpers
{
    static class HtmlHelper
    {
        static Regex stripBrTags = new Regex("<br[^>]*>");
        static Regex stripHtmlTags = new Regex("<[^>]*>");
        static Regex stripHtmlSpaces = new Regex(@" +"); 

        public static string HtmlToPlain(string html)
        {
            if (html == null)
                return html;
            html = stripBrTags.Replace(html, "\n");
            html = stripHtmlTags.Replace(html, "");
            html = stripHtmlSpaces.Replace(html, " ");
            return System.Net.WebUtility.HtmlDecode(html);
        }
    }
}
