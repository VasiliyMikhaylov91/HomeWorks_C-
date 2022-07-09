double[] ArrayIn(int arraySize)
{
    Console.Write("Введите нижний предел чисел в массиве ");
    int lowLimit = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите верхний предел чисел в массиве ");
    int highLimit = Convert.ToInt32(Console.ReadLine());
    if (highLimit < lowLimit)
    {
        int temp = highLimit;
        highLimit = lowLimit;
        lowLimit = temp;
    }
    double[] inArray = new double[arraySize];
    for (int iIn = 0; iIn < arraySize; iIn++)
    {
        inArray[iIn] = Convert.ToDouble(new Random().Next(lowLimit, highLimit + 1))/Convert.ToDouble(new Random().Next(1, 10));
    }
    return inArray;
}
void ArrayOut(double[] outArray)
{
    Console.Write("[");
    for (int iOut = 0; iOut < outArray.Length; iOut++)
    {
        if (iOut == outArray.Length - 1) Console.WriteLine($"{outArray[iOut]}]");
        else Console.Write($"{outArray[iOut]}, ");
    }
}

Console.Write("Введите количество элементов массива то 1 до N ");
int elementsNumber = Convert.ToInt32(Console.ReadLine());
if (elementsNumber <= 0) Console.WriteLine("Ошибка количества элементов");
else
{
    double[] array = ArrayIn(elementsNumber);
    ArrayOut(array);
    int minElementIndex = 0;
    int maxElementIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > array[maxElementIndex]) maxElementIndex = i;
        if (array[i] < array[minElementIndex]) minElementIndex = i;
    }
    Console.WriteLine($"Разница между минимальным и максимальным элементами {array[maxElementIndex] - array[minElementIndex]}");
}