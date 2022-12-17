Console.Write("Введите любое целое число: ");
string input = Console.ReadLine() ?? "";

int n = int.Parse(input);

int count = 2;
Console.Write($"{n} -> ");

while (count < n)
{
    Console.Write($"{count}, ");
    count += 2;
}
Console.Write($"{count}");