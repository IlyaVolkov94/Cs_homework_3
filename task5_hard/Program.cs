// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int numDigit = (int)Math.Log(num, 10) + 1;
int arg = numDigit / 2;
int res = 0;
while (arg > 0)
{
    int div = num % 10;
    res = res + div * (int)Math.Pow(10, arg-1);
    num = num / 10;
    arg--;
}
if(numDigit%2!=0) num = num / 10;
if(num==res) Console.WriteLine("Число является палиндромом");
else Console.WriteLine("Число не является палиндромом");