namespace Tic_Tac_Toe;

public class Board
{
    public char[] boardArray = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    public char winChar;
    public Board()
    {
    }

    public bool IsValidMove(char playLocation)
    {
        int position = Array.IndexOf(boardArray, playLocation);
        //DEBUG LINES
        // Console.WriteLine("playLocation:");
        // Console.WriteLine(playLocation);
        // Console.WriteLine("position:");
        // Console.WriteLine(position);
        if (position > -1)
        {
            return true;
        }
        return false;
    }

    public int IsWin()
    {
        //Winning Condition For First Row
        if (boardArray[0] == boardArray[1] && boardArray[1] == boardArray[2])
        {
            winChar = boardArray[0];
            return 1;
        }
        //Winning Condition For Second Row
        else if (boardArray[3] == boardArray[4] && boardArray[4] == boardArray[5])
        {
            winChar = boardArray[3];
            return 1;
        }
        //Winning Condition For Third Row
        else if (boardArray[6] == boardArray[7] && boardArray[7] == boardArray[8])
        {
            winChar = boardArray[6];
            return 1;
        }
        //Winning Condition For First Column
        else if (boardArray[0] == boardArray[3] && boardArray[3] == boardArray[6])
        {
            winChar = boardArray[0];
            return 1;
        }
        //Winning Condition For Second Column
        else if (boardArray[1] == boardArray[4] && boardArray[4] == boardArray[7])
        {
            winChar = boardArray[1];
            return 1;
        }
        //Winning Condition For Third Column
        else if (boardArray[2] == boardArray[5] && boardArray[5] == boardArray[8])
        {
            winChar = boardArray[2];
            return 1;
        }
        //Winning Condition for Left Diagonal
        else if (boardArray[0] == boardArray[4] && boardArray[4] == boardArray[8])
        {
            winChar = boardArray[0];
            return 1;
        }
        //Winning Condition For Right Diagonal
        else if (boardArray[2] == boardArray[4] && boardArray[4] == boardArray[6])
        {
            winChar = boardArray[2];
            return 1;
        }
        // If all the cells or values filled with X or O then any player has won the match
        else if (boardArray[0] != '1' && boardArray[1] != '2' && boardArray[2] != '3' && boardArray[3] != '4' && boardArray[4] != '5' && boardArray[5] != '6' && boardArray[6] != '7' && boardArray[7] != '8' && boardArray[8] != '9')
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }

    public void UpdateBoard(int playLocation, char playerSymbol)
    {
        boardArray[playLocation - 1] = playerSymbol;
    }

    public void PrintBoard()
    {
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", boardArray[0], boardArray[1], boardArray[2]);
        Console.WriteLine("-----+-----+----- ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", boardArray[3], boardArray[4], boardArray[5]);
        Console.WriteLine("-----+-----+----- ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", boardArray[6], boardArray[7], boardArray[8]);
        Console.WriteLine("     |     |      ");
    }
    
}