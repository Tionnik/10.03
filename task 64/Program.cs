
string PrintNumbers(int n){
    if (n<=0){
        return "Не правильное число";
    }
    if (n==1){
        return "1.";
    }
    string a=n.ToString()+", "+PrintNumbers(n-1);
    return a;
}
Console.Clear();									
Console.WriteLine("Введите число N ,больше 1");
int n = int.Parse(Console.ReadLine()!);	
Console.WriteLine( PrintNumbers(n));
