// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumNumber = 0;

if(number> 0)
{
    while(number>0)
    {
        sumNumber+=number%10;
        number=number/10;
    }
}
else if(number < 0)
{
    while(number < 0)
    {
        sumNumber+=number%10;
        number=number/10;
    }
    sumNumber*=-1;
}
else
{
    Console.WriteLine($"Сумма цифр в числе  = 0")         ;
}
Console.WriteLine($"Сумма цифр в числе  = {sumNumber}");