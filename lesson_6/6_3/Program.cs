Console.Write("Enter number -> ");
int N = int.Parse(Console.ReadLine()!);
/*
void Fibonacci(int N)
{
  int a = 0;
  int b = 1;
  Console.Write($"{a} {b} ");

  for (int i = 2; i < N; i++)
  {
    Console.Write($"{a + b} ");
    (a, b) = (b, a + b);
  }
}*/

Fibonacci(N);

void Fibonacci(int N)
{
  int a = 0;
  int b = 1;

  for (int i = 0; i < N; i++)
  {
    Console.Write($"{a} ");
    (a, b) = (b, a + b);
  }
}
