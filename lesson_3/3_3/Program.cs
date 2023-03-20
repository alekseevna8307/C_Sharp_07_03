
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

void SquareNumber(int N)
{
  int i = 1;
  while (i <= N)
  {
    Console.Write(Math.Pow(i, 2) + " ");
    i++;
  }
}

SquareNumber(N);