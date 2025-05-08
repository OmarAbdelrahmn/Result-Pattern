namespace Result_Pattern.Abstraction;

public class Result
{
    public Result(bool isSuccess, Error error)
    {
        if (isSuccess && error != Error.Non || !isSuccess && error == Error.Non)
            throw new InvalidOperationException("Invalid Operation");

        IsSuccess = isSuccess;
        Error = error;
    }
    public bool IsSuccess { get; set; }
    public bool IsFailure => !IsSuccess;
    public Error Error { get; } = default!;

    public static Result Success() => new(true, Error.Non);
    public static Result Failure(Error error) => new(false, error);
    public static Result<TValue> Success<TValue>(TValue value) => new(value, true, Error.Non);
    public static Result<TValue> Failure<TValue>(Error error) => new(default!, false, error);
}
public class Result<TValue> : Result
{
    private readonly TValue? _value;

    public Result(TValue value, bool isSuccess, Error error) : base(isSuccess, error)
    {
        _value = value;
    }
    public TValue Value => IsSuccess ?
        _value! :
        throw new InvalidOperationException("Failure operation can't have value");

}