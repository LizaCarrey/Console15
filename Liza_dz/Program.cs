﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1. Обработать тестовое задание по информатике. На экран вывести вопрос и три варианта ответа,
            //ввести с экрана вариант ответа. Программа должна оценить ответ и в случае неправильного ответа написать правильный.

            //Console.WriteLine("Какой символ используется для комментариев в языке программирования C#?");
            //Console.WriteLine("1. // \n2. ** \n3. --");
            //Console.Write("Введите номер ответа: ");
            //int a = int.Parse(Console.ReadLine());
            //if (a == 1)
            //{
            //    Console.WriteLine("Верно!");
            //}
            //else
            //{
            //    Console.WriteLine("Неверно. Правильный ответ: 1. //");
            //}

            //2. Написать программу вычисления стоимости переговоров, если по субботам и воскресеньям предоставляется 20% скидка.
            //Ввести продолжительность разговора и день недели (цифра от 1 до 7).

            //Console.WriteLine("Введите продолжительность разговора в минутах: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите день недели, когда вы звонили: ");
            //int b = int.Parse(Console.ReadLine());
            //int c = 20; //стоимость переговоров за минуту
            //int price = c * a;
            //int skidka = 0;

            //if (b == 6 || b == 7)
            //{
            //    skidka = (price * 20) / 100;
            //}
            //price -= skidka;

            //Console.WriteLine($"Стоимость переговоров: {price}");



            //3. Написать программу для определения времени суток по данному текущему времени и вывести сообщение
            //(утро – с 6 до 12, день – с 12 до 18, вечер – с 18 до 24, ночь – с 0 до 6).

            //Console.Write("Введите текущее время: ");
            //int a = int.Parse(Console.ReadLine());

            //if (a >= 6 && a < 12)
            //{
            //    Console.WriteLine("Утро");
            //}
            //if (a >= 12 && a < 18)
            //{
            //    Console.WriteLine("День");
            //}
            //if (a >= 18 && a < 24)
            //{
            //    Console.WriteLine("Вечер");
            //}
            //if (a >= 0 && a < 6)
            //{
            //    Console.WriteLine("Ночь");
            //}



            //4. Рейтинг бакалавра заочного отделения при поступлении в магистратуру определяется средним баллом по диплому,
            //умноженным на коэффициент стажа работы по специальности, который равен: нет стажа – 1, меньше 2 лет – 13,
            //от 2 до 5 лет – 16. Составить программу расчета рейтинга при заданном среднем балле диплома (от 3 до 5)
            //и вывести сообщение о приеме в магистратуру при проходном балле 45.

            //Console.WriteLine("Введите средний балл (от 3 до 5): ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите свой стаж работы: ");
            //int b = int.Parse(Console.ReadLine());
            //int c = 1;

            //if (b == 1)
            //{
            //    c = 13;
            //}
            //else if (b <= 5)
            //{
            //    c = 16;
            //}

            //int f = a * c;
            //if (f >= 45)
            //{
            //    Console.WriteLine("Приняты в магистратуру");
            //}
            //else
            //{
            //    Console.WriteLine("Вы не приняты в магистратуру");
            //}



            //5. Написать программу , которая по дате рождения (день d месяц n) определяет знак Зодиака:
            //с 22 марта по 21 апреля - Овен (4); с 22 апреля по 21 мая - Телец (5); с 22 мая по 21 июня - Близнецы (6);
            //с 22 июня по 21 июля - Рак (7); с 22 июля по 21 августа - Лев (8); с 22 августа по 21 сентября - Дева (9);
            //с 22 сентября по 21 октября - Весы (10); с 22 октября по 21 ноября - Скорпион (11); с 22 ноября по 21 декабря - Стрелец (12);
            //с 22 декабря по 21 января - Козерог (1); 22 января по 21 февраля - Водолей (2); с 22 февраля по 21 марта - Рыбы (3).

            //Console.WriteLine("Введите день, в который вы родились: ");
            //int d = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите месяц рождения: ");
            //int n = int.Parse(Console.ReadLine());

            //Console.Write("Ваш знак зодиака - ");

            //if (d >= 22 & n == 1 || d <= 21 & n == 2)
            //{
            //    Console.WriteLine("водолей");
            //}
            //else if (d >= 22 & n == 2 || d <= 21 & n == 3)
            //{
            //    Console.WriteLine("рыбы");
            //}
            //else if (d >= 22 & n == 3 || d <= 21 & n == 4)
            //{
            //    Console.WriteLine("овен");
            //}
            //else if (d >= 22 & n == 4 || d <= 21 & n == 5)
            //{
            //    Console.WriteLine("телец");
            //}
            //else if (d >= 22 & n == 5 || d <= 21 & n == 6)
            //{
            //    Console.WriteLine("близнец");
            //}
            //else if (d >= 22 & n == 6 || d <= 21 & n == 7)
            //{
            //    Console.WriteLine("рак");
            //}
            //else if (d >= 22 & n == 7 || d <= 21 & n == 8)
            //{
            //    Console.WriteLine("лев");
            //}
            //else if (d >= 22 & n == 8 || d <= 21 & n == 9)
            //{
            //    Console.WriteLine("дева");
            //}
            //else if (d >= 22 & n == 9 || d <= 21 & n == 10)
            //{
            //    Console.WriteLine("весы");
            //}
            //else if (d >= 22 & n == 10 || d <= 21 & n == 11)
            //{
            //    Console.WriteLine("скорпион");
            //}
            //else if (d >= 22 & n == 11 || d <= 21 & n == 12)
            //{
            //    Console.WriteLine("стрелец");
            //}
            //else if (d >= 22 & n == 12 || d <= 21 & n == 1)
            //{
            //    Console.WriteLine("козерог");
            //}



            //6. Написать программу, которая при вводе числа в диапазоне от 1 до 99 добавляет к нему слово "копейка"
            //в правильной форме. Например, 1 копейка, 5 копеек, 42 копейки.

            Console.Write("Введите число(от 1 до 99): ");
            int k = int.Parse(Console.ReadLine());

            if (k % 10 >= 5 || k % 10 <= 0 || k >= 5 && k <= 20)
            {
                Console.WriteLine($"{k} копеек");
            }
            else if (k % 10 == 1)
            {
                Console.WriteLine($"{k} копейка");
            }
            else if (k % 10 >= 2 || k % 10 <= 4)
            {
                Console.WriteLine($"{k} копейки");
            }



            //7. Написать программу, которая после введенного с клавиатуры числа
            //в диапазоне от 1 до 99 дописывает слово «рубль» в правильном падеже.

            Console.Write("Введите число(от 1 до 99): ");
            int m = int.Parse(Console.ReadLine());

            if (m % 10 >= 5 || m % 10 <= 0 || m >= 5 && m <= 20)
            {
                Console.WriteLine($"{m} рублей");
            }
            else if (m % 10 == 1)
            {
                Console.WriteLine($"{m} рубль");
            }
            else if (m % 10 >= 2 || m % 10 <= 4)
            {
                Console.WriteLine($"{m} рубля");
            }






            Console.ReadKey();
        }
    }
}
