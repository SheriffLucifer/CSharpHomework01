Console.Write("Введите любое целое число: ");
string input1 = Console.ReadLine() ?? "";

Console.Write("Введите любое целое число: ");
string input2 = Console.ReadLine() ?? "";

Console.Write("Введите любое целое число: ");
string input3 = Console.ReadLine() ?? "";

int a = int.Parse(input1);
int b = int.Parse(input2);
int c = int.Parse(input3);

if (a > b && a > c)
{
    Console.WriteLine($"{a} {b} {c} -> {a}");
}
else if (b > a && b > c)
{
    Console.WriteLine($"{a} {b} {c} -> {b}");
}
else
{
    Console.WriteLine($"{a} {b} {c} -> {c}");
}