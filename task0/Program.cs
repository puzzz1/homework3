/*Напишите программу, которая принимает на вход
 пятизначное число и проверяет, является ли 
 оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/


Console.WriteLine("Введи число");
string userNumber = Console.ReadLine();
string test = string.Empty;
for (int i = userNumber.Length - 1; i >= 0; i--)
 {test += userNumber[i];}
            
    if (userNumber == test)
    {Console.WriteLine("Да, это полиндром!");}
    else
    {Console.WriteLine("Нет, это не полиндром!"); }
 Console.ReadKey();