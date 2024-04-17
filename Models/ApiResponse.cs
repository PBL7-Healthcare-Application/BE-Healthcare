namespace API_Login.Models
{
    public class ApiResponse
    {
        //public bool Success { get; set; }
        public string StatusCode { get; set; }

        public string Message { get; set; }
        public object Data { get; set; } = null;
    }
}
