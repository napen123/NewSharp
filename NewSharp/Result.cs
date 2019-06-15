using System;
using System.Runtime.Serialization;
using System.Runtime.CompilerServices;

namespace NewSharp
{
    public static class Result
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Result<TOk, TError> Ok<TOk, TError>(TOk value) =>
            new Result<TOk, TError>(true, value, default);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Result<TOk, TError> Error<TOk, TError>(TError value) =>
            new Result<TOk, TError>(true, default, value);

        public static Result<Unit, Exception> Try(Action action)
        {
            try
            {
                action();

                return Ok<Unit, Exception>(Unit.Empty);
            }
            catch (Exception e)
            {
                return Error<Unit, Exception>(e);
            }
        }

        public static Result<T, Exception> Try<T>(Func<T> func)
        {
            try
            {
                return Ok<T, Exception>(func());
            }
            catch (Exception e)
            {
                return Error<T, Exception>(e);
            }
        }
    }

    [Serializable]
    public sealed class ResultException : Exception
    {
        public ResultException()
        {
        }

        public ResultException(string message) : base(message)
        {
        }

        public ResultException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public ResultException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    public readonly struct Result<TOk, TError>
    {
        private readonly TOk _okValue;
        private readonly TError _errorValue;

        public bool IsOk
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get;
        }

        public bool IsError
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => !IsOk;
        }

        public Option<TOk> OkValue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => IsOk ? Option.Some(_okValue) : Option.None<TOk>();
        }

        public Option<TError> ErrorValue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => IsError ? Option.Some(_errorValue) : Option.None<TError>();
        }

        internal Result(bool isOk, TOk okValue, TError errorValue)
        {
            IsOk = isOk;

            _okValue = okValue;
            _errorValue = errorValue;
        }

        public TOk Expect()
        {
            if (IsOk)
                return _okValue;

            throw new ResultException();
        }

        public TOk Expect(string message)
        {
            if (IsOk)
                return _okValue;

            throw new ResultException(message);
        }

        public TOk ExpectOr(TOk defaultValue)
        {
            return IsOk ? _okValue : defaultValue;
        }

        public TOk ExpectOrElse(Func<TOk> defaultValue)
        {
            return IsOk ? _okValue : defaultValue();
        }

        public TOk ExpectOrDefault()
        {
            return IsOk ? _okValue : default;
        }

        public TError ExpectError()
        {
            if (IsError)
                return _errorValue;

            throw new ResultException();
        }

        public TError ExpectError(string message)
        {
            if (IsError)
                return _errorValue;

            throw new ResultException(message);
        }

        public TError ExpectErrorOr(TError defaultValue)
        {
            return IsError ? _errorValue : defaultValue;
        }

        public TError ExpectErrorOrElse(Func<TError> defaultValue)
        {
            return IsError ? _errorValue : defaultValue();
        }

        public TError ExpectErrorOrDefault()
        {
            return IsError ? _errorValue : default;
        }

        public Result<TNew, TError> Map<TNew>(Func<TOk, TNew> map)
        {
            return IsOk
                ? Result.Ok<TNew, TError>(map(_okValue))
                : Result.Error<TNew, TError>(_errorValue);
        }

        public Result<TNew, TError> MapOr<TNew>(TNew defaultValue, Func<TOk, TNew> map)
        {
            return IsOk
                ? Result.Ok<TNew, TError>(map(_okValue))
                : Result.Ok<TNew, TError>(defaultValue);
        }

        public Result<TNew, TError> MapOrElse<TNew>(Func<TNew> defaultValue, Func<TOk, TNew> map)
        {
            return IsOk
                ? Result.Ok<TNew, TError>(map(_okValue))
                : Result.Ok<TNew, TError>(defaultValue());
        }

        public Result<TNew, TError> And<TNew>(Result<TNew, TError> other)
        {
            return IsOk
                ? other
                : Result.Error<TNew, TError>(_errorValue);
        }

        public Result<TNew, TError> AndThen<TNew>(Func<TOk, Result<TNew, TError>> other)
        {
            return IsOk
                ? other(_okValue)
                : Result.Error<TNew, TError>(_errorValue);
        }

        public Result<TOk, TError> Or(Result<TOk, TError> other)
        {
            return IsOk
                ? this
                : other;
        }

        public Result<TOk, TError> OrElse(Func<TError, Result<TOk, TError>> other)
        {
            return IsOk
                ? this
                : other(_errorValue);
        }
    }
}
