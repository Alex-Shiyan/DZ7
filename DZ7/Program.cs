//
// Домашнее задание к занятию 7. Методы
//
// Задача 1. Два треугольника заданы длинами своих сторон.
// Определить, площадь какого из них больше
// (создать метод для вычисления  площади  треугольника по длинам его сторон).
// Для решения задачи можно использовать формулу Герона.
//
Console.WriteLine();
int N = 2;                // количество проверяемых треугольников
int[] a = new int[N];     // массив сторон а   
int[] b = new int[N];     // массив сторон b
int[] c = new int[N];     // массив сторон с
// Ввод значений с клавиатуры
// Предполагается, что стороны a, b, c образуют треугольник
for (int i = 0; i < N; i++)
{
    Console.Write("Введите сторону a треугольника {0}, a{0}:  ", i + 1);
    a[i] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Введите сторону b треугольника {0}, b{0}:  ", i + 1);
    b[i] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Введите сторону c треугольника {0}, c{0}:  ", i + 1);
    c[i] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
}
// Вводим массив S, чтобы было куда записывать значения
double[] S = new double[N];
// Вводим счетчики
double maxS = 0;               // для максимальнной площади треугольника
int indX = 0;                  // индекс треугольника с макс. S
// Вычисляем площадь каждого треугольника, выбираем большую
for (int i = 0; i < N; i++)
{
    GetS(a[i], b[i], c[i], out S[i]);
    if (S[i] > maxS)
    {
        maxS = S[i];
        indX = i+1;
    }
    else
    {
        Console.WriteLine("Это не треугольники");
        maxS = 0;
        indX = 0;
        break;
    }
}
// Выводим ответ
Console.WriteLine();
Console.WriteLine("Максимальная площадь у треугольника {1} равняется {0:f2}",maxS, indX);
Console.WriteLine();
// Создаем метод для вычисления площади треугольника по трем сторонам
static void GetS(int a, int b, int c, out double S)
{
    int p = (a + b + c) / 2;
    S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
}

Console.WriteLine();
// Завершение программы
Console.Write("Для завершения программы нажмите любую клавишу");
Console.ReadKey();