// See https://aka.ms/new-console-template for more information

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("task15");

Console.WriteLine("input weekday:");
string input = Console.ReadLine();
int Day = int.Parse(input);

if (Day>5){
    Console.WriteLine("Yes");
} else {
    Console.WriteLine("No");
}