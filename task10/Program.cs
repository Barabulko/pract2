// See https://aka.ms/new-console-template for more information

/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

*/

Console.WriteLine("task 10");

Console.WriteLine("write 3-digit number:");

string input = Console.ReadLine();

Console.WriteLine(input[1]);
