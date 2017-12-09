using System;

namespace NCommons.Asp.Net
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class PartialViewAttribute : Attribute
    {
        public string FileName { get; }

        public PartialViewAttribute(string fileName = null) : base()
        {
            FileName = fileName;
        }
    }
}