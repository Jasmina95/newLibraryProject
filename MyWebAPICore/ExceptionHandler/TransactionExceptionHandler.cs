namespace MyWebAPICore.ExceptionHandler
{
    public class TransactionExceptionHandler : Exception
    {
        public string Error { get; private set; }

        public TransactionExceptionHandler(string error) : base(error)
        {
            Error = error;
        }
    }
}
