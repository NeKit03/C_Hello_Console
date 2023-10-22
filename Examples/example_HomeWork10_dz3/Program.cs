//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

public class Akkerman
{
  public static int F(int a,int b)
    {

    while(a!=0){
        if(b==0){
            b=1;
        }else{
            b=F(a,b-1);
        }
        a-=1;
    }
    return b+1;
    
    

    
    

    }

 // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
    string[] s=Console.ReadLine().Split(new char[] {' ',',','n','=','m',';'}, StringSplitOptions.RemoveEmptyEntries);
    Console.Write($"m={s[0]};n={s[1]} -> A(m,n)= {F(int.Parse(s[0]),int.Parse(s[1]))}");
    //Console.Write(s[1]);
    }
} 