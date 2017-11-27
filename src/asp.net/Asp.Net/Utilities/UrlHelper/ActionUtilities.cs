using System.Web.Mvc;
using System.Web.Routing;

using NCommons.Asp.Net.Utilities.String;

namespace NCommons.Asp.Net.Utilities
{
    public static partial class UrlHelperUtilities
    {
        public static string Action<T>(UrlHelper urlHelper,
                                       string actionName)
            where T : Controller
        {
            var controllerName = ControllerNameUtility.GetControllerPath(typeof(T).Name);

            return urlHelper.Action(actionName, 
                                    controllerName);
        }

        public static string Action<T>(UrlHelper urlHelper, 
                                       string actionName, 
                                       object routeValues)
            where T : Controller
        {
            var controllerName = ControllerNameUtility.GetControllerPath(typeof(T).Name);

            return urlHelper.Action(actionName,
                                    controllerName,
                                    routeValues);
        }

        public static string Action<T>(UrlHelper urlHelper, 
                                       string actionName, 
                                       RouteValueDictionary routeValues)
            where T : Controller
        {
            var controllerName = ControllerNameUtility.GetControllerPath(typeof(T).Name);

            return urlHelper.Action(actionName,
                                    controllerName,
                                    routeValues);
        }

        public static string Action<T>(UrlHelper urlHelper, 
                                       string actionName, 
                                       object routeValues, 
                                       string protocol)
            where T : Controller
        {
            var controllerName = ControllerNameUtility.GetControllerPath(typeof(T).Name);

            return urlHelper.Action(actionName,
                                    controllerName,
                                    routeValues, 
                                    protocol);
        }

        public static string Action<T>(UrlHelper urlHelper, 
                                       string actionName, 
                                       RouteValueDictionary routeValues, 
                                       string protocol)
            where T : Controller
        {
            var controllerName = ControllerNameUtility.GetControllerPath(typeof(T).Name);

            return urlHelper.Action(actionName, 
                                    controllerName,
                                    routeValues, 
                                    protocol);
        }

        public static string Action<T>(UrlHelper urlHelper,
                                       string actionName, 
                                       RouteValueDictionary routeValues, 
                                       string protocol, 
                                       string hostName)
            where T : Controller
        {
            var controllerName = ControllerNameUtility.GetControllerPath(typeof(T).Name);

            return urlHelper.Action(actionName,
                                    controllerName,
                                    routeValues, 
                                    protocol, 
                                    hostName);
        }
    }
}