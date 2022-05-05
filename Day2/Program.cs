string[] lines = File.ReadAllLines(@"./input.in");

Console.WriteLine("First [1] or Last [2]?");

var choice = Console.ReadLine();

if (choice == "1")
{
    Console.WriteLine(Day2.Day2.First(lines));
}
else if (choice == "2")
{
    Console.WriteLine(Day2.Day2.Last(lines));
}

Console.WriteLine("End of program");