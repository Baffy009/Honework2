//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear(); 
 
Console.Write("Введите число: "); 
 
int num = Convert.ToInt32(Console.ReadLine()); 
 
if (num < 0) 
{ 
    num = -num; 
} 
 
string numstr = Convert.ToString(num); 
 
if (numstr.Length > 2) 
{ 
  Console.WriteLine(numstr[2]); 
} 
else { 
  Console.WriteLine("-> третьей цифры нет"); 
}