int num = new Random().Next(1, 1000);

void PrintNumber(int num)
{
  Console.WriteLine(num);
  if (num % 7 == 0 && num % 23 == 0)
  {
    Console.WriteLine("Число кратно одновременно 7 и 23");
  }
  else
  {
    Console.WriteLine("Число некратно одновременно 7 и 23");
  }
}

PrintNumber(num);