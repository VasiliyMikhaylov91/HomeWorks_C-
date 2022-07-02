Console.Clear();
Console.Write("Введите целое число членов последовательности ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень членов последовательности ");
int digree = Convert.ToInt32(Console.ReadLine());
if (number == 0) Console.WriteLine(0);
for (int count = 1; count <= (Math.Abs(number)); count++)
{
    if (number < 0) Console.Write(Math.Pow((count * (-1)), digree) + " ");
    else Console.Write(Math.Pow(count, digree) + " ");
}