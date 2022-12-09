void CreateArray(int[] array)
{
    for(int i = 0; i<array.Length; i++){
        array[i] = new Random().Next(1,32);
    }
}

Console.Clear();
Console.WriteLine("Введите количество элементов N: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[N];
CreateArray(arr);
Console.WriteLine($"[{string.Join(", ", arr)}]");
int threes = 0;
int fours = 0;

for(int i = 0; i<arr.Length; i++){
    if(arr[i]%2 != 0){
        threes++;
    } else fours++;
}

int[] arr2 = new int[arr.Length];
int[] arr3 = new int[arr.Length];

for(int i =0; i<arr.Length; i++){
   if(arr[i]%2 != 0){
        arr2[i] = arr[i];
    } else arr3[i] = arr[i];
}
Console.WriteLine($"Неченые числа: {string.Join(", ", arr2)}");
Console.WriteLine($"Четные числа: {string.Join(", ", arr3)}");
if(threes>fours){
    Console.WriteLine("NO"); 
} else Console.WriteLine("YES");

