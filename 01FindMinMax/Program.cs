Console.Write("Введите любое целое число: ");
string input1 = Console.ReadLine() ?? "";

Console.Write("Введите любое целое число: ");
string input2 = Console.ReadLine() ?? "";

int a = int.Parse(input1);
int b = int.Parse(input2);

if (a > b)
{
    Console.WriteLine($"a = {a}, b = {b} -> max = {a}");
}
else
{
    Console.WriteLine($"a = {a}, b = {b} -> max = {b}");
}