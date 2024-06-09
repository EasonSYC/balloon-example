using BalloonExample.Classes;

internal class Program
{
    static Balloon Defend(Balloon balloon)
    {
        string input = string.Empty;
        int opponentStrength;
        while (!int.TryParse(input, out opponentStrength))
        {
            Console.WriteLine("Please input strength of opponent: ");
            input = Console.ReadLine() ?? string.Empty;
        }

        balloon.ChangeHealth(-opponentStrength);

        Console.WriteLine($"Defence item of balloon is: {balloon.GetDefenceItem()}");

        if (balloon.CheckHealth())
        {
            Console.WriteLine($"Balloon does not have health remaining!");
        }
        else
        {
            Console.WriteLine($"Balloon still has health remaining!");
        }

        return balloon;
    }
    static void Main()
    {
        Console.WriteLine("Please input defence item: ");
        string defenceItem = Console.ReadLine() ?? string.Empty;

        Console.WriteLine("Please input balloon colour: ");
        string colour = Console.ReadLine() ?? string.Empty;

        Balloon balloon1 = new(colour, defenceItem);

        balloon1 = Defend(balloon1);
    }
}