void Quarters(int x, int y)
{
  if (x > 0 && y > 0)
  {
    Console.WriteLine($"Значения переменных находятся в пределах первой четверти");
  }
  else if (x < 0 && y > 0)
  {
    Console.WriteLine($"Значения переменных находятся в пределах второй четверти");
  }
  else if (x < 0 && y < 0)
  {
    Console.WriteLine($"Значения переменных находятся в пределах третьей четверти");
  }
  else if (x > 0 && y < 0)
  {
    Console.WriteLine($"Значения переменных находятся в пределах четвертой четверти");
  }
  else if (x == 0 || y == 0)
  {
    Console.WriteLine($"Значения переменных введены некорректно");
  }
}
Console.Write("Введите число: ");
int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
Quarters(num1, num2);