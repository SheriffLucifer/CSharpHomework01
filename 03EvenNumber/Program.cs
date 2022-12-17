Console.Write("Введите любое целое число: ");
string input = Console.ReadLine() ?? "";

int number = int.Parse(input);

if ((number % 2) == 0)
{
    Console.WriteLine($"{input} -> yes");
}
else
{
    Console.WriteLine($"{input} -> no");
}