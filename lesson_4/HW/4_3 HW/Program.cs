int GenerateNumber()
{
  int number = new Random().Next(0, 1000);
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

void PrintArray(int[] array)
{
  for (int i = 0; i < 8; i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();
}

int[] array = NewArray();
PrintArray(array);