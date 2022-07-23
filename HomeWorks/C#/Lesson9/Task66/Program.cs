int EnterSiting(string sitingName)
{
    Console.Write("Введите " + sitingName + " ");
    int siting = Convert.ToInt32(Console.ReadLine());
    return siting;
}
int SummBetween(int minNumber, int maxNumber, int summ = 0)
{
    if (maxNumber == minNumber) return summ += minNumber;
    else return SummBetween(minNumber + 1, maxNumber, summ += minNumber);

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