using System.Diagnostics;
using Xunit;
using ZodiacCiphers.Keys;

namespace ZodiacCiphers.Ciphers.Tests
{
    public class Cipher340Tests
    {
        [Fact]
        public void CanCreate()
        {
            var cipher = new Cipher340();
            var grid = cipher.Symbols.ToZodiacStringGrid(cipher.Width);
            foreach (var line in grid)
            {
                Debug.WriteLine(line);
            }
            Assert.Equal(340, cipher.Symbols.Length);
        }

        [Fact]
        public void CanDecode()
        {
            var cipher = new Cipher340();
            var chars = cipher.Symbols.ToZodiacChars();
            var key = new Key408();
            var decoded = new string(key.Decode(cipher));
        }
    }
}
