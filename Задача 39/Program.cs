// Дано действительное число x. Не пользуясь никакими другими 
// арифметическими операциями, кроме умножения, сложения и вычитания, 
// вычислить за минимальное число операций 2x^4 – Зх^3 + 4x^2 – 5х + 6.

string buf;
Console.WriteLine("Введите число:");
buf = Console.ReadLine();
double x = Convert.ToDouble(buf);

double a = Math.Pow(x, 4) * 2;
double b = Math.Pow(x, 3) * 3;
double c = Math.Pow(x, 2) * 4;

double y = a - b + c - 5 * x + 6;

Console.WriteLine(y);
