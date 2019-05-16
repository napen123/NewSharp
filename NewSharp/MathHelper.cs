using System;
using System.Runtime.CompilerServices;

namespace NewSharp
{
    public static class MathHelper
    {
        public const double Tau = 2 * Math.PI;

        public const double RadToDeg = 180 / Math.PI;
        public const double DegToRad = Math.PI / 180;

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

        #region Sums

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
    }
}
