using System;
using System.Runtime.Serialization;
using System.Runtime.CompilerServices;

namespace NewSharp
{
    public static class Option
    {
        public static Option<T> Some<T>(T value) => new Option<T>(true, value);
        public static Option<T> None<T>() => new Option<T>(false, default);
    }

    [Serializable]
    public sealed class OptionNoneException : Exception
    {
        public OptionNoneException()
        {
        }

        public OptionNoneException(string message) : base(message)
        {
        }

        public OptionNoneException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public OptionNoneException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    public readonly struct Option<T>
    {
        private readonly bool _hasValue;
        private readonly T _value;

        public bool IsSome
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _hasValue;
        }

        public bool IsNone
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => !_hasValue;
        }

        internal Option(bool hasValue, T value)
        {
            _hasValue = hasValue;
            _value = value;
        }

        public T Expect()
        {
            if (_hasValue)
                return _value;

            throw new OptionNoneException();
        }

        public T Expect(string message)
        {
            if (_hasValue)
                return _value;

            throw new OptionNoneException(message);
        }

        public T ExpectOr(T defaultValue)
        {
            return _hasValue ? _value : defaultValue;
        }

        public T ExpectOrElse(Func<T> defaultValue)
        {
            return _hasValue ? _value : defaultValue();
        }

        public T ExpectOrDefault()
        {
            return _hasValue ? _value : default;
        }

        public Option<TNew> Map<TNew>(Func<T, TNew> map)
        {
            return _hasValue
                ? new Option<TNew>(true, map(_value))
                : new Option<TNew>(false, default);
        }

        public Option<TNew> MapOr<TNew>(TNew defaultValue, Func<T, TNew> map)
        {
            return _hasValue
                ? new Option<TNew>(true, map(_value))
                : new Option<TNew>(true, defaultValue);
        }

        public Option<TNew> MapOrElse<TNew>(Func<TNew> defaultValue, Func<T, TNew> map)
        {
            return _hasValue
                ? new Option<TNew>(true, map(_value))
                : new Option<TNew>(true, defaultValue());
        }

        public Option<TNew> And<TNew>(Option<TNew> other)
        {
            return _hasValue
                ? other
                : new Option<TNew>(false, default);
        }

        public Option<TNew> AndThen<TNew>(Func<T, Option<TNew>> other)
        {
            return _hasValue
                ? other(_value)
                : new Option<TNew>(false, default);
        }

        public Option<T> Or(Option<T> other)
        {
            return _hasValue
                ? other
                : new Option<T>(false, default);
        }

        public Option<T> OrElse(Func<Option<T>> other)
        {
            return _hasValue
                ? other()
                : new Option<T>(false, default);
        }
    }
}
