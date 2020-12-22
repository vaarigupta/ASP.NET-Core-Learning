using FluentValidation.Results;
using Nagarro.BookReadingEvent.Shared;
using System.Collections.Generic;

namespace Nagarro.BookReadingEvent.Validations
{
    public static class ValidationExtensions
    {
        public static BookReadingValidationResult ToValidationResult(this ValidationResult result)
        {
            IList<BookReadingValidationFailure> errors = new List<BookReadingValidationFailure>();

            foreach (ValidationFailure failure in result.Errors)
            {
                errors.Add(failure.ToValidationFailure());
            }

            return new BookReadingValidationResult(errors);
        }

        public static BookReadingValidationFailure ToValidationFailure(this ValidationFailure failure)
        {
            return new BookReadingValidationFailure(failure.PropertyName, failure.ErrorMessage, failure.AttemptedValue);
        }
        
    }
}
