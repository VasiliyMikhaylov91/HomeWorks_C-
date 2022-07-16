Console.Clear();
Console.Write("Введите количество строк в массиве ");
int rowsNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве ");
int columnsNumber = Convert.ToInt32(Console.ReadLine());
int minLimit = -99;
int maxLimit = 99;

int[,] array = new int[rowsNumber, columnsNumber];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(minLimit, maxLimit);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.Write($"Введите номер строки (не меньше 0 не больше {array.GetLength(0) - 1}) ");
int inRowNumber = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите номер столбца (не меньше 0 не больше {array.GetLength(1) - 1}) ");
int inColumnNumber = Convert.ToInt32(Console.ReadLine());

if (inRowNumber < 0
    || inRowNumber >= array.GetLength(0)
    || inColumnNumber < 0
    || inColumnNumber >= array.GetLength(1))
{
    Console.WriteLine("Такого элемента в массиве нет");
}
else Console.WriteLine($"Число в строке {inRowNumber}, в столбце {inColumnNumber} = {array[inRowNumber, inColumnNumber]}");

Console.Write($"Введите число от {minLimit} до {maxLimit} ");
int userNumber = Int32.Parse(Console.ReadLine());
bool equalFlag = false;
string message = String.Empty;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] == userNumber)
        {
            equalFlag = true;
            message = $"Указанное число найдено в строке {i} столбце {j}";
            break;
        }
    }
}
if (equalFlag) Console.WriteLine(message);
else Console.WriteLine("Указанное число не найдено");