//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

string[] array(string s){
    return s.Split(new char[] {' ',','}, StringSplitOptions.RemoveEmptyEntries);

}

string[] a= array(Console.ReadLine());
for(int i=0;i<a.Length;i++){
    Console.Write($"{a[i]} ");
}