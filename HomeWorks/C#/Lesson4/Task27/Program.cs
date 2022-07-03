Console.Write("Введите число ");
string Number = Console.ReadLine();
if (Number.StartsWith("-")) Number = Number.Substring(1);
int Summ = 0;
for (int i = 0; i < Number.Length; i++)
{
    Summ = Summ + Convert.ToInt32(Convert.ToString(Number[i]));
}
Console.WriteLine($"Сумма цифр в числе {Summ}");