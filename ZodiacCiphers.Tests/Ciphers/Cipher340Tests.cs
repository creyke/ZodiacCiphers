using Xunit;

namespace ZodiacCiphers.Ciphers.Tests
{
    public class Cipher340Tests
    {
        [Fact]
        public void CanCreate()
        {
            var cipher = new Cipher340();

            Assert.Equal(340, cipher.GetSymbols().LongLength);
        }
    }
}
