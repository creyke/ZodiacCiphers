using System.Collections.Generic;
using System.Text;

namespace ZodiacCiphers
{
    public enum S
    {
        Unknown,
        A,
        E,
        N,
        Zodiac,
        Eight,
        K,
        M,
        TUpsideDown,
        H,
        R,
        ArrowRight,
        PBackwards,
        LBackwards,
        ArrowUp,
        ArrowDown,
        P,
        KBackwards,
        I,
        SunUp,
        L,
        T,
        Z,
        SunDown,
        DBackwards,
        Plus,
        B,
        CircleLineVert,
        SquareFilled,
        O,
        SquareOpenTopLeft,
        D,
        W,
        Y,
        Dot,
        ArrowLeft,
        SquareOpenTopRight,
        FBackwards,
        CircleLineHoriz,
        YBackwards,
        DogNoseDotRight,
        CBackwards,
        ULower,
        G,
        J,
        S,
        TriangleTarget,
        TriangleFilled,
        CircleOpenLeft,
        CircleOpenDown,
        SquareEmpty,
        TriangleEmpty,
        JBackwards,
        CircleFilled,
        PFilled,
        CircleOpenRight,
        ForwardSlash,
        Dash,
        C,
        F,
        QBackwards,
        DogNoseDotLeft,
        X,
        SquareTarget,
        BBackwards,
        CircleTarget,
        CircleOpenTop,
        U,
        Pi,
        EBackwards,
        DogNose,
        Q,
        RBackwards,
        BackwardSlash
    }

    public static class SExtensions
    {
        public static string[] ToZodiacStringGrid(this S[] that, int width)
        {
            var lines = new List<string>();
            StringBuilder str = null;
            for (int i = 0; i < that.Length; i++)
            {
                if (i % width == 0)
                {
                    if (str != null)
                    { 
                        lines.Add(str.ToString());
                    }
                    str = new StringBuilder();
                }
                var ch = that[i];
                str.Append(ch.ToChar());
            }
            if (str.Length > 0)
            {
                lines.Add(str.ToString());
            }
            return lines.ToArray();
        }

        public static char[] ToZodiacChars(this S[] that)
        {
            var array = new char[that.Length];
            for (int i = 0; i < that.Length; i++)
            {
                array[i] = that[i].ToChar();
            }
            return array;
        }

        public static char ToChar(this S that)
        {
            return Map.ContainsKey(that)
                ? Map[that]
                : '?';
        }

        private static Dictionary<S, char> Map = new Dictionary<S, char>
        {
            { S.Unknown, '?' },
            { S.A, 'A' },
            { S.E, 'E' },
            { S.N, 'N' },
            { S.Zodiac, '?' },
            { S.Eight, '8' },
            { S.K, 'K' },
            { S.M, 'M' },
            { S.TUpsideDown, '﬩' },
            { S.H, 'H' },
            { S.R, 'R' },
            { S.ArrowRight, '>' },
            { S.PBackwards, '?' },
            { S.LBackwards, '?' },
            { S.ArrowUp, '^' },
            { S.ArrowDown, 'V' },
            { S.P, 'P' },
            { S.KBackwards, '?' },
            { S.I, 'I' },
            { S.SunUp, '?' },
            { S.L, 'L' },
            { S.T, 'T' },
            { S.Z, 'Z' },
            { S.SunDown, '?' },
            { S.DBackwards, '?' },
            { S.Plus, '+' },
            { S.B, 'B' },
            { S.CircleLineVert, 'Ф' },
            { S.SquareFilled, '■' },
            { S.O, 'O' },
            { S.SquareOpenTopLeft, '?' },
            { S.D, 'D' },
            { S.W, 'W' },
            { S.Y, 'Y' },
            { S.Dot, '.' },
            { S.ArrowLeft, '<' },
            { S.SquareOpenTopRight, '?' },
            { S.FBackwards, '?' },
            { S.CircleLineHoriz, 'ϴ' },
            { S.YBackwards, '?' },
            { S.DogNoseDotRight, '?' },
            { S.CBackwards, 'ᴐ' },
            { S.ULower, 'u' },
            { S.G, 'G' },
            { S.J, 'J' },
            { S.S, 'S' },
            { S.TriangleTarget, '?' },
            { S.TriangleFilled, '▲' },
            { S.CircleOpenLeft, '?' },
            { S.CircleOpenDown, '?' },
            { S.SquareEmpty, '□' },
            { S.TriangleEmpty, '∆' },
            { S.JBackwards, '?' },
            { S.CircleFilled, '●' },
            { S.PFilled, '₱' },
            { S.CircleOpenRight, '?' },
            { S.ForwardSlash, '/' },
            { S.Dash, '-' },
            { S.C, 'C' },
            { S.F, 'F' },
            { S.QBackwards, '?' },
            { S.DogNoseDotLeft, '?' },
            { S.X, 'X' },
            { S.SquareTarget, '?' },
            { S.BBackwards, 'ᘀ' },
            { S.CircleTarget, '?' },
            { S.CircleOpenTop, '?' },
            { S.U, 'U' },
            { S.Pi, 'π' },
            { S.EBackwards, 'ⱻ' },
            { S.DogNose, 'ᴥ' },
            { S.Q, 'Q' },
            { S.RBackwards, 'ᴙ' },
            { S.BackwardSlash, '?' },
        };
    }
}
