Console.Write("Enter number 1 -> ");
int n1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter number 2 -> ");
int n2 = int.Parse(Console.ReadLine()!);
Console.Write("Enter number 3 -> ");
int n3 = int.Parse(Console.ReadLine()!);

bool MyFunc(int n1, int n2, int n3)
{
  if(n1 < n2 + n3 && n2 < n1 + n3 && n3 < n1 +n2)
  return true;

  else
  return false;
}

Console.WriteLine(MyFunc(n1, n2, n3));
