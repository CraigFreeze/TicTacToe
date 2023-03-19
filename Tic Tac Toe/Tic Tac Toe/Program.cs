// See https://aka.ms/new-console-template for more information

using Tic_Tac_Toe;

Console.WriteLine("Hello, World!");

Board board = new Board();
Player player1 = new Player(board, 'X');
Player player2 = new Player(board, 'O');

// Game Loop
while (true)
{
    //Console.WriteLine("ENTER GAME LOOP");
    while (player1.didPlay == false)
    {
        board.PrintBoard();
        Console.WriteLine("PLAYER 1's Turn");
        Console.WriteLine("Type the Number that corresponds to where you want to play: ");
        player1.Play();
    }
    player1.didPlay = false; // prepares the player to be allowed to play next turn

    //Checks if the game is over
    if (board.IsWin() != 0)
    {
        break; //if it is over, exit the while loop
    }

    while (player2.didPlay == false)
    {
        board.PrintBoard();
        Console.WriteLine("PLAYER 2's Turn");
        Console.WriteLine("Type the Number that cooresponds to where you want to play: ");
        player2.Play();
    }
    player2.didPlay = false; // prepares the player to be allowed to play next turn
    
    //Checks if the game is over
    if (board.IsWin() != 0)
    {
        break; //if it is over, exit the while loop
    }
}

Console.WriteLine("--------- GAME OVER ---------");

board.PrintBoard();
// Console.WriteLine("win: ");
// Console.WriteLine(board.IsWin());
if (board.IsWin() == -1)
{
    Console.WriteLine("TIE GAME");
}
else
{
    Console.WriteLine("GOOD GAME!");
    Console.WriteLine("Player that played \"" + board.winChar + "\" won!");
}

var firstCelebration = new Celebration();
firstCelebration.multiplicand = 2;
firstCelebration.multiplier = 2;
firstCelebration.text = "Structs and Unions are neat!";
Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < firstCelebration.multiplicand * firstCelebration.multiplier; i++)
{
    Console.WriteLine(firstCelebration.text);
}

//EXAMPLE USING STRUCTURES:
public struct Celebration
{
    public int multiplicand, multiplier;
    public string text;
}