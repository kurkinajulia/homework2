//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

int ShowSecond(int value)
{
int result = value / 10 % 10;
return result;
}
Console.WriteLine("Введите трёхзначное число: ");

int value = Convert.ToInt32(Console.ReadLine());

if (value < 100 || value > 999)
{
Console.WriteLine("Вы ввели не трёхзначное число, повторите ввод");
return;
}

Console.WriteLine(ShowSecond(value));