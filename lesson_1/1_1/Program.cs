int a = 0;
int b = 0;

Console.Write("Введите значение a = ");
a = int.Parse(Console.ReadLine());

Console.Write("Введите значение b = ");
b = int.Parse(Console.ReadLine());

if((b * b) == a)
{
  Console.WriteLine("да");
}
else
{
  Console.WriteLine("нет");
}