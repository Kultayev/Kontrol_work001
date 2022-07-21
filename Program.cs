// Сформировать массив строк, далее вывести на экран массив, где в словах три и менее символов
using System;
Console.Write("Вот наш массив :\t ");
string [] myArray = {"Hello", "brother", "how", "do", "you", "do?"};

string [] myArray2 = new string[myArray.Length];
for (int k = 0; k <= 5; k++)
    {
        
        Console.Write(" " + myArray[k]); // вывод первоначального массива через пробел
        
    }
    var i=0;
    foreach (var value in myArray)
    {
        if (value.Length <=3)
        {
            myArray2[i] = value; i++;
        }
    }
    Console.WriteLine();
Console.Write("Массив с элементами от 3-х и менее символов:\t");
    for (int j = 0; j <= 5; j++)
    {
        
        Console.Write(" " + myArray2[j]); // вывод массива через пробел min 3 letters
        
            }
