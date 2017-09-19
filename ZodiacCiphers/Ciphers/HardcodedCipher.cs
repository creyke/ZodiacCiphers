namespace ZodiacCiphers.Ciphers
{
    public abstract class HardcodedCipher<TSymbols> : Cipher<TSymbols>
    {
        public override TSymbols[] Symbols { get; protected set; }

        public HardcodedCipher()
        {
            var symbolsGrid = DefineSymbolGrid();
            Width = symbolsGrid.GetLength(0);
            Symbols = new TSymbols[symbolsGrid.LongLength];
            var index = 0;
            foreach (var symbol in symbolsGrid)
            {
                Symbols[index++] = symbol;
            }
        }

        protected abstract TSymbols[,] DefineSymbolGrid();

        public abstract int[] WordTerminations { get; }
    }
}
