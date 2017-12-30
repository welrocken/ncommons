using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Routing;

using NCommons.Asp.Net.Utilities;

namespace NCommons.Asp.Net.Extensions
{
    public static partial class UrlHelperExtensions
    {
        public static string Action<T>(this UrlHelper urlHelper,
                                       MemberExpression actionExpression)
            where T : Controller
        {
            return UrlHelperUtilities.Action<T>(urlHelper,
                                                actionExpression);
        }

        public static string Action<T>(this UrlHelper urlHelper,
                                       MemberExpression actionExpression,
                                       object routeValues)
            where T : Controller
        {
            return UrlHelperUtilities.Action<T>(urlHelper,
                                                actionExpression,
                                                routeValues);
        }

        public static string Action<T>(UrlHelper urlHelper,
                                       MemberExpression actionExpression,
                                       RouteValueDictionary routeValues)
            where T : Controller
        {
            return UrlHelperUtilities.Action<T>(urlHelper,
                                                actionExpression,
                                                routeValues);
        }

        public static string Action<T>(UrlHelper urlHelper,
                                       MemberExpression actionExpression,
                                       object routeValues,
                                       string protocol)
            where T : Controller
        {
            return UrlHelperUtilities.Action<T>(urlHelper,
                                                actionExpression,
                                                routeValues,
                                                protocol);
        }

        public static string Action<T>(UrlHelper urlHelper,
                                       MemberExpression actionExpression,
                                       RouteValueDictionary routeValues,
                                       string protocol)
            where T : Controller
        {
            return UrlHelperUtilities.Action<T>(urlHelper,
                                                actionExpression,
                                                routeValues,
                                                protocol);
        }

        public static string Action<T>(UrlHelper urlHelper,
                                       MemberExpression actionExpression,
                                       RouteValueDictionary routeValues,
                                       string protocol,
                                       string hostName)
            where T : Controller
        {
            return UrlHelperUtilities.Action<T>(urlHelper,
                                                actionExpression,
                                                routeValues,
                                                protocol,
                                                hostName);
        }
    }
}