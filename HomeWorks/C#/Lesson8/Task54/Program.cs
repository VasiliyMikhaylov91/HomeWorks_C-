int EnterSiting(string sitingName)
{
    Console.Write("Введите " + sitingName + " ");
    int siting = Convert.ToInt32(Console.ReadLine());
    return siting;
}
int rowNumber = EnterSiting("Количество строк");
int columnNumber = EnterSiting("Количество столбцов");
int[,] array = new int[rowNumber, columnNumber];
for (int i = 0; i < rowNumber; i++)
{
    for (int j = 0; j < columnNumber; j++)
    {
        array[i, j] = new Random().Next(11);
        Console.Write(array[i, j] + "\t");
        if (j != 0)
        {
            for (int k = j - 1; k >= 0; k--)
            {
                if (array[i, k + 1] < array[i, k])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < rowNumber; i++)
{
    for (int j = 0; j < columnNumber; j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}