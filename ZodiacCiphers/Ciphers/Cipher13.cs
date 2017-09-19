using System.Collections.Generic;

namespace ZodiacCiphers.Ciphers
{
    public class Cipher13 : HardcodedCipher<S>
    {
        public override int[] WordTerminations => new int[]
        {
            0
        };

        protected override S[,] DefineSymbolGrid()
        {
            return new S[,]
            {
                {S.A, S.E, S.N, S.Zodiac, S.Eight, S.K, S.Eight, S.M, S.Eight, S.TUpsideDown, S.N, S.A, S.M}
            };
        }
    }
}
