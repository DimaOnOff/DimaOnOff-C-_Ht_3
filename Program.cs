//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да

//Console.Write("Enter number ");

//int Num = int.Parse(Console.ReadLine());
//int Num1 = Num / 10000;
//int Num5 = Num % 10;
//int Num2 = Num / 1000 - Num1*10;
//int Num4_1 = Num % 100;
//int Num4 = (Num4_1 - Num1)/10;

//if (Num1 == Num5 & Num2 == Num4)
//{
//Console.WriteLine("Число полином");
//}
//else 
//{
//Console.WriteLine("Число НЕ полином");
//}

//Задача 21

//Напишите программу, которая принимает на вход координаты двух 
//точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

//Console.WriteLine ("Enter X1 : ");
//int Xa = int.Parse(Console.ReadLine());

//Console.WriteLine ("Enter Y1 : ");
//int Ya = int.Parse(Console.ReadLine());

//Console.WriteLine ("Enter Z1 : ");
//int Za = int.Parse(Console.ReadLine());

//Console.WriteLine ("Enter X2 : ");
//int Xb = int.Parse(Console.ReadLine());

//Console.WriteLine ("Enter Y2 : ");
//int Yb = int.Parse(Console.ReadLine());

//Console.WriteLine ("Enter Z2 : ");
//int Zb = int.Parse(Console.ReadLine());
//
//double Xab = (Xb - Xa);
//double Yab = (Yb - Ya);
//double Zab = (Zb - Za);

//double XYZab = Math.Pow(Xab,2) + Math.Pow(Yab, 2) + Math.Pow(Zab, 2);

//double result = Math.Sqrt(XYZab);

//Console.WriteLine($"Результат {result}");

//Задача 23

//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine ("Enter N: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
double sqr = 1;
while (N >= i )
{
    sqr = Math.Pow(i, 3);
    Console.Write($"{sqr}, ");
    i++;
}