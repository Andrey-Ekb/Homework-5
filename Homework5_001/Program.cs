// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, 
// b1 k1 и b2 и k2 заданы

double k1=15;
double k2=10;
double b1=4;
double b2=17;
double x=0;
double y=0;

x=(b2-b1)/(k1-k2);
y=(k1*x)*b1;


Console.WriteLine(" точка пересечения : x= "+x+" y= "+y);
