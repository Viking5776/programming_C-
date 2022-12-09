// // Задача № 19
// void Palindrome(int number){
//     while (number < 10000 || number > 99999){
//     Console.Write("Ошибка! Введите пятизначное число: ");
//     number = Convert.ToInt32(Console.ReadLine());
//     }
//     if (number/10000 == number%10 && number/1000%10 == number/10%10){
//         Console.WriteLine("Да");
//     }
//     else {
//         Console.WriteLine("Нет");
//     }
// }
// Console.Write("Введите пятизначное число: ");
// Palindrome(Convert.ToInt32(Console.ReadLine()));



// // Задача № 21
// double Distance(int x1, int y1, int z1, int x2, int y2, int z2){
//     double result = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
//     result = Math.Round(result, 2);
//     return(result);
// }

// Console.Write("Введите координату x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double result = Distance(x1, y1, z1, x2, y2, z2);
// Console.WriteLine(result);



// // Задача № 23
// void Cube(int number){
//     for (int num = 1; num <= number; num++){
//         Console.WriteLine($"{num} * {num} * {num} = {num*num*num};");
//     }
// }

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Cube(num);