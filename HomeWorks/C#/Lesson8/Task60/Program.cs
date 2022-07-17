int EnterSiting(string sitingName)
{
    Console.Write("Введите " + sitingName + " ");
    int siting = Convert.ToInt32(Console.ReadLine());
    return siting;
}
int lowElement = 10;
int length = EnterSiting("длинну массива");
int width = EnterSiting("ширину массива");
int height = EnterSiting("высоту массива");
int highStepLimit = 5;
int lowStepLimit = 1;
int[,,] array = new int[length, width, height];
for (int i = 0; i < length; i++)
{
    for (int j = 0; j < width; j++)
    {
        for (int k = 0; k < height; k++)
        {
            lowElement += new Random().Next(lowStepLimit,highStepLimit + 1);
            Console.Write(lowElement + "(" + i + "," + j + "," + k + ")" + "\t");
        }
        Console.WriteLine();
    }
}