﻿//
// Домашнее задание к занятию 7. Методы
//
// Задача 2. ДСоздать метод для вычисления объема и площади поверхности куба по длине его ребра.
// и площади поверхности куба по длине его ребра.
//
Console.WriteLine();
// Вводим сторону куба а
Console.Write("Введите сторону куба а: ");
int a = Convert.ToInt32(Console.ReadLine());
// Вводим переменные для объема и площади
double V, S;
// Считаем объем и площадь куба при помощи метода
GetVS(a,out V, out S);
Console.WriteLine();
// Выводим результат
Console.WriteLine("Объем куба со стороной {1} равен {0:f2}",V, a);
Console.WriteLine("Площадь сторон куба со стороной {1} равна {0:f2}", S,a);
// Создаем метод для вычисления объема и площади поверхности куба по длине его ребра
static void GetVS(int a, out double V, out double S)
{
    V = Math.Pow (a,3);
    S = 6*Math.Pow(a, 2);
}
Console.WriteLine();
// Завершение программы
Console.Write("Для завершения программы нажмите любую клавишу");
Console.ReadKey();