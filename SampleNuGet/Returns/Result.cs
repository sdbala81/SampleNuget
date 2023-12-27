using System.Diagnostics.CodeAnalysis;

namespace QT.OBE.SharedKernel.Returns;

public class Result
{
    protected Result(bool isSuccess, Error error)
    {
#pragma warning disable IDE0048
        if (isSuccess && error != Error.None || !isSuccess && error == Error.None)
        {
#pragma warning restore IDE0048
            throw new ArgumentException("Invalid error", nameof(error));
        }

        IsSuccess = isSuccess;
        Error = error;
    }

    public bool IsSuccess { get; }

    public bool IsFailure { get { return !IsSuccess; } }

    public Error Error { get; }

    public static Result Success()
    {
        return new Result(true, Error.None);
    }

    public static Result<TValue> Success<TValue>(TValue value)
    {
        return new Result<TValue>(value, true, Error.None);
    }

    public static Result Failure(Error error)
    {
        return new Result(false, error);
    }

    public static Result<TValue> Failure<TValue>(Error error)
    {
        return new Result<TValue>(default, false, error);
    }
}


public class Result<TValue> : Result
{
    private readonly TValue? _value;

    protected internal Result(TValue? value, bool isSuccess, Error error)
        : base(isSuccess, error)
    {
        _value = value;
    }

    [NotNull]
    public TValue Value
    {
        get { return IsSuccess ? _value! : throw new InvalidOperationException("The value of a failure result can't be accessed."); }
    }

    public static implicit operator Result<TValue>(TValue? value)
    {
        return value is not null ? Success(value) : Failure<TValue>(Error.NullValue);
    }
}
