string buf1;
Console.WriteLine("Ведите возраст Тани:");
buf1 = Console.ReadLine();
double x = Convert.ToDouble(buf1);

string buf2;
Console.WriteLine( "Введите возраст Мити:");
buf2 = Console.ReadLine();
double y = Convert.ToDouble(buf2);

double avr = (x + y)/2;
Console.WriteLine( "Средний возраст равен: {0}", avr);

double a = avr - x;
if(a<=0)
{
    a = a * (-1);
}

double b = a;

     
Console.WriteLine("Возраст Тани отличается от среднего значения на {0} лет Возраст Мити  отличается от среднего значения на {1} лет", a, b);




 
    
