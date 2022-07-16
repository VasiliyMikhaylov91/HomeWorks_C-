Console.Clear();
Console.Write("Введите количество строк в массиве ");
int rowsNumbers = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве ");
int columnsNumbers = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rowsNumbers, columnsNumbers];

double[] resultArray = new double[array.GetLength(1)];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(-10, 11);
        Console.Write(array[i, j] + "\t");
        resultArray[j] += Convert.ToDouble(array[i, j]) / array.GetLength(0);
    }
    Console.WriteLine();
}


Console.WriteLine("Среднее арифметическое по столбцам");
Console.WriteLine(string.Join("; ", resultArray));