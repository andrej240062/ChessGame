using ClassLib;

namespace ChessGame;

class Program
{
    public static void Main()
    {
        Chess board = new Chess();

        Console.WriteLine(board.ToString());
    }
}