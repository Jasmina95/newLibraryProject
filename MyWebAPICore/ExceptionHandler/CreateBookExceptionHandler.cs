
namespace MyWebAPICore.ExceptionHandler
{
    public class CreateBookExceptionHandler : Exception
    {
        public Dictionary<ValidationErrorCode, string> Errors { get; private set; }
        public CreateBookExceptionHandler(Dictionary<ValidationErrorCode, string> errors) : base()
        {
            Errors = errors;
        }
    }

    public enum ValidationErrorCode
    {
        CreateBookTitle = 1,
        ReferenceAuthorsAndPublisher = 2,
        BookNotFound = 3
    }
    
}
