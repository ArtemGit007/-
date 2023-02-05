 // Найти сумму членов арифметической прогрессии, если известны ее первый член, 
// знаменатель и число членов прогрессии.

Console.WriteLine("Ведите первое чиcло мат. прогрессии:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( "Введите количество членов прогрессии:");
int numbers = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите разность прогресии:");
int d = Convert.ToInt32(Console.ReadLine()); 

// Формула вычисления суммы через первое число, количество чисел прогрессии и 
// дельту.   S = (2a + d(numbers - 1))/2 * numbers.

int sum = ((2 * a) + d*(numbers - 1))/2 * numbers;

Console.WriteLine(sum);
