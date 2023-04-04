void Print(int[,] arr)
{
  int row_size = arr.GetLength(0);
  int col_size = arr.GetLength(1);

  for (int i = 0; i < row_size; i++)
  {
    for (int j = 0; j < col_size; j++)
    {
      Console.Write($"{arr[i, j]} ");
    }
    Console.WriteLine();
  }
  Console.WriteLine();
}

int[,] MassNums(int row, int col, int from, int to)
{
  int[,] arr = new int[row, col];

  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < col; j++)
    {
      arr[i, j] = new Random().Next(from, to + 1);
    }
  }
  return arr;
}

Console.Write("Enter the number of rows: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int columns = int.Parse(Console.ReadLine()!);

Console.Write("Enter the min number of massive: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Enter the max number of massive: ");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(rows, columns, start, stop);
Console.WriteLine();
Print(mass);

////

int[] CountFrequency(int[,] arr, int max)
{
  int[] frequencies = new int[max+1]; /// max+1 так как вылетели за пределы массива

  foreach (int elem in arr)
  {
    frequencies[elem] ++;
  }
  return frequencies;
}

void PrintFrequency(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.WriteLine($"Количество {i} -> {array[i]} ");
  }
Console.WriteLine();
}
int[] freq = CountFrequency(mass,stop);
PrintFrequency(freq);
