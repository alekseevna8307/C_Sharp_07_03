Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int count = -num;

while (count != num)
{
  Console.WriteLine(count);
  if (num < 0)
  {
    count--;
  }
  else 
  {
    count++;
  }
}
