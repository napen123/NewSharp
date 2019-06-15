using System;

namespace NewSharp
{
    [Serializable]
    public readonly struct Unit : ICloneable, IEquatable<Unit>, IComparable<Unit>
    {
        public static readonly Unit Empty = new Unit();

        public object Clone()
        {
            return Empty;
        }

        public bool Equals(Unit other)
        {
            return true;
        }

        public override bool Equals(object obj)
        {
            return obj is Unit;
        }

        public int CompareTo(Unit other)
        {
            return 0;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return "(unit)";
        }

        public static bool operator ==(Unit left, Unit right)
        {
            return true;
        }

        public static bool operator !=(Unit left, Unit right)
        {
            return false;
        }

        public static bool operator <(Unit left, Unit right)
        {
            return false;
        }

        public static bool operator >(Unit left, Unit right)
        {
            return false;
        }

        public static bool operator <=(Unit left, Unit right)
        {
            return true;
        }

        public static bool operator >=(Unit left, Unit right)
        {
            return true;
        }
    }
}
