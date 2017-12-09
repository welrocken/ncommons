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

        public static MvcHtmlString Partial<T>(this HtmlHelper htmlHelper,
                                               T model)
        {
            return PartialUtilities.Partial(htmlHelper, 
                                            model);
        }

        public static MvcHtmlString Partial<T>(this HtmlHelper htmlHelper,
                                               ViewDataDictionary viewData)
        {
            return PartialUtilities.Partial<T>(htmlHelper,
                                               viewData);
        }

        public static MvcHtmlString Partial<T>(this HtmlHelper htmlHelper,
                                               T model,
                                               ViewDataDictionary viewData)
        {
            return PartialUtilities.Partial(htmlHelper,
                                            model,
                                            viewData);
        }
    }
}