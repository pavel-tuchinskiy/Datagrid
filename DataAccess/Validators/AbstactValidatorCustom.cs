using FluentValidation;
using FluentValidation.Results;

namespace DataAccess.Validators
{
    public abstract class AbstractValidatorCustom<T> : AbstractValidator<T>
    {
        public override ValidationResult Validate(ValidationContext<T> context)
        {
            var validationResult = base.Validate(context);

            if (!validationResult.IsValid)
            {
                try
                {
                    RaiseValidationException(context, validationResult);
                }
                catch (Exception ex){}
            }

            return validationResult;
        }
    }
}
