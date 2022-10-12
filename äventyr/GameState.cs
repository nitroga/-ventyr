using System;
using System.Linq;

public class GameState
{
    public Room CurrentRoom {get; set;}
    public List<Item> Inventory = new List<Item>();
    public (int, int ) cordinats = (2, 2);
    public GameState() {
        
    }
    public void ParseUserInput() {
        Console.WriteLine("Vad vill du göra?");
        string? input = Console.ReadLine().ToLower();
        if (input.Contains("gå")) {
            if (input.Contains("vänster")) {
                Console.WriteLine("Du går vänster");
                cordinats.Item1--;
            }
            else if(input.Contains("höger")) {
                Console.WriteLine("Du går höger");
                cordinats.Item1++;
            }
            else if(input.Contains("framåt")) {
                Console.WriteLine("Du går framåt");
                cordinats.Item2--;
            }
            else if(input.Contains("bakåt")) {
                Console.WriteLine("Du går bakåt");
                cordinats.Item2++;
            }
            else {
                Console.WriteLine("Jag förstår inte vart du vill gå");
            }
            if (cordinats.Item1 == 0) {
                cordinats.Item1 = 3;
            }
        }
    }
}
