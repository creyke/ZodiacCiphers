using System.Linq;
using ZodiacCiphers.Ciphers;

namespace ZodiacCiphers.Keys
{
    public abstract class Key<T>
    {
        public char[] DecodeWithSpaces(HardcodedCipher<T> cipher)
        {
            var decoded = Decode(cipher);
            var decodedWithSpaces = new char[decoded.Length + cipher.WordTerminations.Length];
            var index = 0;
            for (int i = 0; i < decoded.Length; i++)
            {
                if (cipher.WordTerminations.Contains(i))
                {
                    decodedWithSpaces[index] = ' ';
                    index++;
                }

                decodedWithSpaces[index] = decoded[i];
                index++;
            }
            return decodedWithSpaces;
        }

        public abstract char[] Decode(Cipher<T> cipher);

        public abstract Cipher<T> Encode(string text, int width);
    }
}