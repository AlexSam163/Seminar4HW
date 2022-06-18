
/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
 3, 5 -> 243 (3⁵)
 2, 4 -> 16
Console.WriteLine($"\nЗадача 25. Возведене числа A в натуральную степень B");*/

Console.Write("Введите A: ");
double A = Convert.ToDouble(Console.ReadLine());
double B = 1;
Console.Write("Введите B: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n; i++)
{
B *= A;
}
Console.WriteLine(B);




/*Задача 27: Напишите программу, которая принимает на вход 
число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());


int sum = 0;

while(num > 0)
{
    sum = sum + num%10;
    num = num/10;
}
Console.WriteLine(sum);

/*Задача 29: Напишите программу, которая задаёт массив из 
8 элементов и выводит их на экран. Вывод сделать отдельным методом.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/



int [] array ={1, 2, 5, 7, 19};
int [] array2 ={6,1,33};
void PrintArr(int[] a)
{
    Console.Write("[");
    for (int i=0; i<a.Length-1; i++)
    {
        Console.Write(a[i]+",");
    }
    Console.Write(a[a.Length-1]+"]");
    Console.WriteLine();
}
PrintArr(array);
PrintArr(array2);





