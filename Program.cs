// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Домашнее задание №66
/*
int main(int m, int n){
    if (m == n) return m;
    else return main(m+1, n) + m;
}

Console.WriteLine("Введите число ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(main(m, n));
*/


//Домашнее задание №68

int main(int m, int n){
    if (m == 0) return n+1;
    else if (m > 0 && n == 0) return main(m-1, 1);
    else if (m > 0 && n > 0) return main(m-1, main(m, n-1));
    else return 0;
}

Console.WriteLine("Введите число ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(main(m, n));


