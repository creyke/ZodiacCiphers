namespace ZodiacCiphers.Ciphers
{
    public class Cipher408 : HardcodedCipher<S>
    {
        public override int[] WordTerminations => new int[]
        {
        };

        protected override S[,] DefineSymbolGrid()
        {
            return new S[,]
            {
                // vallejo times-herald.
                { S.TriangleEmpty, S.SquareOpenTopLeft, S.P, S.ForwardSlash, S.Z, S.ForwardSlash, S.U, S.B, S.SquareOpenTopLeft, S.KBackwards, S.O, S.R, S.Pi, S.PBackwards, S.X, S.Pi, S.B },
                { S.W, S.ArrowDown, S.Plus, S.EBackwards, S.G, S.Y, S.F, S.Target, S.TriangleEmpty, S.H, S.P, S.SquareTarget, S.K, S.DogNose, S.QBackwards, S.Y, S.EBackwards },
                { S.M, S.J, S.Y, S.ArrowUp, S.U, S.I, S.KBackwards, S.TriangleTarget, S.QBackwards, S.T, S.TUpsideDown, S.N, S.Q, S.Y, S.D, S.CircleFilled, S.CircleLineHoriz },
                { S.S, S.CircleLineVert, S.ForwardSlash, S.TriangleEmpty, S.SquareFilled, S.B, S.P, S.O, S.R, S.A, S.U, S.SquareOpenTopLeft, S.FBackwards, S.R, S.LBackwards, S.QBackwards, S.E },
                { S.KBackwards, S.ArrowUp, S.L, S.M, S.Z, S.J, S.DBackwards, S.RBackwards, S.BackwardSlash, S.PBackwards, S.F, S.H, S.ArrowDown, S.W, S.EBackwards, S.TriangleFilled, S.Y },
                { S.SquareTarget, S.Plus, S.QBackwards, S.G, S.D, S.TriangleEmpty, S.K, S.I, S.CircleLineHoriz, S.CircleTarget, S.QBackwards, S.X, S.TriangleFilled, S.CircleFilled, S.Zodiac, S.S, S.CircleLineVert },
                { S.R, S.N, S.TUpsideDown, S.DogNose, S.Y, S.E, S.LBackwards, S.O, S.TriangleFilled, S.QBackwards, S.G, S.B, S.T, S.Q, S.S, S.SquareFilled, S.B },
                { S.L, S.DBackwards, S.ForwardSlash, S.P, S.SquareFilled, S.B, S.SquareTarget, S.X, S.QBackwards, S.E, S.H, S.M, S.U, S.ArrowUp, S.R, S.R, S.KBackwards },
                // san francisco examiner.
                { S.CBackwards, S.Z, S.K, S.QBackwards, S.PBackwards, S.I, S.CircleLineHoriz, S.W, S.QBackwards, S.DogNose, S.TriangleFilled, S.CircleFilled, S.L, S.M, S.RBackwards, S.TriangleEmpty, S.SquareFilled },
                { S.B, S.P, S.D, S.R, S.Plus, S.JBackwards, S.Pi, S.CircleTarget, S.BackwardSlash, S.N, S.CircleLineVert, S.EBackwards, S.E, S.U, S.H, S.KBackwards, S.F },
                { S.Z, S.CBackwards, S.PBackwards, S.O, S.ArrowDown, S.W, S.I, S.CircleFilled, S.Plus, S.TUpsideDown, S.L, S.CircleLineHoriz, S.LBackwards, S.ArrowUp, S.R, S.CircleTarget, S.H },
                { S.I, S.TriangleEmpty, S.D, S.R, S.SquareEmpty, S.T, S.Y, S.RBackwards, S.BackwardSlash, S.DBackwards, S.EBackwards, S.ForwardSlash, S.SquareTarget, S.X, S.J, S.Q, S.A },
                { S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B },
                { S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B },
                { S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B },
                { S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B },
                // san francisco chronicle.
                { S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B },
                { S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B },
                { S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B },
                { S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B },
                { S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B },
                { S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B },
                { S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B },
                { S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B, S.B }
            };
        }
    }
}
