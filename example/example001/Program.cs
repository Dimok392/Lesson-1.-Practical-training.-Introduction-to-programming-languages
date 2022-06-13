// Есть одномерный  массив целых чисел, который автоматически заполняется
// Сформируйте новый массив из квадратов чисел
// исходного массива

int [] CreateArray(int size)
{
    return new int [size];
}
void Fill (int []array, int min = 0 , int max = 10)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i]=new Random().Next(min,max);
    }
}
int [] SolveEx(int[]array)
{
    int size = array.Length;
    int [] result = new int [size];
    for (int i = 0; i < size; i++)
    {
        result [i]=array[i]*array[i];
    }
    return result;
}
void NotTruePrint (int [] array) 
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        System.Console.Write(array[i]+" ");
    }

}

string TruePrint (int [] array) 
{
string res = string.Empty;
int size = array.Length;
res="[";
    for (int i = 0; i < size; i++)
    {
        res += $"{array[i],3}";
    }
    res+="]";
    return res;
}
int [] startArray = CreateArray(10);
System.Console.WriteLine(TruePrint(startArray));
Fill(startArray);
System.Console.WriteLine(TruePrint(startArray));
int [] ResultArray = SolveEx(startArray);
System.Console.WriteLine(TruePrint(ResultArray));

// int []arr = {1,312,3,12,3,123,1};
// for (int i = 0; i <arr.Length; i++)
// {
//     System.Console.Write(arr[i]*arr[i]+" ");
// }