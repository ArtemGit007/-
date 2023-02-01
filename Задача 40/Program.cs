// Даны два целых числа. Найти: а) их среднее арифметическое; 
// б) их среднее геометрическое.
string buf;
Console.WriteLine("Введите число x:");
buf = Console.ReadLine();
double x = Convert.ToDouble(buf);

string buf1;
Console.WriteLine("Введите число y:");
buf1 = Console.ReadLine();
double y = Convert.ToDouble(buf1);

// Среднее арифметическое чисел равно отнеошению их суммы к их количеству. 
double avr = (x + y) / 2;

// Среднее геометрическое чисел это корень из произведения этих чисел, 
// показатель степени которого равен количеству этих чисел.
double geom = Math.Sqrt(x * y);

Console.WriteLine("Среднее арифметическое равно: {0},среднее геометрическое равно: {1}", avr, geom);
