void CreateArray(int [] array)
{
    for(int i = 0; i<array.Length; i++){
        array[i] = new Random().Next(-50,51);
    }
}

void FindSum(int [] array, int sum)
{
    for(int i = 0; i<array.Length; i++){
        if(i%2 != 0){
            sum += array[i];
        }
    }
    Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");
}

Console.Clear();
Console.WriteLine("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[n];
CreateArray(arr);
Console.WriteLine($"[{string.Join(", ", arr)}]");
int sum = 0;
FindSum(arr,sum);