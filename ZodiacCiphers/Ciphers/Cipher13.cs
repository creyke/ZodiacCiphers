namespace ZodiacCiphers.Ciphers
{
    public class Cipher13 : Cipher<Cipher13.S>
    {
        public override S[,] GetSymbols()
        {
            return new S[,]
            {
                {S.A, S.E, S.N, S.Zodiac, S.Eight, S.K, S.Eight, S.M, S.Eight, S.TUpsideDown, S.N, S.A, S.M}
            };
        }

        public enum S
        {
            A,
            E,
            N,
            Zodiac,
            Eight,
            K,
            M,
            TUpsideDown,
        }
    }
}
