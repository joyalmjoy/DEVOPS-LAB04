using Joyal.StringExtensions;

Console.WriteLine("Enter a string:");
string input = Console.ReadLine();

bool result = input.StartsWithUpperCase();

Console.WriteLine($"Starts with uppercase? {result}");