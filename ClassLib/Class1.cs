namespace ClassLib;

public class Chess
{
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
 
            if ((row + col) % 2 == 0)
                sb.Append("  ");
            else
                sb.Append("##");
        }
 
        sb.AppendLine("|");
    }
 
    sb.AppendLine(line);
 
    return sb.ToString();
}
}