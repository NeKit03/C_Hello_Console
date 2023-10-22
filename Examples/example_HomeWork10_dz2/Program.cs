// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

public class Answer
{
  public static int Sum(int a,int b,int sum)
    {

    if(a<=b){
        sum+=a;
        return Sum(++a,b,sum);
    }else{
        return sum;
    }
    
    

    
    

    }

 // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
    string[] s=Console.ReadLine().Split(new char[] {' ',',','N','=','M',';'}, StringSplitOptions.RemoveEmptyEntries);
    Console.Write($"M={s[0]};N={s[1]}->{Sum(int.Parse(s[0]),int.Parse(s[1]),0)}");
    //Console.Write(s[1]);
    }
} 