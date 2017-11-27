using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Routing;

using NCommons.Asp.Net.Utilities;

namespace NCommons.Asp.Net.Extensions
{
    public static partial class UrlHelperExtensions
    {
        public static string Action<T>(this UrlHelper urlHelper,
                                       Expression<Func<T, string>> actionNameExpression)
            where T : Controller
        {
            return UrlHelperLinqUtilities.Action<T>(urlHelper,
                                                    actionNameExpression);
        }

        public static string Action<T>(this UrlHelper urlHelper,
                                       Expression<Func<T, string>> actionNameExpression,
                                       object routeValues)
            where T : Controller
        {
            return UrlHelperLinqUtilities.Action<T>(urlHelper,
                                                    actionNameExpression,
                                                    routeValues);
        }

        public static string Action<T>(UrlHelper urlHelper,
                                       Expression<Func<T, string>> actionNameExpression,
                                       RouteValueDictionary routeValues)
            where T : Controller
        {
            return UrlHelperLinqUtilities.Action<T>(urlHelper,
                                                    actionNameExpression,
                                                    routeValues);
        }

        public static string Action<T>(UrlHelper urlHelper,
                                       Expression<Func<T, string>> actionNameExpression,
                                       object routeValues,
                                       string protocol)
            where T : Controller
        {
            return UrlHelperLinqUtilities.Action<T>(urlHelper,
                                                    actionNameExpression,
                                                    routeValues,
                                                    protocol);
        }

        public static string Action<T>(UrlHelper urlHelper,
                                       Expression<Func<T, string>> actionNameExpression,
                                       RouteValueDictionary routeValues,
                                       string protocol)
            where T : Controller
        {
            return UrlHelperLinqUtilities.Action<T>(urlHelper,
                                                    actionNameExpression,
                                                    routeValues,
                                                    protocol);
        }

        public static string Action<T>(UrlHelper urlHelper,
                                       Expression<Func<T, string>> actionNameExpression,
                                       RouteValueDictionary routeValues,
                                       string protocol,
                                       string hostName)
            where T : Controller
        {
            return UrlHelperLinqUtilities.Action<T>(urlHelper,
                                                    actionNameExpression,
                                                    routeValues,
                                                    protocol,
                                                    hostName);
        }
    }
}