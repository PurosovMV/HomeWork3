/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.WriteLine("Введи через пробел координаты первой точки (x y z):  ");
string[] point1 = Console.ReadLine().Split(' ');
int x1 = Convert.ToInt32(point1[0]);
int y1 = Convert.ToInt32(point1[1]);
int z1 = Convert.ToInt32(point1[2]);
Console.WriteLine("Введи через пробел координаты второй точки (x y z):  ");
string[] point2 = Console.ReadLine().Split(' ');
int x2 = Convert.ToInt32(point2[0]);
int y2 = Convert.ToInt32(point2[1]);
int z2 = Convert.ToInt32(point2[2]);

double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"A ({point1[0]}, {point1[1]}, {point1[2]}); B ({point2[0]}, {point2[1]}, {point2[2]}) ->  {length:f2}");
