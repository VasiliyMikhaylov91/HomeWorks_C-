int EnterSiting(string sitingName)
{
    Console.Write("Введите " + sitingName + " ");
    int siting = Convert.ToInt32(Console.ReadLine());
    return siting;
}
int[,] FillRandomArray (int arrayRowsNumber, int arrayColumnsNumber, int minElementValue, int maxElementValue)
{
    int[,] resultArray = new int[arrayRowsNumber, arrayColumnsNumber];
    for (int i = 0; i < arrayRowsNumber; i++)
    {
        for (int j = 0; j < arrayColumnsNumber; j++)
        {
            resultArray[i, j] = new Random().Next(minElementValue, maxElementValue + 1);
            Console.Write(resultArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return resultArray;
}
void PrintMultArray (int[,] multipleArrayFirst, int[,] multipleArraySecond)
{
    for (int i = 0; i < multipleArrayFirst.GetLength(0); i++)
    {
        for (int j = 0; j < multipleArrayFirst.GetLength(1); j++)
        {
            Console.Write(multipleArrayFirst[i, j] * multipleArraySecond[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int rowsArrayNumber = EnterSiting("Количество строк массива");
int columsArrayNumber = EnterSiting("Количество столбцов массива");
int lowElementLimit = EnterSiting("Нижнее ограничение элементов массива");
int highElementLimit = EnterSiting("Верхнее ограничение элементов массива");
int[,] firstMultipleArray = FillRandomArray(rowsArrayNumber, columsArrayNumber, lowElementLimit, highElementLimit);
Console.WriteLine();
int[,] secondMultipleArray = FillRandomArray(rowsArrayNumber, columsArrayNumber, lowElementLimit, highElementLimit);
Console.WriteLine();
PrintMultArray(firstMultipleArray, secondMultipleArray);