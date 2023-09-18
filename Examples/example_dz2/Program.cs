int numA=Convert.ToInt32(Console.ReadLine());
int numB=Convert.ToInt32(Console.ReadLine());
int numC=Convert.ToInt32(Console.ReadLine());
Console.Write("Наибольшее число ");
if(numA>numB){
    Console.WriteLine(numA>numC ? numA:numC);
}else{
     Console.WriteLine(numB>numC ? numB:numC);
}