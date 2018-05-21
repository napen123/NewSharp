using System.IO;

namespace NewSharp.Extensions
{
    public static class StreamExtensions
    {
        public static byte[] ReadAllBytes(this Stream reader)
        {
            using (var memory = new MemoryStream())
            {
                reader.Position = 0;
                reader.CopyTo(memory);

                return memory.ToArray();
            }
        }
    }
}
