using System.Collections.Generic;

namespace ZodiacCiphers.Keys
{
    public abstract class Key<T>
    {
        public abstract char[] Decode(Cipher<T> cipher);

        public abstract Cipher<T> Encode(string text, int width);
    }
}