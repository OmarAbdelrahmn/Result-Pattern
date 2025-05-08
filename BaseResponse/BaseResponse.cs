using System.Net;

namespace BaseResponse;

public class BaseResponse<T>
{
    #region  Constructor
    public BaseResponse()
    {

    }
    public BaseResponse(T data, string? message = null)
    {
        Succeeded = true;
        Message = message;
        Data = data;
    }
    public BaseResponse(string message)
    {
        Succeeded = false;
        Message = message;
    }
    public BaseResponse(string message, bool succeeded)
    {
        Succeeded = succeeded;
        Message = message;
    }
    #endregion


    #region Methods
    public HttpStatusCode? StatusCode { get; set; }
    public object? Meta { get; set; }
    public bool? Succeeded { get; set; }
    public string? Message { get; set; }
    public List<string>? Errors { get; set; }
    public T? Data { get; set; }
    #endregion
}