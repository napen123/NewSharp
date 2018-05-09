using System;
using System.Runtime.CompilerServices;

namespace NewSharp
{
    public static class MathHelper
    {
        public const double Tau = 2 * Math.PI;

        public const double RadToDeg = 180 / Math.PI;
        public const double DegToRad = Math.PI / 180;
        
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Clamp(float value, float min, float max)
        {
            if (value <= min)
                return min;

            if (value >= max)
                return max;

            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Clamp(double value, double min, double max)
        {
            if (value <= min)
                return min;

            if (value >= max)
                return max;

            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Clamp01(float value, float min, float max)
        {
            if (value <= 0.0f)
                return min;

            if (value >= 1.0f)
                return max;

            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Clamp01(double value, double min, double max)
        {
            if (value <= 0.0d)
                return min;

            if (value >= 1.0d)
                return max;

            return value;
        }
    }
}
