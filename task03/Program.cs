// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день
// недели, и проверяет, является ли этот день выходным.


Console.Write("Введите цифру от 1-7: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 0 && a < 8)
{
if ( a > 5)
{
    Console.WriteLine ("Выходной");
} 
else
{
Console.WriteLine ("Будний");
}
}
else
{
 Console.WriteLine ("попробуйте снова");
}
