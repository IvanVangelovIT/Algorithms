using System;
using System.Collections.Generic;

namespace _8_Queen_Puzzle
{
    class Program
    {
        private const int ChessSize = 8;
        private static bool[,] ChessBoard = new bool[ChessSize, ChessSize];

        private static HashSet<int> Row = new HashSet<int>();
        private static HashSet<int> Col = new HashSet<int>();
        private static HashSet<int> LeftDiagonal = new HashSet<int>();
        private static HashSet<int> RightDiagonal = new HashSet<int>();
        static void Main(string[] args)
        {
            PutQueenOnChess(0);
        }

        private static void PutQueenOnChess(int row)
        {
            if (row == ChessSize)
            {
                PrintSolution();
            }

            for (int col = 0; col < ChessSize; col++)
            {
                if (CanPlaceQueen(row, col))
                {
                    MarkQueenAsPlaced(row, col);
                    PutQueenOnChess(row + 1);
                    UnmarkQueen(row, col);
                }
            }
        }

        private static void UnmarkQueen(int row, int col)
        {
            Row.Remove(row);
            Col.Remove(col);
            LeftDiagonal.Remove(col - row);
            RightDiagonal.Remove(col + row);

            ChessBoard[row, col] = false;
        }

        private static void MarkQueenAsPlaced(int row, int col)
        {
            Row.Add(row);
            Col.Add(col);
            LeftDiagonal.Add(col - row);
            RightDiagonal.Add(col + row);

            ChessBoard[row, col] = true;
        }

        private static bool CanPlaceQueen(int row, int col)
        {
            bool isRowAttacked = Row.Contains(row);
            bool isColumnAttacked = Col.Contains(col);
            bool isLeftDiagonalAttacked = LeftDiagonal.Contains(col - row);
            bool isRightDiagonalAttacked = RightDiagonal.Contains(col + row);

            return !(isRowAttacked || isColumnAttacked || isLeftDiagonalAttacked || isRightDiagonalAttacked);
        }

        private static void PrintSolution()
        {
            for (int i = 0; i < ChessBoard.GetLength(0); i++)
            {
                for (int j = 0; j < ChessBoard.GetLength(1); j++)
                {
                    Console.Write(ChessBoard[i, j] ? '*' : '-');
                    Console.Write(' ');
                }
                    Console.WriteLine();
            }
                Console.WriteLine();
        }
    }
}
