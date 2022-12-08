void CreateArray(double[] array)
{
    for(int i = 0; i<array.Length; i++){
        array[i] = Math.Round(new Random().NextDouble() * 100,1);
    }
}

double FindMax(double[] array, double max)
{
    for(int i = 0; i<array.Length; i++){
        if(array[i]>max){
            max = array[i];
        }
    }
    return max;
}

double FindMin(double[] array, double min)
{
     for(int i = 0; i<array.Length; i++){
        if(array[i]<min){
            min = array[i];
        }
    }
    return min;
}

Console.Clear();
Console.WriteLine("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[n];
CreateArray(arr);
double min = arr[0];
double max = arr[0];
Console.WriteLine($"[{string.Join(", ", arr)}]");
Console.WriteLine($"Максимальное число: {FindMax(arr,max)}");
Console.WriteLine($"Минимальное число: {FindMin(arr,min)}");
Console.WriteLine($"Разница между минимальным и максимальным: {FindMax(arr,max)-FindMin(arr,min)}");