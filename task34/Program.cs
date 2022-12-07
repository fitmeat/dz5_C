void CreateArray(int[] arr)
{
    for(int i = 0; i<arr.Length; i++){
        arr[i] = new Random().Next(100,1000);
    }
}

void FindNumber(int[] arr, int count)
{
    for(int i = 0; i<arr.Length; i++){
        if(arr[i]%2 == 0){
            count++;
        }
    }
    Console.WriteLine($"Количество четных чисел: {count}");
}

Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[n];
int count = 0;
CreateArray(arr);
Console.WriteLine($"[{string.Join(", ", arr)}]");
FindNumber(arr,count);