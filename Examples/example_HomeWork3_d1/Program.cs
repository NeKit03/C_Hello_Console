using System;

public class Answer
{
    static bool IsPalindrome(int number){
      if (Convert.ToString(number).Length!=5){
        Console.WriteLine("Число не пятизначное");
        return false;
      }else{
        return Convert.ToInt32(number/100)==((number%10)*100+(number/10%10)*10+(number/100%10)) ? true : false;
      }
      
      
    }
  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 64546;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}