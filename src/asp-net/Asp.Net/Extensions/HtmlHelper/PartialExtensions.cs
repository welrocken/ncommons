using System.Web.Mvc;

using NCommons.Asp.Net.Utilities;

namespace NCommons.Asp.Net.Extensions
{
    public static class PartialExtensions
    {
        public static MvcHtmlString Partial<T>(this HtmlHelper htmlHelper)
        {
            return PartialUtilities.Partial<T>(htmlHelper);
        }
    }
}