int CountDig(int num)
{
  int count = 0;
  while (num > 0)
  {
    num = num / 10;
    count += 1;
  }
  return count;
}

Console.Write("Enter number -> ");
int num = int.Parse(Console.ReadLine()!);

int res = CountDig(num);
Console.WriteLine(res);
