using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Routing;

namespace NCommons.Asp.Net.Utilities
{
    public static partial class UrlHelperLinqUtilities
    {
        public static string Action<T>(UrlHelper urlHelper,
                                       Expression<Func<T, string>> actionNameExpression)
            where T : Controller
        {
            var actionNameFunction = actionNameExpression.Compile();
            var actionName = actionNameFunction(default(T));

            return UrlHelperUtilities.Action<T>(urlHelper,
                                                actionName);
        }

        public static string Action<T>(UrlHelper urlHelper,
                                       Expression<Func<T, string>> actionNameExpression,
                                       object routeValues)
            where T : Controller
        {
            var actionNameFunction = actionNameExpression.Compile();
            var actionName = actionNameFunction(default(T));

            return UrlHelperUtilities.Action<T>(urlHelper,
                                                actionName,
                                                routeValues);
        }

        public static string Action<T>(UrlHelper urlHelper,
                                       Expression<Func<T, string>> actionNameExpression,
                                       RouteValueDictionary routeValues)
            where T : Controller
        {
            var actionNameFunction = actionNameExpression.Compile();
            var actionName = actionNameFunction(default(T));

            return UrlHelperUtilities.Action<T>(urlHelper,
                                                actionName,
                                                routeValues);
        }

        public static string Action<T>(UrlHelper urlHelper,
                                       Expression<Func<T, string>> actionNameExpression,
                                       object routeValues,
                                       string protocol)
            where T : Controller
        {
            var actionNameFunction = actionNameExpression.Compile();
            var actionName = actionNameFunction(default(T));

            return UrlHelperUtilities.Action<T>(urlHelper,
                                                actionName,
                                                routeValues,
                                                protocol);
        }

        public static string Action<T>(UrlHelper urlHelper,
                                       Expression<Func<T, string>> actionNameExpression,
                                       RouteValueDictionary routeValues,
                                       string protocol)
            where T : Controller
        {
            var actionNameFunction = actionNameExpression.Compile();
            var actionName = actionNameFunction(default(T));

            return UrlHelperUtilities.Action<T>(urlHelper,
                                                actionName,
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
            var actionNameFunction = actionNameExpression.Compile();
            var actionName = actionNameFunction(default(T));

            return UrlHelperUtilities.Action<T>(urlHelper,
                                                actionName,
                                                routeValues,
                                                protocol,
                                                hostName);
        }
    }
}