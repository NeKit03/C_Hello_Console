//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int[] IntArray(){
    string[] s=Array();
    int [] array = new int[s.Length];
    for(int i=0;i<s.Length;i++){
        array[i]=Convert.ToInt32(s[i]);
    }
    return array;
}
string[] Array(){
    return Console.ReadLine().Split(new char[] {' ',','}, StringSplitOptions.RemoveEmptyEntries); 
}
int Quantity(int[] array){
    int count=0;
    foreach(int i in array)
        if(i>0)
            count++;
    return count;        
}

void IntPrintArray(int[] array){
    for(int i=0;i<array.Length-1;i++)
        Console.Write($"{array[i]},");
    Console.Write($"{array[array.Length-1]}->");    
}

int[] array=IntArray();
IntPrintArray(array);
Console.Write(Quantity(array));

