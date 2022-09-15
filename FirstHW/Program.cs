//7. Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает последнюю цифру этого числа.
//Console.WriteLine("Введите трехзначное число");
//string Num = Console.ReadLine();
//Console.WriteLine($"Последнее число -> {Num[2]}");

//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//int A;
//int B;
//Console.WriteLine("Введите 1ое число: ");
//A = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите 2ое число: ");
//B = Convert.ToInt32(Console.ReadLine());

//if (A < B)
//Console.WriteLine($"Max = {B} , Min = {A}");
//else if (B < A)
//Console.WriteLine($"Max = {A} , Min = {B}");
//else Console.WriteLine("Числа равны");

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//int A, B, C, Max;
//Console.WriteLine("Введите первое число: ");
//A = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите второе число: ");
//B = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите третье число: ");
//C = Convert.ToInt32(Console.ReadLine());

//if (A > B)
//Max = A;
//else Max = B;
//if (C > Max)
//{
//    Max = C;
//    Console.WriteLine($"Max = {Max}");
//}
//else Console.WriteLine($"Max = {Max}");


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//int A, Mod;
//Console.WriteLine("Введите число для проверки на чётность: ");
//A = Convert.ToInt32(Console.ReadLine());
//Mod = A % 2;

//if (Mod == 0) Console.WriteLine("Число четное");
//else Console.WriteLine("Число Нечетное");


//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int A, Count;
Count = 2;
Console.WriteLine("Введите число: ");
A = Convert.ToInt32(Console.ReadLine());

while (Count <= A)
{Console.Write($"{Count}  ");
 Count += 2;
}