Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

if (num < 100)
{
  Console.WriteLine("Third digit not found");
}

else
{
  int count = 1000;
  while (num > count)
  {
    int n = num / 10;
  }
  Console.WriteLine("Third digit = " + num % 10);
}
