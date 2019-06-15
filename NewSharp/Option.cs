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
    public sealed class OptionException : Exception
    {
        public OptionException()
        {
        }

        public OptionException(string message) : base(message)
        {
        }

        public OptionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public OptionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    public readonly struct Option<T>
    {
        private readonly T _value;

        public bool IsSome
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get;
        }

        public bool IsNone
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => !IsSome;
        }

        internal Option(bool hasValue, T value)
        {
            IsSome = hasValue;

            _value = value;
        }

        public T Expect()
        {
            if (IsSome)
                return _value;

            throw new OptionException();
        }

        public T Expect(string message)
        {
            if (IsSome)
                return _value;

            throw new OptionException(message);
        }

        public T ExpectOr(T defaultValue)
        {
            return IsSome ? _value : defaultValue;
        }

        public T ExpectOrElse(Func<T> defaultValue)
        {
            return IsSome ? _value : defaultValue();
        }

        public T ExpectOrDefault()
        {
            return IsSome ? _value : default;
        }

        public Option<TNew> Map<TNew>(Func<T, TNew> map)
        {
            return IsSome
                ? new Option<TNew>(true, map(_value))
                : new Option<TNew>(false, default);
        }

        public Option<TNew> MapOr<TNew>(TNew defaultValue, Func<T, TNew> map)
        {
            return IsSome
                ? new Option<TNew>(true, map(_value))
                : new Option<TNew>(true, defaultValue);
        }

        public Option<TNew> MapOrElse<TNew>(Func<TNew> defaultValue, Func<T, TNew> map)
        {
            return IsSome
                ? new Option<TNew>(true, map(_value))
                : new Option<TNew>(true, defaultValue());
        }

        public Option<TNew> And<TNew>(Option<TNew> other)
        {
            return IsSome
                ? other
                : new Option<TNew>(false, default);
        }

        public Option<TNew> AndThen<TNew>(Func<T, Option<TNew>> other)
        {
            return IsSome
                ? other(_value)
                : new Option<TNew>(false, default);
        }

        public Option<T> Or(Option<T> other)
        {
            return IsSome
                ? other
                : new Option<T>(false, default);
        }

        public Option<T> OrElse(Func<Option<T>> other)
        {
            return IsSome
                ? other()
                : new Option<T>(false, default);
        }
    }
}
