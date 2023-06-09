// See https://aka.ms/new-console-template for more information

Console.Clear();
Console.Write("Введите N: ");
int C = 2;
double N = Double.Parse(Console.ReadLine());
if(N<2)
{Console.WriteLine("Числа отсутствуют");
return;}
while(C<=N)
{
    Console.Write($" {C}");
    C=C+2;
    } 



