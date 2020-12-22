using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.BookReadingEvent.Shared
{
    public class BookReadingValidationFailure
    {
        public object AttemptedValue { get; private set; }
        public object CustomState { get; set; }
        public string ErrorMessage { get; private set; }
        public string PropertyName { get; set; }

        public BookReadingValidationFailure(string propertyName, string error)
        {
            PropertyName = propertyName;
            ErrorMessage = error;
        }

        public BookReadingValidationFailure(string propertyName, string error, object attemptedValue)
        {
            PropertyName = propertyName;
            ErrorMessage = error;
            AttemptedValue = attemptedValue;
        }
    }
}
