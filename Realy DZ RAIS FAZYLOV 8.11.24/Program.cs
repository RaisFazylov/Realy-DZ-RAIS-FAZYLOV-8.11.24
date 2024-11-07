using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realy_DZ_RAIS_FAZYLOV_8._11._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вывести на экран число e (основание натурального логарифма) с точностью до
            // десятых.
            Console.WriteLine("Задание 1");
            double e = Math.E;
            Console.WriteLine($"{e:F1}");
            // Вывести на экран числа 50 и 10 одно под другим.
            Console.WriteLine("Задание 2");
            Console.WriteLine(50);
            Console.WriteLine(10);
            // Составить программу вывода на экран «столбиком» четырех любых чисел.
            Console.WriteLine("Задание 3");
            int n1 = 5;
            int n2 = 15;
            int n3 = 25;
            int n4 = 35;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            // Пользователь вводит число. Выведите на экран число, которое больше введенного
            // на 10.
            Console.WriteLine("Задание 4");
            Console.Write("число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int res = n + 10;
            Console.WriteLine(res);
            // Дана сторона квадрата. Найти его периметр.
            Console.WriteLine("Задание 5");
            Console.Write("Сторона:");
            double st = Convert.ToDouble(Console.ReadLine());
            double p = 4 * st;
            Console.WriteLine(p);
            // Данрадиус окружности. Найти длину окружности и площадь круга.
            Console.WriteLine("Задание 6");
            Console.Write("Радиус: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double dl = 2 * Math.PI * r;
            double s = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("Длина: " + dl);
            Console.WriteLine("Площадь: " + s);
            // Найти значение y=cos(x)
            Console.WriteLine("Задание 7");
            Console.Write("угол: ");
            double ug = Convert.ToDouble(Console.ReadLine());
            double rad = ug * Math.PI / 180;
            double y = Math.Cos(rad);
            Console.WriteLine("cos: " + y);
            // Даныоснования и высота равнобедренной трапеции. Найти ее периметр.
            Console.WriteLine("Задание 8");
            Console.Write("Длина основания верхнего: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Длина основания нижнего: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Высота: ");
            double h = Convert.ToDouble(Console.ReadLine());
            double c = Math.Sqrt(Math.Pow(h, 2) + Math.Pow((b - a) / 2, 2));
            double q = a + b + 2 * c;
            Console.WriteLine("Периметр:" + q);
            // Известна стоимость 1 кг конфет, печенья и яблок. Найти стоимость всей покупки,
            // если купили x кг конфет, у кг печенья и z кг яблок.
            Console.WriteLine("Задание 9");
            Console.Write("стоимость конфет: ");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.Write("стоимость печенья: ");
            double w = Convert.ToDouble(Console.ReadLine());
            Console.Write("стоимость яблок: ");
            double i = Convert.ToDouble(Console.ReadLine());
            Console.Write("количество конфет: ");
            double kk = Convert.ToDouble(Console.ReadLine());
            Console.Write("количество печенья: ");
            double kp = Convert.ToDouble(Console.ReadLine());
            Console.Write("количество яблок: ");
            double ky = Convert.ToDouble(Console.ReadLine());
            double summa = (k * kk) + (w * kp) + (i * ky);
            Console.WriteLine("oбщая стоимость: " + summa);
            // Напишите программу, выводит на экран три строки "Мир", "Труд" и "Май"
            // (кавычки не нужны). Причём сделайте, чтобы выводилось сначала так:
            // МирТруд Май
            // Затем так:
            // Мир
            //    Труд
            //        Май
            Console.WriteLine("Задание 10");
            Console.WriteLine("Мир" + "Труд" + " Май");
            Console.WriteLine();
            Console.WriteLine("Мир");
            Console.WriteLine("\tТруд");
            Console.WriteLine("\t\tМай");
            //  Программа просит пользователя ввести 2 числовые переменные. А после она
            // меняет их местами и выводит результат на экран. Но, так как пользователь может
            // ошибиться, необходимо предусмотреть тот факт, что пользователь может ввести,
            //  например, букву или строку, а так же учесть, что число может быть дробным, и для
            // выделения её дробной части одни используют точку, другие– запятую.
            Console.Write("11задание не сделано");

            //  Программа для подсчета периметра и площади фигур (треугольник,
            // четырехугольник, круг). Пользователь выбирает фигуру, указывает, что программа
            // будет считать– площадь или периметр.Задаётся все необходимые значения, а на
            // основе полученных результатов, программа должна подсчитать, какими могли бы
            // быть периметры или площади остальных фигур.
            Console.Write("12задание не сделано");
            // Составить программу вывода на экран числа, вводимого с клавиатуры. Вводимому
            // числу должно предшествовать сообщение «Вы ввели число».
            Console.WriteLine("Задание 13");
            Console.Write("число: ");
            string z = Console.ReadLine();
            Console.WriteLine("Вы ввели число: " + z);
            //  Составить программу вывода на экран следующей информации:
            // 2 кг
            // 13 17
            Console.WriteLine("Задание 14");
            Console.WriteLine("2 кг");
            Console.WriteLine("13 17");
            // Составить программу вывода на экран «столбиком» четырех случайных чисел.
            Console.WriteLine("Задание 15");
            Random j = new Random();
            for (int l = 0; l < 4; l++)
            {
                int v = j.Next(1, 101);
                Console.WriteLine(v);
            }
            // Найти корни квадратного уравнения(коэффициента задаются пользователем с
            // клавиатуры)
            Console.WriteLine("Задание 16 не сделано");

            // Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее
            // геометрическое.
            Console.WriteLine("Задание 17");
            Console.Write("первое число: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("второе число: ");
            int number2 = int.Parse(Console.ReadLine());
            double ar = (number1 + number2) / 2.0;
            double geom = Math.Sqrt(number1 * number2);
            Console.WriteLine("арифметическое: " + ar);
            Console.WriteLine("геометрическое: " + geom);
            // Известны координаты на плоскости двух точек. Составить программу вычисления
            // расстояния между ними.
            Console.WriteLine("Задание 18");
            // Составить программу обмена значениями трех переменных величин а, b, c по
            // следующим двум схемам:
            // а) b присвоить значение c, а присвоить значение b, с присвоить значение а;
            // б) b присвоить значение а, с присвоить значение b, а присвоить значение с.
            Console.WriteLine("Задание 19");
            Console.Write("a: ");
            int aa= int.Parse(Console.ReadLine());
            Console.Write("b: ");
            int bb= int.Parse(Console.ReadLine());
            Console.Write("c: ");
            int cc= int.Parse(Console.ReadLine());
            Console.WriteLine("\nСхема а:");
            int Q =aa;
            int W =bb;
            int E =cc;
            int R =aa;
            int T =bb;
            int Y =cc;
            Console.WriteLine($"a = {W}, b = {E}, c = {Q}");
            Console.WriteLine($"a = {Y}, b = {R}, c = {T}");
            // С начала суток прошло n секунд. Определить:
            // а) сколько полных часов прошло с начала суток;
            // б) сколько полных минут прошло с начала очередного часа;
            // в) сколько полных секунд прошло с начала очередной минуты.
            Console.WriteLine("Задание 20");
            Console.Write("количество секунд: ");
            int N = int.Parse(Console.ReadLine());
            int C = N / 3600;
            int sec = N % 3600;
            int M = sec / 60;
            int S = sec % 60;
            Console.WriteLine("часы: " + C);
            Console.WriteLine("минуты: " + M);
            Console.WriteLine("секунды: " + S);
            // Дан прямоугольник с размерами 543 х 130 мм. Сколько квадратов со стороной 130
            // ммможно отрезать от него?
            Console.WriteLine("Задание 21");
            int g = 543;
            int f = 130;
            int H= 130;
            int ks= g /H;
            int kh = f /H;
            int kol = ks* kh;
            Console.WriteLine(kol);
            // Дано трехзначное число. В нем зачеркнули последнюю справа цифру и приписали
            // ее в начале.Найти полученное число.
            Console.WriteLine("Задание 22");
            Console.Write("число: ");
            int L = int.Parse(Console.ReadLine());
            int P = L % 10;
            int F = (L / 10) % 10;
            int aw= L / 100;
            int nw = P * 100 + aw* 10 + F;
            Console.WriteLine(nw);
            // Дано натуральное число n (n > 999). Найти:
            // а) число сотен в нем;
            // б) число тысяч в нем.
            Console.WriteLine("Задание 23");
            Console.Write("число n: ");
            int ww= int.Parse(Console.ReadLine());
            int wc= (ww/ 100) % 10;
            int t = (ww% 1000000) / 1000;
            Console.WriteLine($"сотни{wc}");
            Console.WriteLine($"тысячи {t}");
            // Дано четырехзначное число. Найти:
            // а) число, полученное при прочтении его цифр справа налево;
            // б) число, образуемое при перестановке первой и второй, третьей и четвертой цифр
            // заданного числа.Например, из числа 5434 получить 4543, из числа 7048 — 784;
            // в) число, образуемое при перестановке второй и третьей цифр заданного числа.
            // Например, из числа 5084 получить 5804;
            // г) число, образуемое при перестановке двух первых и двух последних цифр
            // заданного числа.Например, из числа 4566 получить 6645, из числа 7304 — 473.
            Console.WriteLine("Задание 24");
            Console.Write("число: ");
            int num = int.Parse(Console.ReadLine());
            int d = num % 10; 
            int cq= (num / 10) % 10; 
            int bq=(num / 100) % 10;
            int aq= (num / 1000) % 10;
            int re = d * 1000 + cq * 100 + bq * 10 + aq;
            Console.WriteLine($"A: {re}");
            int sw = bq* 1000 + aq* 100 + d * 10 + cq;
            Console.WriteLine($"B: {sw}");
            int swa = aq* 1000 + cq* 100 + bq* 10 + d;
            Console.WriteLine($"C: {swa}");
            int sap = cq * 1000 + d * 100 + aq* 10 + bq;
            Console.WriteLine($"D: {sap}");
            //  Из трехзначного числа x вычли его последнюю цифру. Когда результат разделили
            // на 10, а к частному слева приписали последнюю цифру числа x, то получилось
            // число n. Найти число x.Значение n вводится с клавиатуры, 100 ≤ n ≤ 999 и при этом
            // число десятков в n не равно нулю.
            Console.Write("25задание не сделано");
        }
    }
}
