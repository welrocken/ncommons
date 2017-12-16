namespace NCommons.Validation
{
    public interface IValidator<T, TError>
    {
        IValidationResult<TError> Validate(T obj);
    }

    public interface IValidator<T> : IValidator<T, object>
    {
    }
}