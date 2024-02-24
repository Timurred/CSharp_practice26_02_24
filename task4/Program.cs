// Напишите программу, которая на вход принимает натуральное число N,
// а на выходе показывает его цифры через запятую.

Console.Write("Введите натуральное число:  ");
int num = Convert.ToInt32(Console.ReadLine());
int quantity = (int)Math.Log10(num);
int index = 0;
while (index< quantity)
{
int currentnum = (int)(num / Math.Pow(10, quantity - index))%10;
Console.Write($"{currentnum}, ");
index++; 
}
Console.Write($"{num%10}");
 