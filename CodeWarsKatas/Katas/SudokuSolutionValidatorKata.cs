using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public static class SudokuSolutionValidatorKata
    {
        public static bool ValidateSolution(int[][] board)
        {
            bool isDistinct = true;
            int auxiliaryCounter1 = 0;
            int auxiliaryCounter2 = 0;
            List<int> boardNumbersHorizontal = new List<int>();
            List<int> boardNumbersVertical = new List<int>();

            for (int i = 0; i < board.Length && isDistinct; i++)
            {
                for (int j = 0; j < board.Length; j++)
                {
                    if (board[i][j] == 0)
                    {
                        isDistinct = false;
                        break;
                    }
                    else
                    {
                        boardNumbersHorizontal.Add(board[i][j]);
                        boardNumbersVertical.Add(board[j][i]);
                    }
                }

                if (boardNumbersHorizontal.Distinct().Count() == 9 && boardNumbersVertical.Distinct().Count() == 9)
                {
                    isDistinct = true;
                }
                else
                {
                    isDistinct = false;
                }

                boardNumbersHorizontal.Clear();
            }

            for (int i = 0; i < board.Length && isDistinct; i++)
            {
                for (int j = 0 + auxiliaryCounter1; j < 3 + auxiliaryCounter1; j++)
                {
                    SubMatrixIndexMaker(ref auxiliaryCounter1, ref auxiliaryCounter2, j, i);

                    for (int k = 0 + auxiliaryCounter2; k < 3 + auxiliaryCounter2; k++)
                    {
                        boardNumbersHorizontal.Add(board[j][k]);
                    }
                    if (boardNumbersHorizontal.Distinct().Count() == 9)
                    {
                        isDistinct = true;
                    }
                    else
                    {
                        isDistinct = false;
                    }
                }

            }

            return isDistinct;
        }

        public static void SubMatrixIndexMaker(ref int auxiliaryCounter1, ref int auxiliaryCounter2, int IndexJ, int IndexI)
        {
            switch (IndexI)
            {
                case var expression when (IndexI < 3 && IndexJ < 3):
                    auxiliaryCounter1 = 0;
                    auxiliaryCounter2 = 0;
                    break;

                case var expression when (IndexI < 3 && (IndexJ >= 3 && IndexJ < 6)):
                    auxiliaryCounter1 = 0;
                    auxiliaryCounter2 = 3;
                    break;

                case var expression when (IndexI < 3 && IndexJ >= 6):
                    auxiliaryCounter1 = 0;
                    auxiliaryCounter2 = 6;
                    break;

                case var expression when ((IndexI >= 3 && IndexI < 6) && IndexJ < 3):
                    auxiliaryCounter1 = 3;
                    auxiliaryCounter2 = 0;
                    break;

                case var expression when ((IndexI >= 3 && IndexI < 6) && (IndexJ >= 3 && IndexJ < 6)):
                    auxiliaryCounter1 = 3;
                    auxiliaryCounter2 = 3;
                    break;

                case var expression when ((IndexI >= 3 && IndexI < 6) && IndexJ >= 6):
                    auxiliaryCounter1 = 3;
                    auxiliaryCounter2 = 6;
                    break;

                case var expression when (IndexI >= 6 && IndexJ < 3):
                    auxiliaryCounter1 = 6;
                    auxiliaryCounter2 = 0;
                    break;

                case var expression when (IndexI >= 6 && (IndexJ >= 3 && IndexJ < 6)):
                    auxiliaryCounter1 = 6;
                    auxiliaryCounter2 = 3;
                    break;

                case var expression when (IndexI >= 6 && IndexJ >= 6):
                    auxiliaryCounter1 = 6;
                    auxiliaryCounter2 = 6;
                    break;
            }
        }
    }
}
