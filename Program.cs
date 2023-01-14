/// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine ("Ведите число 1: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите число 2: ");
int B = int.Parse(Console.ReadLine()!);
Console.Write($"Число {A} в степени  {B} равно {Degrees(A,B)}"); 

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*Console.WriteLine ("Ведите число : ");
int numb = int.Parse(Console.ReadLine()!);
Console.Write($"Сумма цифр в числе равна {GSum(numb)}"); */


//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)

/*Console.WriteLine ("Ведите максимальное число диапазона: ");
int num = int.Parse(Console.ReadLine()!);
int[] Array = GetArray(8); 
Console.Write($"[{String.Join(";", Array)}]"); */



//-----------Методы--------------------------------

//-------------- Метод к задаче 1 ----------------
int Degrees(int a, int b)
{
    int res = 1;
    for (int i = 1; i <= b; i++)
    {
        res = res * a;
    }
    return res;
}

//-------------- Метод к задаче 2 ----------------
/*
int GSum (int A) 
{
int sum = 0;  
while (A>0)
{
    sum = sum + A % 10;
    A = A/10;      
 }
  return sum;
 }
 */

 //-------------- Метод к задаче 3 ----------------

/*
int[] GetArray (int size) 
{ 
    int[] Array = new int[size]; 
    for (int i = 0; i < size; i++) 
    { 
        Array[i] = new Random().Next(num); 
    } 
    return Array; 
}
*/
