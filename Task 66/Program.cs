
int Summ(int m, int n){
    int a =0;
    if (n<m){
        return 0;
    }

    a=n+Summ(m,n-1);
    return a;
}
Console.Clear();									
Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine()!);	
				
Console.WriteLine( Summ(m,n));