Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

if (num < 100)
{
  Console.WriteLine("Third digit not found");
}

else
{
  while (num > 999)
  {
   num = num / 10;
  }
  Console.WriteLine("Third digit = " + num % 10);
}
