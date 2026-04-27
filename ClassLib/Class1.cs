using System.Runtime.CompilerServices;

namespace ClassLib;

public class ChessFigure
{

}

public class Chess
{
    public char[,] board = new char[8, 8];

    public Chess()
    {
        for(int i = 0; i < 8; i++)
        {
            board[1, i] = 'b';
            board[6, i] = 'B';
        }
    }
    public override string ToString()
    {
        var sb = new System.Text.StringBuilder();
        int size = 8;

        string line = "+";
        for (int i = 0; i < size; i++)
            line += "--+";

        for (int row = 0; row < size; row++)
        {
            sb.AppendLine(line);

            for (int col = 0; col < size; col++)
            {
                sb.Append("|");

                char figure = board[row, col];

                if(figure != '\0')
                {
                    sb.Append(figure + " ");
                }
                else if ((row + col) % 2 == 0)
                {
                    sb.Append("##");
                }
                else
                {
                    sb.Append("  ");
                }
            }

            sb.AppendLine("|");
        }

        sb.AppendLine(line);

        return sb.ToString();
    }
}