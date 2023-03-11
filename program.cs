// Задача 64
Console.WriteLine("Введите натуральное число");
int num = Convert.ToInt32(Console.ReadLine());

string PrintNum(int start, int end){
if (start==end) {return start.ToString();}
return(start +" "+ PrintNum(start-1,end));
}

Console.WriteLine(PrintNum(num,1));


// Задача 66
Console.WriteLine("Введите натуральное число");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число");
int N = Convert.ToInt32(Console.ReadLine());

int PrintNumbersSum(int M, int N) {
  if (M==N) return (M);
  else if (M<N) return (N + PrintNumbersSum(M, N-1));
  else return (N + PrintNumbersSum(M, N+1));
}
Console.WriteLine(PrintNumbersSum(M,N));


// Задача 68
Console.WriteLine("Введите натуральное число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число");
int n = Convert.ToInt32(Console.ReadLine());

int Akk(int m, int n) {
  if (m==0) return n+1;
  else
  if((m!=0) && (n==0)) return Akk(m-1, 1);
  else return Akk(m-1, Akk(m, n-1));
}
Console.WriteLine(Akk(m, n));