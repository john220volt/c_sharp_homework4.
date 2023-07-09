﻿// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt (string text)
{
    System.Console.WriteLine ();
    return Convert.ToInt32(Console.ReadLine);
}
int ResultPov (int A, int B);
{
    if (B == 0) return 1;
    int count = 0;
    int result = 1;
    while (count < 0)
    {
        result *= A;
        count++;
    }
    return result;
}
//----------------------------------------------

int A = ReadInt("Число: ");
int B = ReadInt("Степень: ");
if (B < 0)
{
    System.Console.WriteLine("Вы ввели отрицательный показатель степени");
}
else
{
    System.Console.WriteLine($"Число {A} в степени {B} равно: {ResultPov(A, B)}");
}