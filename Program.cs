// See https://aka.ms/new-console-template for more information
var part = "Part 8";
Console.WriteLine($"Hello, World! {part}");


double a = 85.142; // Natural type
float b = 14.9F; // float suffix
double c = checked(a + b);  // produce wired result
Console.WriteLine($"a: {a} + b: {b} = c: {c}");


decimal mark = 0.57M;   // Explict fix
decimal pass = 0.6M;
decimal totalMarkPass = checked(mark + pass);
Console.WriteLine($"mark: {mark} + pass: {pass} = totalMarkPass: {totalMarkPass}");

// Calculate the area of a circle
decimal r = 2.5M;
decimal area = checked((decimal)Math.PI * (decimal)Math.Pow((double)r, 2));
area = Math.Round(area, 2); // Round to 2 decimal places
Console.WriteLine($"The area of a circle is {area}");


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