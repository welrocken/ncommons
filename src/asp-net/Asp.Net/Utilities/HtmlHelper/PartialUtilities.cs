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
            var type = typeof(T);

            string fileNameToSearch = null;

            var attributes = type.GetCustomAttributes(typeof(PartialViewAttribute), false));
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

            return htmlHelper.Partial(fileName);
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