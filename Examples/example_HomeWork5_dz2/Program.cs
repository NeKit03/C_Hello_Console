// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
string sum(string numA){
    int count=0;
    for( int i=0;i<numA.Length;i++){
        count+=numA[i]-'0';
    }
    return numA+" -> "+Convert.ToString(count);
}
Console.WriteLine(sum(Console.ReadLine()));



