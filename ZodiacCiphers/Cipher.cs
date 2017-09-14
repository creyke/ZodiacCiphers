namespace ZodiacCiphers
{
    public abstract class Cipher<TSymbolCharacters>
    {
        public abstract TSymbolCharacters[,] GetSymbols();
    }
}
