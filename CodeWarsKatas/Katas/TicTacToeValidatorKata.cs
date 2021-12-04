using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public static class TicTacToeValidatorKata
    {
        public static int IsSolved(int[,] board)
        {
            List<int> listOfSums = new List<int>();
            List<int> validGameSums = new List<int>();
            int sum = 0;
            bool gameNotFinished = false;
            bool resultTwo = false;
            bool resultOne = false;
            bool drawGame = false;
            int gameResult = -2;

            for (int c = 0; c < 3; c++)
            {
                for (int l = 0; l < 3; l++)
                {

                    if (board[l, c] == 0)
                    {
                        gameNotFinished = true;
                    }
                    else
                    {
                        validGameSums.Add(board[l, c]);
                    }
                }
                if (validGameSums.Count == 3)
                {
                    foreach (int number in validGameSums) { sum += number; }
                }
                listOfSums.Add(sum);
                validGameSums.Clear();
                sum = 0;
            }
            sum = 0;
            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (board[l, c] != 0)
                    {
                        validGameSums.Add(board[l, c]);
                    }
                    if (validGameSums.Count == 3)
                    {
                        foreach (int number in validGameSums) { sum += number; }
                    }
                }
                listOfSums.Add(sum);
                validGameSums.Clear();
                sum = 0;
            }

            if (board[0, 0] != 0 && board[1, 1] != 0 && board[2, 2] != 0)
            {
                listOfSums.Add(board[0, 0] + board[1, 1] + board[2, 2]);
            }

            if (board[0, 2] != 0 && board[1, 1] != 0 && board[2, 0] != 0)
            {
                listOfSums.Add(board[0, 2] + board[1, 1] + board[2, 0]);
            }

            foreach (int result in listOfSums)
            {
                Console.WriteLine(result);
                if (result == 6)
                {
                    gameNotFinished = false;
                    resultTwo = true;
                    gameResult = 2;
                }
                if (result == 3)
                {
                    gameNotFinished = false;
                    resultOne = true;
                    gameResult = 1;
                }
                else if (resultOne == false && resultTwo == false && gameNotFinished == false)
                {
                    drawGame = true;
                    gameResult = 0;
                }
            }

            if (gameNotFinished == true && resultOne == false && resultTwo == false && drawGame == false)
            {
                gameResult = -1;
            }

            return gameResult;
        }
    }
}
