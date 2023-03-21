int Multiply(int num)
{
  int mult = 1;
  for (int i = 1; i <= num; i++)
  {
    mult *= i;
  }
  return mult;
}

Console.Write("Enter number -> ");
int number = int.Parse(Console.ReadLine()!);

int res = Multiply(number);
Console.WriteLine(res);
