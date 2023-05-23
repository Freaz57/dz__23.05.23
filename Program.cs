// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// // 456 -> 5
// // 782 -> 8
// // 918 -> 1

// Console.WriteLine("Введите число");

// int num1 = Convert.ToInt32(Console.ReadLine());

// int sum = num1 / 10;


// int result = sum % 10;

// Console.WriteLine(result);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число");

// int num1 = Convert.ToInt32(Console.ReadLine());



// int sum = num1 / 10;
// int sum2 = sum % 10;

// int sum3 = num1 / 100;
// int sum4 = sum3 % 10;




// if ((num1 > 100) && (num1 < 1000)) 
// {
// Console.WriteLine(sum2);
// } 
// else if ((num1 > 10000) ) {
// Console.WriteLine(sum4);
// }


// else {
//     Console.WriteLine($" {sum} третий цифры нет ");
// };


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите число");

// int num1 = Convert.ToInt32(Console.ReadLine());

// if ((num1 == 6) ||(num1 == 7) )
// {
//     Console.WriteLine($" {num1} Выходной ");
// } else {
//     Console.WriteLine($" {num1} Не выходной ");
// }