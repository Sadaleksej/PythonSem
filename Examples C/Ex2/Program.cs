// See https://aka.ms/new-console-template for more information
Console.Clear();
double Max;
Console.Write("Введите A: ");
double A = Double.Parse(Console.ReadLine());
Console.Write("Введите B: ");
double B = Double.Parse(Console.ReadLine());
Console.Write("Введите C: ");
double C = Double.Parse(Console.ReadLine());
if(A>=B) Max=A; 
else Max=B;
if(C>Max) Max=C;
Console.WriteLine($"Наибольшее число: {Max}");
