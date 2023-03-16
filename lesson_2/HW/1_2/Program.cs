int GetDigit(int num)
{
  Console.WriteLine(num);
  int num1 = num / 100;
  int num2 = num % 10;
  int findnum = num1 * 10;
  return findnum + num2;
}
int n = new Random().Next(100, 1000);

int result = GetDigit(n);
Console.WriteLine(result);