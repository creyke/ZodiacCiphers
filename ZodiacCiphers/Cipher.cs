namespace ZodiacCiphers
{
    public abstract class Cipher<TSymbols>
    {
        public int Width { get; protected set; }

        public abstract TSymbols[] Symbols { get; protected set; }
    }
}
