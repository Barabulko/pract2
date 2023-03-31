// See https://aka.ms/new-console-template for more information

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

Console.WriteLine("task 13");

Console.WriteLine("input number:");
string input = Console.ReadLine();

if (input.Length>2) {
    Console.WriteLine(input[2]);
} else{
    Console.WriteLine("Третьей цифры нет");
}