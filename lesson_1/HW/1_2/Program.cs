Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите число: ");
int b = int.Parse(Console.ReadLine()!);

Console.Write("Введите число: ");
int c = int.Parse(Console.ReadLine()!);

int max = a;

if (a > max) 
max = a;

else if (b > max) 
max = b;

else if (c > max) 
max = c;

else 
{
  Console.Write("Введены одинаковые числа ");
}
  
Console.Write("max = ");
Console.WriteLine(max);