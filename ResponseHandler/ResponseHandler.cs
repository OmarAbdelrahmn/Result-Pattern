using System.Net;

namespace ResponseHandler;
public class ResponseHandler
{
    public static Response<T> Delete<T>()
    {
        return new Response<T>()
        {
            HttpStatusCode = System.Net.HttpStatusCode.OK,
            Succeeded = true,
            Massage = "Deleted"
        };
    }

    public static Response<T> Success<T>(T entity, object? meta = null)
    {
        return new Response<T>()
        {
            Data = entity,
            HttpStatusCode = System.Net.HttpStatusCode.OK,
            Succeeded = true,
            Massage = "Success",
            Meta = meta
        };
    }

    public static Response<T> UnAuthorized<T>(string? message)
    {
        return new Response<T>()
        {
            HttpStatusCode = System.Net.HttpStatusCode.Unauthorized,
            Succeeded = false,
            Massage = message,
        };
    }

    public static Response<T> BadRequest<T>(string? message)
    {
        return new Response<T>()
        {
            HttpStatusCode = System.Net.HttpStatusCode.BadRequest,
            Succeeded = false,
            Massage = message ?? "BadRequest"
        };
    }
    public static Response<T> NotFound<T>(string? message)
    {
        return new Response<T>()
        {
            HttpStatusCode = System.Net.HttpStatusCode.NotFound,
            Succeeded = false,
            Massage = message ?? "NotFound"
        };
    }
    public static Response<T> Created<T>(string? message)
    {
        return new Response<T>()
        {
            HttpStatusCode = System.Net.HttpStatusCode.Created,
            Succeeded = true,
            Massage = message ?? "Created"
        };
    }


}