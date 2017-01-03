using System;
using System.Text;
using Xunit;

namespace SpanCorrupt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GetValue2();
        }

        [Fact]
        private static void GetValue2()
        {
            W(Encoding.ASCII.GetBytes("Header:value\r\n\r\n"));
        }

        private static void W(Span<byte> source)
        {
            Console.WriteLine("BEFORE LOOP " + string.Join(" ", source.ToArray()));
            for (int i = 1; i < 32 ; i ++)
            {
                var a = Environment.StackTrace;

                Console.WriteLine(i + " -- " +string.Join(" ", source.ToArray()));
            }
        }
    }
}
