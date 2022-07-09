int[] ArrayIn(int arraySize)
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
    int[] inArray = new int[arraySize];
    for (int iIn = 0; iIn < arraySize; iIn++)
    {
        inArray[iIn] = new Random().Next(lowLimit, highLimit + 1);
    }
    return inArray;
}
void ArrayOut(int[] outArray)
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
    int[] array = ArrayIn(elementsNumber);
    ArrayOut(array);
    int honestElementsNumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) honestElementsNumber++;
    }
    Console.WriteLine($"Количество четных элементов в массиве {honestElementsNumber}");
}