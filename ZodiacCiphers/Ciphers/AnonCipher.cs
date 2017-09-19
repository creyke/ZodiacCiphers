namespace ZodiacCiphers.Ciphers
{
    public class AnonCipher<TSymbols> : Cipher<TSymbols>
    {
        public override TSymbols[] Symbols { get; protected set; }

        public void SetSymbols(TSymbols[] symbols, int width)
        {
            Symbols = symbols;
            Width = width;
        }
    }
}
