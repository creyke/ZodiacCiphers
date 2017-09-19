using System.Diagnostics;
using Xunit;
using ZodiacCiphers.Keys;

namespace ZodiacCiphers.Ciphers.Tests
{
    public class Cipher408Tests
    {
        [Fact]
        public void CanCreate()
        {
            var cipher = new Cipher408();
            var grid = cipher.Symbols.ToZodiacStringGrid(cipher.Width);
            foreach (var line in grid)
            {
                Debug.WriteLine(line);
            }
            Assert.Equal(408, cipher.Symbols.Length);
        }

        [Fact]
        public void CanDecode()
        {
            var cipher = new Cipher408();
            var chars = cipher.Symbols.ToZodiacChars();
            var key = new Key408();
            var decoded = new string(key.Decode(cipher));
            Debug.WriteLine(decoded);
        }

        [Fact]
        public void CanEncode()
        {
            var cipher = new Cipher408();
            var key = new Key408();
            var decoded = new string(key.Decode(cipher));
            var cipher2 = key.Encode(decoded, 17);
            var decoded2 = new string(key.Decode(cipher2));
        }

        [Fact]
        public void CanEncodeHellowHowAreYou()
        {
            var key = new Key408();
            var cipher = key.Encode("hello how are you", 10);
            var decoded = new string(key.Decode(cipher));
            var stringGrid = cipher.Symbols.ToZodiacStringGrid(10);
            Assert.Equal("HELLOHOWAREYOU", decoded);
        }
    }
}
