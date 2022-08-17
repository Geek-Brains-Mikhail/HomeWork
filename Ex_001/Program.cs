// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите первое число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int res = numberA;
for(int i = 1; i <numberB; i++)
{
    res*=numberA;
}
Console.WriteLine($"число {numberA} в {numberB} степени равно {res}");