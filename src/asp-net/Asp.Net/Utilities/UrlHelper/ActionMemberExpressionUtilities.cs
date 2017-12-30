using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Routing;

namespace NCommons.Asp.Net.Utilities
{
    public static partial class UrlHelperUtilities
    {
        public static string Action<T>(UrlHelper urlHelper,
                                       MemberExpression actionExpression)
            where T : Controller
        {
            var actionName = actionExpression.Member.Name;

            return UrlHelperUtilities.Action<T>(urlHelper,
                                                actionName);
        }

        public static string Action<T>(UrlHelper urlHelper,
                                       MemberExpression actionExpression,
                                       object routeValues)
            where T : Controller
        {
            var actionName = actionExpression.Member.Name;

            return UrlHelperUtilities.Action<T>(urlHelper,
                                                actionName,
                                                routeValues);
        }

        public static string Action<T>(UrlHelper urlHelper,
                                       MemberExpression actionExpression,
                                       RouteValueDictionary routeValues)
            where T : Controller
        {
            var actionName = actionExpression.Member.Name;

            return UrlHelperUtilities.Action<T>(urlHelper,
                                                actionName,
                                                routeValues);
        }

        public static string Action<T>(UrlHelper urlHelper,
                                       MemberExpression actionExpression,
                                       object routeValues,
                                       string protocol)
            where T : Controller
        {
            var actionName = actionExpression.Member.Name;

            return UrlHelperUtilities.Action<T>(urlHelper,
                                                actionName,
                                                routeValues,
                                                protocol);
        }

        public static string Action<T>(UrlHelper urlHelper,
                                       MemberExpression actionExpression,
                                       RouteValueDictionary routeValues,
                                       string protocol)
            where T : Controller
        {
            var actionName = actionExpression.Member.Name;

            return UrlHelperUtilities.Action<T>(urlHelper,
                                                actionName,
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
            var actionName = actionExpression.Member.Name;

            return UrlHelperUtilities.Action<T>(urlHelper,
                                                actionName,
                                                routeValues,
                                                protocol,
                                                hostName);
        }
    }
}