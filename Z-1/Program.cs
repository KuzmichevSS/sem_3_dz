//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
int i = num / 10000;
int b = num % 10;
if (i==b)
{
    Console.WriteLine("Палиодром");
}
else
{
    Console.WriteLine("Не палиодрон");

}
