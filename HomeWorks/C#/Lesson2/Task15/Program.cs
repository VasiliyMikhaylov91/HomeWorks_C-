Console.Write("Введите номер дня недели ");
int DayNumber = Convert.ToInt32(Console.ReadLine());
if (DayNumber >= 1 && DayNumber <= 7)
{
    if (DayNumber >= 6) Console.WriteLine("Этот день выходной");

    else Console.WriteLine("Это будний день");
}
else Console.WriteLine("Нет дня с таким номером");