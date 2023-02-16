//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int FindThirdNumber(int value)
{
    int ThirdNumber = 0;
    while (value > 999)
    {
        value = value / 10;
    }
    ThirdNumber = value % 10;
    return ThirdNumber;
}
Console.Write("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());
if (value / 100 == 0)
{
    Console.WriteLine("Третьей цифры нет.");
    return;
}
Console.WriteLine(FindThirdNumber(value));