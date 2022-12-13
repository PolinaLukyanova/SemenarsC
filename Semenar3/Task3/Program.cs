// Задача 21. Напишите программу, которая 
// принимает на ввод координаты двух точек
// и находит расстояние между ними в 2D пространстве.

// A (3 , 6); B (2, 1) ->5,09
// A (7, -5); B (1, -1) ->7,21 

Console.Clear();
Console.Write("Введите координату x1: ");
double x1 =Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату y1: ");
double y1 =Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату x2: ");
double x2 =Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату y2: ");
double y2 =Convert.ToDouble(Console.ReadLine());

// double dist = Math.Sgrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
// строку можно записать короче используя метот Math.Pow(указываем что возводим в степень, в какую степень) - возводит число в степень
double dist = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));  
Console.WriteLine(Math.Round(dist, 2)); // Math.Round(..., 2) - округляет число после запятой до 2х знаков

