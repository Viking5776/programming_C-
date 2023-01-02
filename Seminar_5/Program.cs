// int[] Array(int size, int min, int max){
//     int[] array = new int[size];
//     for (int i = 0; i <array.Length; i++){
//         array[i] = new Random().Next(min, max);
//     }
//     return array;
// }

// void ShowArray(int[] array){
//     for (int i =0; i <array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }


// // Задача № 34
// int NumOfPositive(int[] array){
//     int count = 0;
//     for (int i =0; i <array.Length; i++){
//         if (array[i]%2 ==0){
//             count +=1;
//         }
//     }
//     return count;
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int min = 100;
// int max = 1000;
// int[] arr = Array(size, min, max);
// ShowArray(arr);
// int count = NumOfPositive(arr);
// Console.WriteLine($"Количество четных чисел: {count}");



// // Задача № 35
// int Counter(int[] array){
//     int count = 0;
//     for (int i =0; i <array.Length; i++){
//         if (array[i] >9 && array[i] <100){
//             count +=1;
//         }
//     }
//     return count;
// }

// int size = 123;
// int min = 0;
// int max = 124;
// int[] arr = Array(size, min, max);
// ShowArray(arr);
// int count = Counter(arr);
// Console.WriteLine($"Количество двузначных чисел: {count}");



// // Задача № 36
// int Summ(int[] array){
//     int sum = 0;
//     for (int i =1; i <array.Length; i +=2){
//         sum +=array[i];
//     }
//     return sum;
// }

// int size = 6;
// int min = -99;
// int max = 100;
// int[] arr = Array(size, min, max);
// ShowArray(arr);
// int sum = Summ(arr);
// Console.WriteLine($"Сумма элементов с нечетными индексами: {sum}");



// // Задача № 38
// int Difference(int[] array){
//     int min = array[0];
//     int max = array[0];
//     for (int i =1; i <array.Length; i++){
//         if (array[i] <min){
//             min = array[i];
//         }
//         if (array[i] >max){
//             max = array[i];
//         }
//     }
//     int diff = max - min;
//     return diff;
// }

// int size = 6;
// int min = -99;
// int max = 100;
// int[] arr = Array(size, min, max);
// ShowArray(arr);
// int diff = Difference(arr);
// Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {diff}");



// // Задача № 37
// void ProductOfPairs(int[] array){
//     for (int i =0; i <=(array.Length-1)-i; i++){
//         if (i ==(array.Length-1)-i){
//             Console.Write($"{array[i]} ");
//         }
//         else{
//             Console.Write($"{array[i]*array[(array.Length-1)-i]} ");
//         }
//     } 
// }

// int size = 5;
// int min = 0;
// int max = 10;
// int[] arr = Array(size, min, max);
// ShowArray(arr);
// ProductOfPairs(arr);