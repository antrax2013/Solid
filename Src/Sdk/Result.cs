namespace Sdk
{
    public class Result
    {
        private readonly bool _success;
        private readonly string? _message;
        public bool IsSuccess => _success;
        public bool IsFailure => !_success;

        public string? Message => _message;

        private Result(bool success, string? message)
        {
            _success = success;
            _message = message;
        }

        public static Result Ok() => new(true, null);
        public static Result Fail(string message) => new(false, message);
    }

    public class Result<T>
    {
        private readonly Result _result;
        private readonly T? _value;

        private Result(T? value, bool success, string? message)
        {
            _result = success ? Result.Ok() : Result.Fail(message ?? throw new ArgumentException("message is null"));
            _value = value;
        }

        public bool IsSuccess => _result.IsSuccess;
        public bool IsFailure => _result.IsFailure;
        public T? Value => _value;

        public static Result<T> Ok(T value) => new(value, true, null);
        public static Result<T> Fail(string message) => new(default, false, message);

    }
}
