// See https://aka.ms/new-console-template for more information
Console.Clear();
double C;
Console.Write("Введите трехзначное число N: ");
double N = Double.Parse(Console.ReadLine());
if(N<100 || N>999)
{Console.WriteLine("Число отсутствует, введено не трехзначное число");
return;}
C = N% 10;
    Console.Write($"последняя цифра во введенном числе: {C}");
    

