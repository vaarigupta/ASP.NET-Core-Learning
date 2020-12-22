using FluentValidation;
using Nagarro.BookReadingEvent.Shared;

namespace Nagarro.BookReadingEvent.Validations
{
    public class EventValidator : AbstractValidator<IEventDTO>
    {
        public EventValidator()
        {
            ////SampleProperty2 value should be not be null or empty
            //RuleFor(dto => dto.SampleProperty2).NotNull().NotEmpty();

            ////SampleProperty1 value should be greater than 10
            //RuleFor(dto => dto.SampleProperty1).GreaterThan(10);
        }
    }

}
