int n = Convert.ToInt32(Console.ReadLine());
n=n%2!=0 ? n-1: n;
for(int i=2;i<=n-1;i+=2)
    Console.Write(Convert.ToString(i)+", ");
Console.WriteLine(n%2==0 ? n: "");    