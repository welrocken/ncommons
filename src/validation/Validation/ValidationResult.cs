namespace NCommons.Validation
{
    public class ValidationResult<TError> : IValidationResult<TError>
    {
        public TError Error { get; }
        public bool Valid { get; }

        public ValidationResult()
        {
            Valid = true;
        }

        public ValidationResult(TError error)
        {
            Error = error;
        }
    }

    public class ValidationResult : ValidationResult<object>, IValidationResult
    {
        public ValidationResult() : base()
        {
        }

        public ValidationResult(object error) : base(error)
        {
        }
    }
}