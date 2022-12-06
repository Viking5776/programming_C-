// 1.
// int DecNum(int num){
//     // int result = (num/10)-(num/100*10);
//     int result = num/10%10;
//     return result;
// }
// Console.Write($"Введите трехзначное число: ");
// int result = DecNum(Convert.ToInt32(Console.ReadLine()));
// Console.WriteLine($"{result} - вторая цифра из числа");



// 2.0.
// string ThrNum(int num){
//     if (num>99 || num<-99){
//         int result = num/100%10;
//         return Convert.ToString(result);
//     }
//     else {
//         return (Convert.ToString("Третьей цифры нет"));
//     }
// }
// Console.Write($"Введите число: ");
// string result = ThrNum(Convert.ToInt32(Console.ReadLine()));
// Console.WriteLine($"{result} - третья цифра из числа");



// 2.1.
// int ThrNum(int num){
//     int result = num/100%10;
//     return Convert.ToInt32(result);
// }
// Console.Write($"Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num <= 99 && num >= -99){
//     Console.WriteLine("Третьей цифры нет");
// }
// else {
//     int result = ThrNum(num);
//     Console.WriteLine($"{result} - третья цифра из числа");
// }



// 3.
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
