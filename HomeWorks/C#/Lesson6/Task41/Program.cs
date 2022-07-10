void PositiveNumbersCount(int count)
{
    Console.Write($"Введите число, для выхода из программы введите ноль ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number != 0)
    {
        if (number > 0) count ++;
       
        Console.WriteLine($"Количество введеных чисел больше нуля {count}");
        PositiveNumbersCount(count);
    }
}
PositiveNumbersCount(0);