/*Напишите программу, которая принимает 
на вход координаты двух точек и находит 
расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

int getNumberFromUser(string message)
{
    int result = 0;
    Console.WriteLine(message);
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}


double Distansebeetween(double Ax, double Ay, double Bx, double By, double Cx, double Cy)
{  
    double distance = Math.Sqrt(Math.Pow ((Ay -Ax),2)+ Math.Pow((By - Bx),2)+ Math.Pow((Cy - Cx),2)*1);
   
    return distance;
}
int Ax= getNumberFromUser("Put Ax:");
int Ay= getNumberFromUser("Put Ay:");
int Bx= getNumberFromUser("Put Bx:");
int By= getNumberFromUser("Put By:");
int Cx= getNumberFromUser("Put Cx:");
int Cy= getNumberFromUser("Put Cy:");
double distance = Distansebeetween(Ax, Ay, Bx, By, Cx, Cy);
Console.WriteLine($"Расстояние между точками равно {distance}");
