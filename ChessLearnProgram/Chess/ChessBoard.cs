﻿using System.Windows.Forms;
using Chess.Pieces;

namespace Chess
{
    public static class ChessBoard
    {
        public static readonly ChessPiece[,] ChessBoardMatrix = new ChessPiece[8, 8];

        internal static ChessPiece GetPieceOrNull(int currentRow, int currentColumn)
        {
            bool isValidRow    = (currentRow    >= 0) && (currentRow    <= 7);
            bool isValidColumn = (currentColumn >= 0) && (currentColumn <= 7);
            if (isValidColumn && isValidRow)
            {
                return ChessBoardMatrix[currentRow, currentColumn];
            }

            return null;
        }
    }
}
