﻿ // Известны количество жителей в государстве и площадь его территории. 
// Определить плотность населения в этом государстве.

// Плотность населения равна отношению численности населения к площади территории.

Console.WriteLine("Введите численность населения:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите площадь территории:");
int squ = Convert.ToInt32(Console.ReadLine());

int p = num/squ;
Console.WriteLine("Плотность населения равна {0}", p);
