
using static System.Console;

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

 int[] array = MyLib6.CreateArray(5);
 MyLib6.Fill(array);
 Console.WriteLine($"{MyLib6.Print(array)} -->> {MyLib6.SumOfPosirtive(array)}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



WriteLine("Введите коэффициенты первой прямой. k1 = ");
float k1 = float.Parse(ReadLine());

WriteLine("Введите коэффициенты первой прямой. b1 = ");
float b1 = float.Parse(ReadLine());

WriteLine("Введите коэффициенты первой прямой. k2 = ");
float k2 = float.Parse(ReadLine());

WriteLine("Введите коэффициенты первой прямой. b2 = ");
float b2 = float.Parse(ReadLine());

float x = (b2 - b1) / (k1 - k2);

float y = k1 * x + b1;


WriteLine($"\n Координаты пересечения Х = {x} Y = {y}\n");