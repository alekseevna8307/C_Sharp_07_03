Console.Write("Enter number -> ");
int num = int.Parse(Console.ReadLine()!);

int SumNumber(int num)
{
  int sum = num % 10;
  int count = 0;
  while (num > 0)
  {
    num = num / 10;
    count += 1;
    sum = sum +=num % 10;
  }
  return sum;
}

int res = SumNumber(num);
Console.WriteLine(res);