// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
  {
  Console.WriteLine ("Введите день недели:");
  int dayofweek = int.Parse (Console.ReadLine() ?? "0");
  if (dayofweek == 6 || dayofweek == 7) Console.WriteLine ("Да");
  else if (dayofweek <= 5) Console.WriteLine ("Нет");
  }