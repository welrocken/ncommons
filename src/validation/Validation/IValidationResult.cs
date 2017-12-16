namespace NCommons.Validation
{
    public interface IValidationResult<TError>
    {
        TError Error { get; }
        bool Success { get; }
    }

    public interface IValidationResult : IValidationResult<object>
    {
    }
}