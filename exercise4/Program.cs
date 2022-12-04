 Console.WriteLine ("Введите число");
 int N = Convert.ToInt32(Console.ReadLine());

if (N > 1)
{
    int count = 2;
    while (count <= N)
    {
        Console.WriteLine(count);
        count = count +2;
    }
}
else 
{
    Console.WriteLine("Ошибка");
}