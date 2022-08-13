// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        //Calculator
        Console.Write("Enter a number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter another number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(num1 + num2);


        //Mad lib game

        string color, pluralNoun, celebrity;

        Console.Write("Enter a color: ");
        color = Console.ReadLine();

        Console.Write("Enter a pluralnoun: ");
        pluralNoun = Console.ReadLine();

        Console.Write("Enter a celebrity: ");
        celebrity = Console.ReadLine();

        Console.WriteLine("Roses are " + color);
        Console.WriteLine(pluralNoun + " are blue");
        Console.WriteLine("I love " + celebrity);


        // Array

        int[] luckyNumbers = { 4, 8, 17, 18, 20, 25 };

        //string
        string[] friend = new string[5];
        friend[0] = "Pet";
        friend[1] = "Jude";

        Console.WriteLine(luckyNumbers[1]);
        Console.ReadLine();
    }
}




