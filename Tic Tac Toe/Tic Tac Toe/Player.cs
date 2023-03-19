using System.Diagnostics.SymbolStore;
using Tic_Tac_Toe;

namespace Tic_Tac_Toe;

public class Player
{
    public Board board;
    public char symbol;
    public bool didPlay;
    
    public Player(Board board1, char symbol1)
    {
        board = board1;
        symbol = symbol1; //Character that will be used to represent that players moves.
        didPlay = false;
    }

    public void Play()
    {
        char choiceChar = char.Parse(Console.ReadLine()); //Waits for users input
        int choiceInt = (int)char.GetNumericValue(choiceChar);
        
        //DEBUG LINES:
        // Console.WriteLine("Choice INT:");
        // Console.WriteLine(choiceInt);
        // Console.WriteLine("ChoiceChar:");
        // Console.WriteLine(choiceChar);
        // Console.WriteLine("is VALID:");
        // Console.WriteLine(board.IsValidMove(choiceChar));
        
        if (board.IsValidMove(choiceChar)) 
        {
            board.UpdateBoard(choiceInt, symbol); //Play their option if available
            didPlay = true; //this boolean will ensure that the player only plays if it is their turn
        }
        else
        {
            didPlay = false;
            Console.WriteLine("INVALID MOVE - TRY AGAIN");
        }
    }
}