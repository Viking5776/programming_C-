// // Задача № 47
// double[,] Matrix(int rows, int columns){
//     double[,] matrix = new double[rows, columns];
//     for (int i =0; i <matrix.GetLength(0); i++){
//         for (int j =0; j <matrix.GetLength(1); j++){
//             matrix[i,j] = Math.Round(new Random().NextDouble() * 100, 2);
//         }
//     }
//     return matrix;
// }

// void ShowMatrix(double[,] matrix){
//     for (int i =0; i <matrix.GetLength(0); i++){
//         for (int j =0; j <matrix.GetLength(1); j++){
//             Console.Write($"{matrix[i,j]} "); 
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// ShowMatrix(Matrix(rows, columns));




// // Задача № 50 
// int[,] Matrix(int rows, int columns, int min, int max){
//     int[,] matrix = new int[rows, columns];
//     for (int i =0; i <matrix.GetLength(0); i++){
//         for (int j =0; j <matrix.GetLength(1); j++){
//             matrix[i,j] = new Random().Next(min, max+1);
//         }
//     }
//     return matrix;
// }

// void ShowMatrix(int[,] matrix){
//     for (int i =0; i <matrix.GetLength(0); i++){
//         for (int j =0; j <matrix.GetLength(1); j++){
//             Console.Write($"{matrix[i,j]} "); 
//         }
//         Console.WriteLine();
//     }
// }

// void ShowElement(int[,] matrix, int i, int j){
//     if (i<matrix.GetLength(0) && j<matrix.GetLength(1)){
//         Console.WriteLine(matrix[i,j]);
//     }
//     else{
//         Console.WriteLine($"Элемента [{i},{j}] нет в массиве.");
//     }

// }

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение: ");    
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = Matrix(rows, columns, min, max);
// ShowMatrix(matrix);
// Console.Write("Введите строку: ");
// int i = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите столбец: ");
// int j = Convert.ToInt32(Console.ReadLine());
// ShowElement(matrix, i, j);



// // Задача № 52
// int[,] Matrix(int rows, int columns, int min, int max){
//     int[,] matrix = new int[rows, columns];
//     for (int i =0; i <matrix.GetLength(0); i++){
//         for (int j =0; j <matrix.GetLength(1); j++){
//             matrix[i,j] = new Random().Next(min, max+1);
//         }
//     }
//     return matrix;
// }

// void ShowMatrix(int[,] matrix){
//     for (int i =0; i <matrix.GetLength(0); i++){
//         for (int j =0; j <matrix.GetLength(1); j++){
//             Console.Write($"{matrix[i,j]} "); 
//         }
//         Console.WriteLine();
//     }
// }

// void Columns(int[,] matrix){
//     for (int i =0; i <matrix.GetLength(1); i++){
//         int sum = 0;
//         for (int j =0; j <matrix.GetLength(0); j++){
//             sum += matrix[j,i];
//         }
//         double arithMean = (double)sum/matrix.GetLength(0);
//         Console.WriteLine($"Среднее арифметическое {i}-го столбца: {Math.Round(arithMean, 1)}");
//     }
// }
// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение: ");    
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = Matrix(rows, columns, min, max);
// ShowMatrix(matrix);
// Columns(matrix);


