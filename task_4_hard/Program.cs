// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.
Console.WriteLine("Введите размерность пространства");
int dimSpace = mod(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Введите координаты точки А");
int[] arrayA = inputArray(dimSpace);
Console.WriteLine("Введите координаты точки B");
int[] arrayB = inputArray(dimSpace);
Console.WriteLine("Расстояние между точками A и B: "+distCalc(arrayA, arrayB));






double distCalc(int[] array1, int array2)
{
    int size = array1.Length;
    int degSum = 0;
    for(int i=0;i<size;i++)
    {
        degSum = degSum + (int)Math.Pow(array2[i]-array1[i],2);
    }
    return Math.Round(Math.Sqrt(degSum),2);
}


int mod(int num)
{
    if (num<0) num=-num;
    return num;
}


int[] inputArray(int size)
{
    int[] array = new int [size];
    for(int i=0; i<size;i++)
    {
        Console.WriteLine($"Введите {i+1} координату");
        array[i]=Convert.ToInt32(Console.ReadLine());
    }
    return array;
}