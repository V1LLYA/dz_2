//*** Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. ***//

// Console.WriteLine("Введите трёхзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num < 100){
//     Console.WriteLine($"Число {num} не является трёхзначным");
// } else{
//     int figure = num;
//     figure /= 10;
//     figure %= 10;
//     Console.WriteLine($"Вторая цифра числа {num} является {figure}");
// }

//*** Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. ***//

// Console.WriteLine("Введите трёхзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num < 100){
//     Console.WriteLine($"Число {num} не является трёхзначным");
// } else{
//     int figure = num;
//     figure %= 10;
//     Console.WriteLine($"Вторая цифра числа {num} является {figure}");
// }

//*** Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. ***//

// Console.WriteLine("Введите число, обозначающий день недели от 1 до 7: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num <= 7 && num >= 1){
//     if(num == 6 || num == 7){
//         Console.WriteLine($"День {num} является выходным");
//     } else{
//         Console.WriteLine($"День {num} является будним");
//     }
// } else{
//     Console.WriteLine("Ты читать умеешь? Напиши день от 1 до 7");
// }