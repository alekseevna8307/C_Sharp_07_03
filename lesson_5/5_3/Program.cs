void Print(int[] arr)
{
  int size = arr.Length;

  for (int i = 0; i < size; i++)
  {
    Console.Write($"{arr[i]} ");
  }
  Console.WriteLine();
}

int[] EightMass(int size, int from, int to)
{
  int[] arr = new int[size];

  for (int i = 0; i < size; i++)
  {
    arr[i] = new Random().Next(from, to + 1);
  }
  return arr;
}

int[] ProdNumber(int[] arr)
{
  int arrLeng = arr.Length;
  int[] pairs = new int[arrLeng / 2 + arrLeng % 2];

  for (int i = 0; i < arrLeng / 2; i++)
  {
    pairs[i] = arr[i] * arr[arrLeng - i - 1];
  }

  if (arrLeng % 2 == 1)  // остаток от деления на 2 может быть равен либо 0 либо 1.
  {
    pairs[pairs.Length - 1] = arr[arrLeng / 2];
  }
  return pairs;
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = EightMass(num, start, stop);
Print(mass);
int[] pairsArr = ProdNumber(mass);
Console.WriteLine();
Print(pairsArr);



