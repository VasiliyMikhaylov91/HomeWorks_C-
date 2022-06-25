Console.Clear();
Console.Write("Введите целое число a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число b = ");
int b = Convert.ToInt32(Console.ReadLine());
int min = a;
int max = b;

if (a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}

Console.WriteLine("Минимальное из чисел " + min);
Console.WriteLine("Максимальное из чисел " + max);