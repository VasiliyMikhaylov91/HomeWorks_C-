int EnterSiting(string sitingName)
{
    Console.Write("Введите " + sitingName + " ");
    int siting = Convert.ToInt32(Console.ReadLine());
    return siting;
}
int SummBetween(int minNumber, int maxNumber)
{
    if (maxNumber == minNumber) return minNumber;
    else return minNumber + SummBetween(minNumber + 1, maxNumber);

}

int firstNumber = EnterSiting("Первое число");
int secondNumber = EnterSiting("Второе число");
if(firstNumber > secondNumber)
{
    int temp = firstNumber;
    firstNumber = secondNumber;
    secondNumber = temp;
}

Console.WriteLine($"Сумма элементов между {firstNumber} и {secondNumber} равна {SummBetween(firstNumber, secondNumber)}");