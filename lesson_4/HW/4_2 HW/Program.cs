Console.Write("Enter number -> ");
int num = int.Parse(Console.ReadLine()!);

int SumNumber(int num)
{
  int sum = 0;
  
  while (num > 0)
  {
    sum +=num % 10;
    num /= 10;
  }
  return sum;
}

int res = SumNumber(num);
Console.WriteLine(res);