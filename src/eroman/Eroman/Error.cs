namespace NCommons.Eroman
{
    public class Error : IError
    {
        public virtual int Code { get; }
        public virtual string Message { get; }

        public Error(int code, string message)
        {
            Code = code;
            Message = message;
        }
    }
}