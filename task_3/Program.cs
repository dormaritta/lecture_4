﻿/* Факториал!
5! = 5 * 4 * 3 * 2 * 1
     5 * 4!
         4 * 3!
             3 * 2!
Функция вызывает сама себя -- это рекурсия! */

double Factorial (int n)
{
    if(n == 1) return 1;
    else return n * Factorial(n - 1);
}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}

/* Console.WriteLine(Factorial(3)); //1 * 2 * 3 = 6 */