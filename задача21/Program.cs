﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты x первой точки ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты y первой точки ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты z первой точки ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты x второй точки ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты y второй точки ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты z второй точки ");
int z2 = Convert.ToInt32(Console.ReadLine());


double ab = Math.Sqrt(Math.Pow((x1-x2),2) + Math.Pow((y1-y2),2) + Math.Pow((z1-z2),2));

Console.WriteLine(Math.Round(ab,3));

