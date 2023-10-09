using System;

public class Answer
{
    public static double FindMax(double[] array)
    {   double mx=array[0];
        foreach(double i in array)
            if(mx<i)
                mx=i;

         
        return mx;   
    }

    public static double FindMin(double[] array)
    {   double mn=array[0];
        foreach(double i in array)
            if(mn>i)
                mn=i;

         
        return mn;  

    }

    public static double CalcDifferenceBetweenMaxMin(double[] array)
    { return FindMax(array)-FindMin(array);



    }

    public static void PrintArray(double[] array)
    {foreach(double i in array)
        Console.Write($"{i:f2}\t");
        Console.Write("\n");

    }
 // Не удаляйте и не меняйте метод Main! 


    public static void Main(string[] args)
    {
        double[] array;
        if (args.Length == 0)
        {
            array = new double[] { 4.254, 7.4, 22.3, 2, 78 };
        }
        else
        {
            // Иначе, парсим аргументы в массив чисел
            string[] argStrings = args[0].Split(", ");
            array = new double[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (double.TryParse(argStrings[i], out double number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        Console.WriteLine("Массив:");
        PrintArray(array);
        double diff = CalcDifferenceBetweenMaxMin(array);
        Console.WriteLine($"Разность между максимальным и минимальным элементом = {diff:f2}");
    }
}