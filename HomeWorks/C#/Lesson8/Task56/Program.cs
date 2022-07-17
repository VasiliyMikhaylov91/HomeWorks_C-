int EnterSiting(string sitingName)
{
    Console.Write("Введите " + sitingName + " ");
    int siting = Convert.ToInt32(Console.ReadLine());
    return siting;
}
int rowNumber = EnterSiting("Количество строк");
int columnNumber = EnterSiting("Количество столбцов");
int[,] array = new int[rowNumber, columnNumber];
int rowSumm = 0;
int lowRowSumm = int.MaxValue;
int lowRowSummIndex = 0;
int lowElemetLimit = 0;
int highElementLimit = 10;
for (int i = 0; i < rowNumber; i++)
{
    for (int j = 0; j < columnNumber; j++)
    {
        array[i, j] = new Random().Next(lowElemetLimit, highElementLimit);
        Console.Write(array[i, j] + "\t");
        rowSumm += array[i,j];
    }
    if (lowRowSumm > rowSumm)
    {
        lowRowSumm = rowSumm; 
        lowRowSummIndex = i;
    }
    rowSumm = 0; 
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {lowRowSummIndex}");