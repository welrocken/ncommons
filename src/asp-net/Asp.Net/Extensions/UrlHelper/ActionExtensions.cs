using System.Web.Mvc;
using System.Web.Routing;

using NCommons.Asp.Net.Utilities;

namespace NCommons.Asp.Net.Extensions
{
    public static partial class UrlHelperExtensions
    {
        public static string Action<T>(this UrlHelper urlHelper,
                                       string actionName)
            where T : Controller
        {
            return UrlHelperUtilities.Action<T>(urlHelper,
                                                actionName);
        }

        public static string Action<T>(this UrlHelper urlHelper,
                                       string actionName,
                                       object routeValues)
            where T : Controller
        {
            return UrlHelperUtilities.Action<T>(urlHelper,
                                                actionName,
                                                routeValues);
        }

        public static string Action<T>(this UrlHelper urlHelper,
                                       string actionName,
                                       RouteValueDictionary routeValues)
            where T : Controller
        {
            return UrlHelperUtilities.Action<T>(urlHelper,
                                                actionName,
                                                routeValues);
        }

        public static string Action<T>(this UrlHelper urlHelper,
                                       string actionName,
                                       object routeValues,
                                       string protocol)
            where T : Controller
        {
            return UrlHelperUtilities.Action<T>(urlHelper,
                                                actionName,
                                                routeValues,
                                                protocol);
        }

        public static string Action<T>(this UrlHelper urlHelper,
                                       string actionName,
                                       RouteValueDictionary routeValues,
                                       string protocol)
            where T : Controller
        {
            return UrlHelperUtilities.Action<T>(urlHelper,
                                                actionName,
                                                routeValues,
                                                protocol);
        }

        public static string Action<T>(this UrlHelper urlHelper,
                                       string actionName,
                                       RouteValueDictionary routeValues,
                                       string protocol,
                                       string hostName)
            where T : Controller
        {
            return UrlHelperUtilities.Action<T>(urlHelper,
                                                actionName,
                                                routeValues,
                                                protocol,
                                                hostName);
        }
    }
}