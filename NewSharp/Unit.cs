using System;

namespace NewSharp
{
    [Serializable]
    public readonly struct Unit
    {
        public static readonly Unit Empty = new Unit();
    }
}
