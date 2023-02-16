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