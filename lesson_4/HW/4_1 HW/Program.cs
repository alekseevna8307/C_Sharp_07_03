Console.Write("Enter number1 -> ");
int A = int.Parse(Console.ReadLine()!);

Console.Write("Enter number2 -> ");
int B = int.Parse(Console.ReadLine()!);

int Exponentiate(int A, int B)
{
  int prod = 1;
  for (int i = 1; i <= B; i++)
  {
    prod *= A;
  }
  return prod;
}

int res = Exponentiate(A, B);
Console.WriteLine(res);
