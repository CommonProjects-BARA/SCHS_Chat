namespace Common.API
{
    public class ResponseApi<T>
    {
        private ResponseApi(T response, bool result)
        {
            Response = response;
            Successed = result;
        }
        public T Response { get; set; }
        public bool Successed { get; set; }
        public static ResponseApi<string> Fail(string message)
            => new ResponseApi<string>(message, false);
        public static ResponseApi<T> Success(T response)
            => new ResponseApi<T>(response, true);
    }
}