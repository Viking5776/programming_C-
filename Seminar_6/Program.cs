// // Задача № 41
// int[] UserArray(){
//     Console.WriteLine("Enter the number of numbers");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++){
//         Console.WriteLine($"Enter the {i+1}st(nd,rd,th) number");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return(array);
// }

// void Posit(int[] array){
//     int count = 0;
//     for (int i = 0; i < array.Length; i++){
//         if (array[i] > 0){
//             count +=1;
//         }
//     }
// Console.WriteLine($"Numbers greater than zero: {count}");    
// }

// int[] array = UserArray();
// Posit(array);


// void Posit(int size){
//     int count = 0;
//     for (int i = 1; i <= size; i++){ 
//         Console.WriteLine($"Enter the {i}st(nd,rd,th) number");
//         int num = Convert.ToInt32(Console.ReadLine());
//         if (num > 0){
//             count++;
//         }
//     }
//     Console.WriteLine($"Numbers greater than zero: {count}");
// }

// Console.WriteLine("Enter the number of numbers");
// int size = Convert.ToInt32(Console.ReadLine());
// Posit(size);



// // Задача № 43
// void Intersection(double b1, double k1, double b2, double k2){
//     double x = (b2 - b1)/(k1 - k2);
//     double y = (k1 * x) + b1;
//     Console.WriteLine($"({x};{y})");
// }

// Console.Write("Enter b1: ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter k1: ");
// int k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter b2: ");
// int b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter k2: ");
// int k2 = Convert.ToInt32(Console.ReadLine());
// Intersection(b1, k1, b2, k2);