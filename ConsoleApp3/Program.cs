Console.Write("Введите число");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите знак операции");
string b = Console.ReadLine();
if (b != "+" && b != "-" && b != "*" && b != "/")
{
    Console.Write("Этот не знак операции с числом");
    Console.Write("Введите знак операции (+, -, *, /): ");
    b = Console.ReadLine();
}
Console.Write("Введите второе число");
int c = int.Parse(Console.ReadLine());

if (b == "+")
{
    Console.WriteLine(a + c);
}
else if (b == "-")
{
    Console.WriteLine(a - c);
}
else if (b == "*")
{
    Console.WriteLine(a * c);
}
else if (b == "/")
{
    if (c == 0)
    {
        Console.WriteLine("Ошибка: деление на ноль!");
    }
    else
    {
        Console.WriteLine(a / c);
    }
}
else
{
    Console.WriteLine("Ошибка: введен неверный знак операции.");
}