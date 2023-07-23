//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Эта программа ответит, какое из двух введенных чисел больше");
Console.WriteLine("Введите первое число");
double FirNum = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число");
double SecNum = Convert.ToDouble(Console.ReadLine());
if (FirNum > SecNum) Console.WriteLine("Первое число, "+FirNum+", больше!");
else if (FirNum < SecNum) Console.WriteLine("Второе число, "+SecNum+", больше!");
else Console.WriteLine("Оба числа равны!");

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Эта программа ответит, какое из трех введенных чисел больше");
Console.WriteLine("Введите первое число");
double MaxNum = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число");
double AnotherNum = Convert.ToDouble(Console.ReadLine());
if (AnotherNum > MaxNum) MaxNum=AnotherNum;
Console.WriteLine("Введите третье число");
AnotherNum = Convert.ToDouble(Console.ReadLine());
if (AnotherNum > MaxNum) MaxNum=AnotherNum;
Console.WriteLine("Наибольшее число: "+MaxNum);

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Эта программа ответит, является ли введенное число четным");
Console.WriteLine("Введите целое число");
int Num = Convert.ToInt32(Console.ReadLine());
if (Num%2==0) Console.WriteLine("Да, оно является четным");
else Console.WriteLine("Нет, оно не является четным");

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Эта программа покажет все четные числа от 2 до введенного");
Console.WriteLine("Введите ваше число");
Again:
int YourNum = Convert.ToInt32(Console.ReadLine());
if (YourNum<2) {Console.WriteLine("Ваше число слишком мало! Введите другое число"); goto Again;} 
int count=2;
Console.WriteLine("Четные числа от 2 до вашего: ");
while (count<=YourNum) 
{
    Console.Write(count);
    count+=2;
} 
