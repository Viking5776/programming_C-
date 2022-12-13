// // Задача № 10
// int DecNum(int num){
//     int result = num/10%10;
//     return result;
// }
// Console.Write("Введите трехзначное число: ");
// int result = DecNum(Convert.ToInt32(Console.ReadLine()));
// Console.WriteLine($"{result} - вторая цифра из числа");



// // Задача № 13
// void ThrNum(int num){
//     if (num <0){
//         num *=-1;
//     }   
//     if (num < 100){
//         Console.WriteLine("Третьей цифры нет");
//     } 
//     else {
//         for (int i = 0; num >=1000; i++){
//         num /=10;
//         }
//         Console.WriteLine($"{num%10} - третья цифра из числа");
//     }
// }
// Console.Write($"Введите число: ");
// ThrNum(Convert.ToInt32(Console.ReadLine()));

// // Задача № 15
// void Date(int num){
//     if (num>=1 && num<=5){
//         Console.Write("Трудовыебудни(");
//     }
//     else if (num>=6 && num<=7){
//         Console.Write("Выходные!)");
//     }
//     else {
//         Console.Write($"{num}-го дня недели, увы, еще не придумали.");
//     }
// }
// Console.Write($"Введите число: ");
// Date(Convert.ToInt32(Console.ReadLine()));