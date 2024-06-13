using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TicTacToe;

public class Board
{
    private const int BOARD_SIZE = 9;
    private char[] gameBoard;

    public Board()
    {
        gameBoard = new char[BOARD_SIZE];
        LoadGameBoard();
    }
    private void LoadGameBoard()
    {
        int asciiOffset = 48;
        for (int i = 0; i < BOARD_SIZE; i++)
        {
            gameBoard[i] = (char)(i + 1 + asciiOffset);
        }
    }

    public char GetCharAtIndex(int index)
    {
        if(index >= 0 && index < gameBoard.Length)  
            return gameBoard[index];

        return '9';
    }

    public void SetCharAtIndex(int index, char c)
    {
        if (index >= 0 && index < gameBoard.Length)
        {
            if (gameBoard[index] == ' ' && (c == 'O' || c == 'X'))
            {
                gameBoard[index] = c;
            }
            else
            {
                Console.WriteLine($"Position occurpied or invalid character, cannot set {c} at index {index}");
                Console.WriteLine($"Current character at {index} is {gameBoard[index]}");
            }
        }
        else
        {
            Console.WriteLine($"Index out of bounds, cannot set {c} at index {index}");
        }
    }


    public void PrintBoard()
    {
        Console.WriteLine("=============");
        Console.WriteLine("| {0} | {1} | {2} |", gameBoard[0], gameBoard[1], gameBoard[2]);
        Console.WriteLine("| {0} | {1} | {2} |", gameBoard[3], gameBoard[4], gameBoard[5]);
        Console.WriteLine("| {0} | {1} | {2} |", gameBoard[6], gameBoard[7], gameBoard[8]);
        Console.WriteLine("=============");
    }
}
