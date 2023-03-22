int GenerateNumber()
{
  int number = new Random().Next(0, 2); // можно написать просто Next(2) - так как ноль автоматом берется.
  return number;
}

int[] NewArray()
{
  int[] array = new int[8];

  for (int i = 0; i < 8; i++)
  {
    array[i] = GenerateNumber();
  }
  return array;
}

void PrinArray(int[] arr)
{
    for (int i = 0; i < 8; i++)
  {
    Console.Write($"{arr[i]} ");
  }
  Console.WriteLine();
}

PrinArray(NewArray());

// другой вариант записи вывода функции:
// int[] array = NewArray();
// PrinArray(array);

