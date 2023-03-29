Console.Write("Сколько чисел вы хотите ввести? ");
int size = int.Parse(Console.ReadLine()!);

int[] arr = NewArr(size);
PrintArray(arr);
Console.WriteLine();
Console.WriteLine(CountPosNum(arr));

int[] NewArr(int size)
{
  int[] array = new int[size];

  for (int i = 0; i < size; i++)
  {
    Console.Write("Введите число -> ");
    int num = int.Parse(Console.ReadLine()!);

    array[i] = num;

  }
  return array;
}

void PrintArray(int[] array)
{
  for (int i = 0; i < size; i++)
  {
    Console.Write($"{array[i]} ");
  }
}


int CountPosNum(int[] array)
{
  int count = 0;
  for (int i = 0; i < size; i++)
  {
    if (array[i] > 0)
      count++;
  }
  return count;
}




