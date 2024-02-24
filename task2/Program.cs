// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
// которой находится эта точка.

Console.Write("Введите координаты точки х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки y: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x==0||y==0)
{
    Console.Write($"число 0 использовать нельзя");
}   
else if (x>0 && y> 0)
{
 Console.Write("четверть 1");   
}
else if (x<0 && y > 0)
{
  Console.Write( "четверть 2" );  
}
else if (x <0 && y < 0)
{
   Console.Write("Четверть 3");
}
else if (x> 0 && y <0)
{
    Console.Write("четверть 4");
}
 
 

