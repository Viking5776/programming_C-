// // Задача № 25
// int Power(int baze, int exp){
//     int result = baze;
//     if (exp == 0){
//         result = 1;
//     }
//     else{
//         for (int i = 1; i<exp; i++){
//             result *= baze;
//         }
//     }    
//     return (result);
// }

// Console.Write("Введите основание: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите показатель: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int power = Power(a, n);
// Console.WriteLine(power);



// // Задача № 27
// int SumOfNum(int number){
//     int sum = 0;
//     if (number <0){
//         number *=-1;
//     }
//     for (int i = 0; number >0; i++){
//         sum += number %10;
//         number /=10;
//     }
//     return sum;
// }

// Console.Write("Введите число: ");
// int sumOfNum = SumOfNum(Convert.ToInt32(Console.ReadLine()));
// Console.WriteLine(sumOfNum);



// // Задача № 29
int[] Array(){
    Console.Write("Введите длину массива: ");
    int[] arr = new int [Convert.ToInt32(Console.ReadLine())];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Введите элемент массива: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void ShowArray (int[] arr){

    for (int i=0; i < arr.Length; i++){
        Console.Write($"{arr[i]} ");
    }
}
ShowArray(Array());