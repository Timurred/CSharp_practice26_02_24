//  Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
//  и показывает наибольшую цифру числа.

Console.Write("Веедите число от 10 до 99 :  ");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = num%10;
int num2 = num/10;

// if (num1 == num2)
// {
//     Console.Write(Цифры числа равны);
// }
if (num1 >= num2)
{
    Console.Write(num1);
}
else if(num2 >= num1)
{
    Console.Write(num2);
}

