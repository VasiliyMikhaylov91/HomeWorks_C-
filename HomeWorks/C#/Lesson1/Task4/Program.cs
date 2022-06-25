Console.Clear();
Console.Write("Введите целое число a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число b = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число c = ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (b > max)
{max = b;}
if (c > max)
{max = c;}

Console.WriteLine("Максимальное из чисел " + max);