string[] lines = File.ReadAllLines(@"C:\Users\loujo\Documents\Advent of Code\Day3\input.in");

Console.WriteLine("First [1] or Last [2]?");

var choice = Console.ReadLine();

if (choice == "1")
{
    Console.WriteLine(Day3.Day3.First(lines));
}
else if (choice == "2")
{
    Console.WriteLine(Day3.Day3.Last(lines));
}

Console.WriteLine("End of program");