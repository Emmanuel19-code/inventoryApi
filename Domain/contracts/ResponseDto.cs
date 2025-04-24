namespace inventoryApi.Domain.Contracts
{
    public class Response<T>
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public T? Data { get; set; }
        public static Response<T> OK(T? data = default, string? message = null) => new Response<T> { Success = true, Data = data, Message = message };
        public static Response<T> Fail(string message, T? data = default) => new Response<T> { Success = false, Message = message, Data = data };
    }
}