using System;
using System.Runtime.CompilerServices;

namespace NewSharp
{
    public static class MathHelper
    {
        public const double Tau = 2 * Math.PI;

        public const double RadToDeg = 180 / Math.PI;
        public const double DegToRad = Math.PI / 180;

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
