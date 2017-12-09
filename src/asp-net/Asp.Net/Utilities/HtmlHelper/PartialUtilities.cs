using System;
using System.IO;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace NCommons.Asp.Net.Utilities
{
    public static class PartialUtilities
    {
        public static MvcHtmlString Partial<T>(HtmlHelper htmlHelper)
        {
            var fileName = GetFileName<T>();

            return htmlHelper.Partial(fileName);
        }

        public static MvcHtmlString Partial<T>(HtmlHelper htmlHelper,
                                               T model)
        {
            var fileName = GetFileName<T>();

            return htmlHelper.Partial(fileName, model);
        }

        public static MvcHtmlString Partial<T>(HtmlHelper htmlHelper,
                                               ViewDataDictionary viewData)
        {
            var fileName = GetFileName<T>();

            return htmlHelper.Partial(fileName, viewData);
        }

        public static MvcHtmlString Partial<T>(HtmlHelper htmlHelper,
                                               T model,
                                               ViewDataDictionary viewData)
        {
            var fileName = GetFileName<T>();

            return htmlHelper.Partial(fileName, model, viewData);
        }

        private static string GetFileName<T>()
        {
            var type = typeof(T);

            string fileNameToSearch = null;

            var attributes = type.GetCustomAttributes(typeof(PartialViewAttribute), false);
            if (attributes.Length <= 0)
                fileNameToSearch = type.Name;
            else
            {
                if (attributes[0] is PartialViewAttribute partialViewAttribute)
                    fileNameToSearch = partialViewAttribute.FileName;
            }

            if (fileNameToSearch == null)
                throw new InvalidOperationException("Invalid operation"); // TODO: Appropriate message

            var fileName = SearchFile(fileNameToSearch);
            if (fileName == null)
                throw new InvalidOperationException("Invalid operation"); // TODO: Appropriate message

            return fileName;
        }

        private static string SearchFile(string fileName)
        {
            var sharedViews = HostingEnvironment.MapPath("~/Views/Shared");
            foreach (var file in Directory.EnumerateFiles(sharedViews))
                if (Path.GetFileNameWithoutExtension(file) == fileName)
                    return fileName;

            return null;
        }
    }
}