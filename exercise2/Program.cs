 int a, b, c, max;
  Console.WriteLine("Введите три числа : ");
 
 a = Convert.ToInt32(Console.ReadLine());
 b = Convert.ToInt32(Console.ReadLine());
 c = Convert.ToInt32(Console.ReadLine());

if (a>b & a>c)
{
    max = a;
}
else if (b>c)
{
    max = b;
}
else
{
    max = c;
}

Console.WriteLine(max);
