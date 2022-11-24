/*Напишите программу, которая принимает 
на вход число (N) и выдаёт таблицу 
кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/


Console.WriteLine("Put a number");
int number = Convert.ToInt32(Console.ReadLine());
int first = 1;
while (first <= number)
{
    Console.WriteLine(first*first*first+ " ");
    first++;
}