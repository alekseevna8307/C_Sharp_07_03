﻿void Print(int[] arr)
{
  int size = arr.Length;

  for (int i = 0; i < size; i++)
  {
    Console.Write($"{arr[i]} ");
  }
  Console.WriteLine();
}

int[] EightMass(int size)
{
  int[] arr = new int[size];

  for (int i = 0; i < size; i++)
  {
    arr[i] = new Random().Next(100, 1000);
  }
  return arr;
}

int CountChet(int[] arr)
{
  int count = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] % 2 == 0)
      count++;
  }
  return count;
}

int num = int.Parse(Console.ReadLine()!);

int[] mass = EightMass(num);
Print(mass);

Console.WriteLine(CountChet(mass));
