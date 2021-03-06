﻿namespace ZodiacCiphers.Ciphers
{
    public class Cipher340 : HardcodedCipher<S>
    {
        public override int[] WordTerminations => new int[]
        {
        };

        protected override S[,] DefineSymbolGrid()
        {
            return new S[,]
            {
                {S.H, S.E, S.R, S.ArrowRight, S.PBackwards, S.LBackwards, S.ArrowUp, S.ArrowDown, S.P, S.KBackwards, S.I, S.SunUp, S.L, S.T, S.G, S.SunDown, S.DBackwards},
                {S.N, S.Plus, S.B, S.CircleLineVert, S.SquareFilled, S.O, S.SquareOpenTopLeft, S.D, S.W, S.Y, S.Dot, S.ArrowLeft, S.SquareOpenTopRight, S.K, S.FBackwards, S.SunDown, S.CircleLineHoriz},
                {S.B, S.YBackwards, S.DogNoseDotRight, S.CBackwards, S.M, S.Plus, S.ULower, S.Z, S.G, S.W, S.CircleLineVert, S.CircleLineHoriz, S.L, S.SquareFilled, S.Zodiac, S.H, S.J},
                {S.S, S.PBackwards, S.PBackwards, S.TriangleTarget, S.ArrowUp, S.LBackwards, S.TriangleFilled, S.SquareOpenTopRight, S.ArrowDown, S.CircleOpenLeft, S.PBackwards, S.O, S.Plus, S.Plus, S.R, S.K, S.CircleOpenDown},
                {S.SquareEmpty, S.TriangleEmpty, S.M, S.Plus, S.Zodiac, S.TUpsideDown, S.JBackwards, S.DBackwards, S.I, S.CircleFilled, S.FBackwards, S.PBackwards, S.Plus, S.PFilled, S.CircleOpenRight, S.KBackwards, S.ForwardSlash},
                {S.PBackwards, S.TriangleFilled, S.R, S.ArrowUp, S.F, S.LBackwards, S.O, S.Dash, S.SquareOpenTopRight, S.DBackwards, S.C, S.KBackwards, S.F, S.ArrowRight, S.CircleOpenDown, S.D, S.CircleLineVert},
                {S.SquareFilled, S.CircleFilled, S.Plus, S.K, S.QBackwards, S.SquareOpenTopLeft, S.DogNoseDotLeft, S.CircleOpenDown, S.ULower, S.CBackwards, S.X, S.G, S.ArrowDown, S.Dot, S.Zodiac, S.L, S.I},
                {S.CircleLineVert, S.G, S.CircleOpenDown, S.J, S.FBackwards, S.JBackwards, S.SquareFilled, S.O, S.Plus, S.SquareEmpty, S.N, S.Y, S.Zodiac, S.Plus, S.SquareTarget, S.L, S.TriangleEmpty},
                {S.DBackwards, S.ArrowLeft, S.M, S.Plus, S.BBackwards, S.Plus, S.Z, S.R, S.CircleOpenDown, S.F, S.B, S.CBackwards, S.YBackwards, S.A, S.CircleTarget, S.CircleOpenRight, S.K},
                {S.Dash, S.Zodiac, S.LBackwards, S.ULower, S.ArrowDown, S.Plus, S.ArrowUp, S.J, S.Plus, S.O, S.PBackwards, S.TriangleTarget, S.ArrowLeft, S.F, S.B, S.YBackwards, S.Dash},
                {S.ULower, S.Plus, S.R, S.ForwardSlash, S.CircleFilled, S.TUpsideDown, S.E, S.I, S.D, S.Y, S.B, S.PBackwards, S.BBackwards, S.T, S.M, S.K, S.O},
                {S.CircleOpenDown, S.ArrowLeft, S.CBackwards, S.LBackwards, S.R, S.J, S.I, S.SquareOpenTopRight, S.CircleFilled, S.T, S.CircleOpenRight, S.M, S.Dot, S.Plus, S.P, S.B, S.F},
                {S.Zodiac, S.CircleTarget, S.TriangleEmpty, S.S, S.YBackwards, S.SquareFilled, S.Plus, S.N, S.I, S.CircleFilled, S.F, S.B, S.CBackwards, S.CircleLineVert, S.DogNoseDotLeft, S.TriangleFilled, S.R},
                {S.LBackwards, S.G, S.F, S.N, S.ArrowUp, S.FBackwards, S.CircleFilled, S.CircleOpenDown, S.CircleOpenRight, S.BBackwards, S.Dot, S.CBackwards, S.ArrowDown, S.CircleOpenRight, S.TUpsideDown, S.Plus, S.Plus},
                {S.YBackwards, S.B, S.X, S.CircleOpenTop, S.SquareOpenTopRight, S.DogNoseDotRight, S.CircleOpenRight, S.TriangleEmpty, S.C, S.E, S.ArrowRight, S.ArrowDown, S.ULower, S.Z, S.CircleFilled, S.Dash, S.Plus},
                {S.I, S.CBackwards, S.Dot, S.CircleOpenLeft, S.Zodiac, S.B, S.K, S.CircleLineVert, S.O, S.PBackwards, S.ArrowUp, S.Dot, S.FBackwards, S.M, S.QBackwards, S.G, S.CircleOpenDown},
                {S.R, S.CBackwards, S.T, S.Plus, S.L, S.CircleOpenTop, S.CircleTarget, S.C, S.ArrowLeft, S.Plus, S.F, S.LBackwards, S.W, S.B, S.I, S.CircleLineHoriz, S.L},
                {S.Plus, S.Plus, S.CircleLineHoriz, S.W, S.C, S.Zodiac, S.W, S.CBackwards, S.P, S.O, S.S, S.H, S.T, S.ForwardSlash, S.CircleLineVert, S.CircleLineHoriz, S.PBackwards},
                {S.I, S.F, S.KBackwards, S.DBackwards, S.W, S.ArrowLeft, S.TriangleTarget, S.TUpsideDown, S.B, S.SquareEmpty, S.Y, S.O, S.B, S.SquareOpenTopRight, S.Dash, S.C, S.CBackwards},
                {S.ArrowRight, S.M, S.D, S.H, S.N, S.PBackwards, S.KBackwards, S.S, S.Zodiac, S.Z, S.O, S.TriangleFilled, S.A, S.I, S.K, S.DogNoseDotRight, S.Plus}
            };
        }
    }
}
