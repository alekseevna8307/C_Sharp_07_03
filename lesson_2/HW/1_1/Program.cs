int TakeNum(int num)
{
  Console.WriteLine(num);
  int n = num / 10;
  return n % 10;
}
int sec_num = new Random().Next(100, 1000);
int result = TakeNum(sec_num);
Console.WriteLine(result);