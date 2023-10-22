//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

public class Answer
{
  public static void PrintLineNumber(int a)
    {
    if(a>1){
        Console.Write($"{a}, "); 
        PrintLineNumber(--a);
    }
    else{
        Console.Write($"{a}");
    }
    

    }

 // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
    string[] s=Console.ReadLine().Split(new char[] {' ',',','N','='}, StringSplitOptions.RemoveEmptyEntries);
    PrintLineNumber(Convert.ToInt32(s[0]));
    }
} 