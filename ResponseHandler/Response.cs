using System.Net;
namespace ResponseHandler;
public class Response<T>
{
    public T? Data { get; set; }
    public HttpStatusCode HttpStatusCode { get; set; }
    public bool Succeeded { get; set; }
    public string? Massage { get; set; }
    public object? Meta { get; set; }
}