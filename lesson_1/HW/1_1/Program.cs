Console.Write("Введите число: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите число: ");
int num2 = int.Parse(Console.ReadLine()!);

if (num1 > num2)
{
    Console.WriteLine(num1);
}
else if (num2 > num1)
{
  Console.WriteLine(num2);
}
else
{
  Console.WriteLine("Введены одинаковые числа");
}