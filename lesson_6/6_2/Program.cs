Console.Write("Enter number -> ");
int num = int.Parse(Console.ReadLine()!);

string Change(int num)
{
  string new_num = string.Empty;

  while (num > 0)
  {
    new_num = num % 2 + new_num;
    num /= 2;
  }
  return new_num;
}

Console.WriteLine(Change(num));