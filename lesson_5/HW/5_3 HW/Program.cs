void Print(double[] arr)
{
  int size = arr.Length;

  for (int i = 0; i < size; i++)
  {
    Console.Write($"{arr[i]} ");
  }
  Console.WriteLine();
}

double[] EightMass(int size, int from, int to)
{
  double[] arr = new double[size];

  for (int i = 0; i < size; i++)
  {
    arr[i] = new Random().Next(from, to + 1);
  }
  return arr;
}

double Subtraction(double[] arr)
{
  double max = arr[0];
  double min = arr[0];
  for (int i = 1; i < arr.Length; i++)
  {
    if (arr[i] > max) 
    max = arr[i];

    else if (arr[i] < min) 
    min = arr[i];
  }
  return max-min;
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

double[] mass = EightMass(num, start, stop);
Print(mass);

Console.WriteLine(Subtraction(mass));