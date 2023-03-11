
int Arc(int m, int n){
    if (m==0){
        return n+1;
    }
    if (m>0 && n==0){
        return Arc(m-1,1);
    }
    if (m>0 && n>0){
        return Arc(m-1, Arc(m,n-1));
    }
    return n+1;
}
Console.Clear();									
Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine()!);	
Console.WriteLine( Arc(m,n));