// Console.WriteLine($"Введите первое число.");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Введите второе число.");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Введите третье число.");
// int c = int.Parse(Console.ReadLine());

// if ((a<b+c)&&(b<a+c)&&(c<a+b))
// {
//     Console.WriteLine("Может");
// }
// else
// {
//     Console.WriteLine("Не может");
// }

// Console.WriteLine($"Введите число.");
// int num = Convert.ToInt32(Console.ReadLine());

// string result = "";

// while (num>0)
// {
//     result=num%2+result;
//     num=num/2;
// }
// Console.WriteLine(result);

// Console.WriteLine($"Введите число.");
// int num = Convert.ToInt32(Console.ReadLine());

// int firstNum=0;
// int secondNum=1;

// Console.Write(firstNum+" "+secondNum+" ");

// for (int i = 3; i <= num; i++)
// {
//     int newNum=firstNum+secondNum;
//     Console.Write(newNum+ " ");

//     firstNum=secondNum;
//     secondNum=newNum;
// }

// int[] array = new int [] {1,2,3,4,5};

// for (int i = 0; i < array.Length/2; i++)
// {
//     int temp = array[i];
//     array[i]=array[array.Length-1-i];
//     array[array.Length-1-i]=temp;
// }

// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i]+" ");
// }

// !!!ДОМАШНЯЯ РАБОТА!!!

// Задача 41:

// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел 
// больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int posNum=0;
// Console.WriteLine($"Введите размер массива");
// int[] array= new int [Convert.ToInt32(Console.ReadLine())];
// Console.WriteLine("\n"+"Введите массив размером "+ array.Length);
// for (int i = 0; i < array.Length; i++)
// {
//     array[i]= Convert.ToInt32(Console.ReadLine());
// }

// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i]+"|");
// }

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i]>0)
//     {
//         posNum=posNum+1;
//     }
// }
// Console.WriteLine("\n"+"Количество положительных чисел - "+posNum);

// Задача 43:

// Напишите программу, которая найдёт
// точку пересечения двух прямых,
// заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// Console.WriteLine("Введите переменную b1 ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите переменную k1 ");
// int k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите переменную b2 ");
// int b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите переменную k2 ");
// int k2 = Convert.ToInt32(Console.ReadLine());

// int x = -(b1 - b2) / (k1 - k2);
// int y = k1 * x + b1;

// Console.Write($"\n Точка пересечения двух прямых - {x},{y}");
