using System;

using FluentValidation;

namespace NCommons.Validation.FluentValidation
{
    public static class IRuleBuilderExtensions
    {
        public static IRuleBuilder<T, TProperty> WithError<T, TProperty, TError>(this IRuleBuilderOptions<T, TProperty> ruleBuilderOptions, TError error)
            where TError : struct, IComparable, IFormattable, IConvertible
        {
            if (!typeof(TError).IsEnum)
                throw new ArgumentException("T must be an enumerated type");

            var errorCode = ((int)(object)error).ToString();
            var errorMessage = error.ToString();

            return ruleBuilderOptions
                .WithErrorCode(errorCode.ToString())
                .WithMessage(errorMessage);

        }
    }
}