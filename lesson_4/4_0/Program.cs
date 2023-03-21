int SumNumber(int num)
{
  int sum_all = 0;
  for (int i = 1; i <= num; i++)
    sum_all += i;
  return sum_all;
}


Console.Write("Enter number -> ");
int A = int.Parse(Console.ReadLine()!);

int result = SumNumber(A);
Console.WriteLine(result);
