namespace NCommons.Validation
{
    public interface IValidationResult<TError>
    {
        TError Error { get; }
        bool Valid { get; }
    }

    public interface IValidationResult : IValidationResult<object>
    {
    }
}