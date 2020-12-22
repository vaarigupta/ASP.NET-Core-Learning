using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.BookReadingEvent.Shared
{
    public class BookReadingValidationResult
    {
        public IList<BookReadingValidationFailure> Errors { get; private set; }

        public bool IsValid
        {
            get { return Errors == null || Errors.Count == 0; }
        }

        public BookReadingValidationResult(IList<BookReadingValidationFailure> failures)
        {
            Errors = failures;
        }

        public BookReadingValidationResult()
        {
            Errors = new List<BookReadingValidationFailure>();
        }
    }
}
