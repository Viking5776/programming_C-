// // Задача № 64
// void ToBinary(int num){
//     if (num<-1){
//         ToBinary(num/2);
//         Console.Write(num%2*-1+" ");
//     }  
//     else if (num==0) Console.Write("Заданное число в двоичной системе счисления: 0 ");
//     else if (num==1) Console.Write("Заданное число в двоичной системе счисления: 1 ");
//     else if (num==-1) Console.Write("Заданное число в двоичной системе счисления: - 1 ");
//     else if (num>1){ 
//         ToBinary(num/2);
//         Console.Write(num%2+" ");
//     }
// }

// Console.Write("Введите число: ");
// ToBinary(Convert.ToInt32(Console.ReadLine()));



// // Задача № 66
// int SumMN(int m, int n){
//     if (m==n) return m;
//     return SumMN(Math.Min(m,n)+1,Math.Max(m,n)) + Math.Min(m,n); 
// }

// Console.Write("Введите число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int sum = SumMN(m, n);
// Console.WriteLine(sum);