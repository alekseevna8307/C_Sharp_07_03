
Console.Write("enter a five-digit number: ");
int num = int.Parse(Console.ReadLine()!);
Palindrome();

void Palindrome()
{
  int n1 = num / 10000;
  int n2 = num / 1000 % 10;
  int n4 = num / 10 % 10;
  int n5 = num % 10;

  if (n1 == n5 && n2 == n4)
  {
    Console.WriteLine("yes");
  }
  else
  {
    Console.WriteLine("no");
  }
}

