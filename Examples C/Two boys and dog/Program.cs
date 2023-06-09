// See https://aka.ms/new-console-template for more information
Console.Write("Введите расстояние между мальчиками: ");
double Dist = Double.Parse(Console.ReadLine());
Console.Write("Введите скорость первого мальчика: ");
double Sp1 = Double.Parse(Console.ReadLine());
Console.Write("Введите скорость второго мальчика: ");
double Sp2 = Double.Parse(Console.ReadLine());
Console.Write("Введите скорость собаки: ");
double SpDog = Double.Parse(Console.ReadLine());
Console.Write("От какого мальчика первой убегает собака? (1/2): ");
int D = Int32.Parse(Console.ReadLine());
int N = 0;
while(Dist>10) 
{
    if (D == 1)
{
    double Time = Dist / (Sp2+SpDog);
    D = 2;
    Dist = Dist-Time*(Sp1+Sp2);
}
     else
{
   double Time = Dist / (Sp1+SpDog);
    D = 1;
    Dist = Dist-Time*(Sp1+Sp2);
}

N = N + 1; 
}
Console.Write("Собака пробежит: ");
Console.Write(N);
Console.WriteLine(" раз");