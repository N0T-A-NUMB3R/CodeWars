using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public string[] StreetFighterSelection(string[][] fighters, int[] position, string[] moves)
    {
        var output = new List<string>();
        foreach (var move in moves)
        {
            switch (move)
            {
                case "up":
                    if (position[0] == 0 && position[1] == 0 || (position[0] == 0 && position[1] == 1) ||
                        (position[0] == 0 && position[1] == 2) ||
                        (position[0] == 0 && position[1] == 3) || (position[0] == 0 && position[1] == 4) ||
                        (position[0] == 0 && position[1] == 5))
                    {
                        output.Add(fighters[position[0]][position[1]]);

                    }
                    else
                    {
                        output.Add(fighters[0][position[1]]);
                        position[0] = position[0] - 1;
                    }
                    break;
                case "down":
                    if (position[0] == 0 && position[1] == 0 || (position[0] == 0 && position[1] == 1) ||
                        (position[0] == 0 && position[1] == 2) ||
                        (position[0] == 0 && position[1] == 3) || (position[0] == 0 && position[1] == 4) ||
                        (position[0] == 0 && position[1] == 5))
                    {
                        output.Add(fighters[1][position[1]]);
                        position[0] = position[0] + 1;
                    }
                    else
                    {
                        output.Add(fighters[1][position[1]]);
                    }

                    break;
                case "left":
                    if (position[0] == 0 && position[1] == 0 || (position[0] == 1 && position[1] == 0))
                    {
                        output.Add(fighters[position[0]][5]);
                        position[1] = 5;

                    }
                    else
                    {
                        output.Add(fighters[position[0]][position[1] - 1]);
                        position[1] = position[1] - 1;
                    }

                    break;
                case "right":
                    if (position[0] == 0 && position[1] == 5 || (position[0] == 1 && position[1] == 5))
                    {
                        output.Add(fighters[position[0]][0]);
                        position[1] = 0;
                    }
                    else
                    {
                        output.Add(fighters[position[0]][position[1] + 1]);
                        position[1] = position[1] + 1;
                    }
                    break;
            }
        }

        return output.ToArray();
    }
}