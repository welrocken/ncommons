using System;

namespace NCommons.Eroman
{
    public class Error : Exception, IError
    {
        public virtual int Code { get; }

        public Error(int code, string message) 
            : base(message)
        {
            Code = code;
        }
    }
}