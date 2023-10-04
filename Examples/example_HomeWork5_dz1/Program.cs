// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int power(int numA,int numB){
    int numC=1;
    for( int i=0;i<numB;i++){
        numC*=numA; 
    }
    return numC;
}

string[] a=Console.ReadLine().Split(new char[] {' ',','}, StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine(power(Convert.ToInt32(a[0]),Convert.ToInt32(a[1])));


