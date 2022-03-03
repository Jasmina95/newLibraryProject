namespace MyWebAPICore.Models
{
    public class ServiceResponse<T>
    {
        public T Data { get; set; }
        public string Error { get; set; }

    }
}
