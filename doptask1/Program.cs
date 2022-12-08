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
Console.WriteLine(threes);
Console.WriteLine(fours);
int[] arr2 = new int[threes];
int[] arr3 = new int[fours];
for(int i =0; i<arr.Length-1; i++){
   if(arr[i]%2 != 0){
    for(int j = 0; j<arr2.Length; j++){
        arr2[j] = arr[i];
    }
   } else 
   for(int k = 0; k<arr3.Length; k++){
    arr3[k] = arr[i];
   }
}
Console.WriteLine($"Неченые числа: {string.Join(", ", arr2)}");
Console.WriteLine($"Четные числа: {string.Join(", ", arr3)}");
