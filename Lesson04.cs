// Задача 29: Напишите программу, которая задаёт массив из N элементов (из диапазона [0-14] ) 
//и выводит на экран десятичное представление числа, записанного в СС по основанию 15
//N: 3 [9, 4, 12] => 2097
//Для проверки можно использовать https://numsys.ru/convert/2097/10/15

//Создание массива
//Заполнение массива числами от 0-14
//Печать массива
//Написать конвектор из 15-ой 10-ую
//
using static Library;
using static System.Console;

public class Lesson04
{
  public static void Task29()
  {
    int[] ar = {9, 4, 12};
    Console.WriteLine(Print(ar));
    int dec = ToDec(ar);
    WriteLine($"{Print(ar)} => {dec}");
  }
}
