﻿void Print(int[] arr)
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

bool MyFunc(int[] arr, int n)
{
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] == n)
      return true;
  }
  return false;
}


int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = EightMass(num, start, stop);
Print(mass);
Console.WriteLine();

Console.Write("Enter number -> ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(MyFunc(mass, n));

