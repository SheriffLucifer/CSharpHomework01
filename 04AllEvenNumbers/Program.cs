Console.Write("Введите любое целое число: ");
string input = Console.ReadLine() ?? "";

int n = int.Parse(input);

int count = 2;
Console.Write($"{n} -> ");

while (count < n - 1)
{
    Console.Write($"{count}, ");
    count += 2;
}
if (n >= 2)
{
    Console.Write(count);
}
else
{
    Console.Write("Четных чисел нет");
}
