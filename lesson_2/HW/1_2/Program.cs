int num = new Random().Next(100, 1000);
Console.WriteLine(num);

int FirstDigit(int num1)
{
  int num1 = num / 100;
  return num1;
}

int SecondDigit(int num2)
{
  int num2 = num % 10;
  return num2;
}

int FindNumber(result)
{
  int result = num1 * 10 + num2;
  return result;
}

void PrintNumber(res)
{
  Console.WriteLine(result);
}

int digit1 = FirstDigit(num1);
int digit2 = SecondDigit(num2);
int res = FindNumber(result);
int PrintNumber(res);