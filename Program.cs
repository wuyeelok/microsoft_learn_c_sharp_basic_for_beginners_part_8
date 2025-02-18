// See https://aka.ms/new-console-template for more information
var part = "Part 8";
Console.WriteLine($"Hello, World! {part}");

// Version 1
int d = int.MinValue;
int e = 1;

try
{
    long f = checked(d - e);
    Console.WriteLine(f);
}
catch (OverflowException ex)
{
    Console.WriteLine("An overflow occurred: " + ex.Message);
}