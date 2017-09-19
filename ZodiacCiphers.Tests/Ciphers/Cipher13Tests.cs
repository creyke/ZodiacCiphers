using Xunit;

namespace ZodiacCiphers.Ciphers.Tests
{
    public class Cipher13Tests
    {
        [Fact]
        public void CanCreate()
        {
            var cipher = new Cipher13();

            Assert.Equal(13, cipher.Symbols.Length);
        }
    }
}
