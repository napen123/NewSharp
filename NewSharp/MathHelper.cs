using System;
using System.Runtime.CompilerServices;

namespace NewSharp
{
    public static class MathHelper
    {
        public const double SqrtTwo = 1.4142135623730950;

        public const double GoldenRatio = 1.6180339887498948;
        public const double EulerMascheroni = 0.577215664901533;

        public const double Tau = 2.0 * Math.PI;

        public const double RadToDeg = 180.0 / Math.PI;
        public const double DegToRad = Math.PI / 180.0;

        #region Even

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEven(this sbyte b)
        {
            return b % 2 == 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEven(this short b)
        {
            return b % 2 == 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEven(this int b)
        {
            return b % 2 == 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEven(this long b)
        {
            return b % 2 == 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEven(this byte b)
        {
            return b % 2 == 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEven(this ushort b)
        {
            return b % 2 == 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEven(this uint b)
        {
            return b % 2 == 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEven(this ulong b)
        {
            return b % 2 == 0;
        }

        #endregion

        #region Odd

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsOdd(this sbyte b)
        {
            return b % 2 != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsOdd(this short b)
        {
            return b % 2 != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsOdd(this int b)
        {
            return b % 2 != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsOdd(this long b)
        {
            return b % 2 != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsOdd(this byte b)
        {
            return b % 2 != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsOdd(this ushort b)
        {
            return b % 2 != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsOdd(this uint b)
        {
            return b % 2 != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsOdd(this ulong b)
        {
            return b % 2 != 0;
        }

        #endregion

        #region HasFlag

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasFlag(this sbyte i, sbyte flag)
        {
            return (i & flag) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasFlag(this short i, short flag)
        {
            return (i & flag) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasFlag(this int i, int flag)
        {
            return (i & flag) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasFlag(this long i, long flag)
        {
            return (i & flag) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasFlag(this byte i, byte flag)
        {
            return (i & flag) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasFlag(this ushort i, ushort flag)
        {
            return (i & flag) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasFlag(this uint i, uint flag)
        {
            return (i & flag) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasFlag(this ulong i, ulong flag)
        {
            return (i & flag) != 0;
        }

        #endregion

        #region Conversions

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(this sbyte i)
        {
            return i != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(this short i)
        {
            return i != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(this int i)
        {
            return i != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(this long i)
        {
            return i != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(this byte i)
        {
            return i != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(this ushort i)
        {
            return i != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(this uint i)
        {
            return i != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ToBoolean(this ulong i)
        {
            return i != 0;
        }

        #endregion

        #region Absolute Value

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Abs(sbyte value)
        {
            return value >= 0 ? value : -value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Abs(short value)
        {
            return value >= 0 ? value : -value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Abs(int value)
        {
            return value >= 0 ? value : -value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Abs(long value)
        {
            return value >= 0 ? value : -value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Abs(float value)
        {
            return value >= 0 ? value : -value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Abs(double value)
        {
            return value >= 0 ? value : -value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal Abs(decimal value)
        {
            return value >= 0 ? value : -value;
        }

        #endregion

        #region Conversions

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float RadiansToDegrees(float radians)
        {
            return (float) (radians * RadToDeg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double RadiansToDegrees(double radians)
        {
            return radians * RadToDeg;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double DegreesToRadians(float degrees)
        {
            return (float) (degrees * DegToRad);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double DegreesToRadians(double degrees)
        {
            return degrees * DegToRad;
        }

        #endregion

        #region Clamp

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Clamp(float value, float min, float max)
        {
            if (value >= max)
                return max;

            if (value <= min)
                return min;

            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Clamp(double value, double min, double max)
        {
            if (value >= max)
                return max;

            if (value <= min)
                return min;

            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Clamp01(float value, float min, float max)
        {
            if (value >= 1.0f)
                return max;

            if (value <= 0.0f)
                return min;

            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Clamp01(double value, double min, double max)
        {
            if (value >= 1.0d)
                return max;

            if (value <= 0.0d)
                return min;

            return value;
        }

        #endregion

        #region Integer Sums

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sum(sbyte n)
        {
            return (n * (n + 1)) >> 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sum(short n)
        {
            return (n * (n + 1)) >> 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sum(int n)
        {
            return (n * (n + 1)) >> 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Sum(long n)
        {
            return (n * (n + 1)) >> 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Sum(byte n)
        {
            return (uint) (n * (n + 1)) >> 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Sum(ushort n)
        {
            return (uint)(n * (n + 1)) >> 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Sum(ulong n)
        {
            return (n * (n + 1)) >> 1;
        }

        #endregion

        #region Floating-Point Sums

        public static float KahanSum(float[] inputs)
        {
            var sum = 0f;
            var err = 0f;

            for(var i = 0; i < inputs.Length; i++)
            {
                var y = inputs[i] - err;
                var t = sum + y;
                
                err = t - sum - y;
                sum = t;
            }

            return sum;
        }

        public static double KahanSum(double[] inputs)
        {
            var sum = 0.0;
            var err = 0.0;

            for (var i = 0; i < inputs.Length; i++)
            {
                var y = inputs[i] - err;
                var t = sum + y;

                err = t - sum - y;
                sum = t;
            }

            return sum;
        }

        public static float NeumaierSum(float[] inputs)
        {
            var sum = 0f;
            var err = 0f;

            for (var i = 0; i < inputs.Length; i++)
            {
                var input = inputs[i];
                var t = sum + input;

                err += Abs(sum) >= Abs(input)
                    ? sum - t + input
                    : input - t + sum;
                sum = t;
            }

            return sum + err;
        }

        public static double NeumaierSum(double[] inputs)
        {
            var sum = 0.0;
            var err = 0.0;

            for (var i = 0; i < inputs.Length; i++)
            {
                var input = inputs[i];
                var t = sum + input;

                err += Abs(sum) >= Abs(input)
                    ? sum - t + input
                    : input - t + sum;
                sum = t;
            }

            return sum + err;
        }

        #endregion
    }
}
