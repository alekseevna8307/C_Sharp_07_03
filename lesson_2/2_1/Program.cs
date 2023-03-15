﻿int num = GenerateNumber();
PrintNumber(num);
int digit1 = GetFirstDigit(num);
int digit2 = GetSecondDigit(num);
int max = FindMax(digit1, digit2);
PrintNumber(max);

int GenerateNumber()
{
  int num = new Random().Next(10, 100);
  return num;
}

int GetSecondDigit(int n)
{
  return n % 10;
}

int GetFirstDigit(int n)
{
  return n / 10;
}

int FindMax(int n1, int n2)
{
  if (n1 > n2)
  {
    return n1;
  }
  return n2;
}

void PrintNumber(int n)
{
  Console.WriteLine("Your number is: " + n);
}

