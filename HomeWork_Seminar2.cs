// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// int n = new Random().Next(100,1000);
// System.Console.WriteLine($"Сгенерировано случайное число => {n}");

// int resault  = n/10 - (n/100*10) ;

// System.Console.WriteLine($"Вторая цифра числа {n} => {resault}");






// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 6

// 78 -> третьей цифры нет

// 32679 -> 6

// 75742979834 -> 8

// System.Console.WriteLine("Введите число");

// long n = Convert.ToInt64(Console.ReadLine());

// if (n>=100)
//     {
//         long tempresult = n - (n / 1000 * 1000);
//         long resault  = tempresult / 100;
//         System.Console.WriteLine($"Число {resault} является третим символом справа от числа {n}");
//     }
// else 

//     {
//         System.Console.WriteLine($"Число {n} < 100, введите корректное число");

//     }




////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


// Решение через массив 

// System.Console.WriteLine("Введите число дня недели");

// int numbday = Convert.ToInt32(Console.ReadLine());

// string[] nameday = { "Понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье"};

// if ( numbday>=1 & numbday<=7 )
//     {
//         if (numbday>=1 & numbday<=5)
//         {
//             System.Console.WriteLine($"{numbday} день недели это - {nameday[numbday-1]} => Рабочий день");   
//         }
//         else
//         {
//             System.Console.WriteLine($"{numbday} день недели это - {nameday[numbday-1]} => Ура! Выходной!");
//         }
//     }

// else
//         {
//             System.Console.WriteLine("Введите корректное число");
//         }

// Решение через if-else

// System.Console.WriteLine("Введите число дня недели");

// int numbday = Convert.ToInt32(Console.ReadLine());

// if (numbday>=1 & numbday<=7)
//     {
//         if (numbday>=1 & numbday<=5)
//         {
//             System.Console.WriteLine($"{numbday} => Рабочий день недели");
//         }
//         else
//         {
//          System.Console.WriteLine($"{numbday} => Выходной день");   
//         }
//     }
// else
//     {
//      System.Console.WriteLine("Введите корректное число");   
//     }