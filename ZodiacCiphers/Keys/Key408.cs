using System;
using System.Collections.Generic;
using ZodiacCiphers.Ciphers;

namespace ZodiacCiphers.Keys
{
    public class Key408 : Key<S>
    {
        public static IReadOnlyDictionary<char, S[]> Map { get; } = CreateMap();
        public static IReadOnlyDictionary<S, char> Index { get; } = IndexMap();

        public override char[] Decode(Cipher<S> cipher)
        {
            var symbols = cipher.Symbols;
            var decoded = new char[symbols.Length];
            var i = 0;
            foreach (var symbol in symbols)
            {
                decoded[i] = Index.ContainsKey(symbol)
                    ? Index[symbol]
                    : '?';
                i++;
            }
            return decoded;
        }

        public override Cipher<S> Encode(string text, int width)
        {
            text = text.Replace(" ", "").ToUpperInvariant();
            var cipher = new AnonCipher<S>();
            var encoded = new S[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                var ch = text[i];

                var symbol = Map.ContainsKey(ch)
                    ? Map[ch][0]
                    : S.Unknown;

                encoded[i] = symbol;
            }
            cipher.SetSymbols(encoded, width);
            return cipher;
        }

        private static Dictionary<S, char> IndexMap()
        {
            var index = new Dictionary<S, char>();
            foreach (var entry in Map)
            {
                foreach (var symbol in entry.Value)
                {
                    index[symbol] = entry.Key;
                }
            }
            return index;
        }

        private static Dictionary<char, S[]> CreateMap()
        {
            return new Dictionary<char, S[]> {
                { 'A', new []{ S.G, S.S, S.LBackwards, S.TriangleFilled } },
                { 'B', new []{ S.ArrowDown } },
                { 'C', new []{ S.EBackwards } },
                { 'D', new []{ S.FBackwards, S.Zodiac } },
                { 'E', new []{ S.Z, S.PBackwards, S.W, S.Plus, S.N, S.E, S.CircleTarget } },
                { 'F', new []{ S.J, S.Q } },
                { 'G', new []{ S.R } },
                { 'H', new []{ S.M, S.CircleLineHoriz } },
                { 'I', new []{ S.TriangleEmpty, S.P, S.U, S.KBackwards } },
                { 'K', new []{ S.ForwardSlash } },
                { 'L', new []{ S.SquareOpenTopLeft, S.B, S.SquareFilled } },
                { 'M', new []{ S.QBackwards } },
                { 'N', new []{ S.O, S.ArrowUp, S.D, S.CircleLineVert } },
                { 'O', new []{ S.X, S.DogNose, S.T, S.DBackwards } },
                { 'P', new []{ S.Pi } },
                { 'R', new []{ S.TUpsideDown, S.RBackwards, S.BackwardSlash } },
                { 'S', new []{ S.F, S.SquareTarget, S.K, S.TriangleTarget } },
                { 'T', new []{ S.H, S.I, S.CircleFilled, S.L } },
                { 'U', new []{ S.Y } },
                { 'V', new []{ S.CBackwards } },
                { 'W', new []{ S.A } },
                { 'X', new []{ S.JBackwards } },
                { 'Y', new []{ S.SquareEmpty } },
            };
        }
    }
}
