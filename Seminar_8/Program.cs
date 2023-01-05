// // Задача № 54
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

// int[,] RowsSort(int[,] matrix){
//     for (int i =0; i <matrix.GetLength(0); i++){
//         for (int j =0; j <matrix.GetLength(1)-1; j++){
//             for (int k =0; k <matrix.GetLength(1)-1; k++){
//                 if (matrix[i,k+1]>matrix[i,k]){
//                 (matrix[i,k+1], matrix[i,k]) = (matrix[i,k], matrix[i,k+1]);
//                 }
//             }
//         }
//     }
//     return (matrix);
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
// Console.WriteLine();
// matrix = RowsSort(matrix);
// ShowMatrix(matrix);



// // Задача № 56
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

// void MinSumRows(int[,] matrix){
//     int sum = 0;
//     for (int j =0; j <matrix.GetLength(1); j++){
//         sum +=matrix[0,j];
//     }
//     int minSumRows = 0;
//     int minSum = sum;
//     for (int i =1; i <matrix.GetLength(0); i++){
//         sum = 0;
//         for (int j =0; j <matrix.GetLength(1); j++){
//             sum +=matrix[i,j];
//         }
//         if (sum <minSum){
//             minSum = sum;
//             minSumRows = i;
//         }
//     }
//     Console.Write($"Строка с наименьшей суммой элементов: {minSumRows} ({minSum}) ");
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
// Console.WriteLine();
// MinSumRows(matrix);



// // Задача № 58
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

// int[,] MatrixProduct(int[,] matrixA, int[,] matrixB){
//     int[,] matrixProduct = new int[matrixA.GetLength(0),matrixB.GetLength(1)];
//     for (int i =0; i<matrixProduct.GetLength(0); i++){
//         for (int j =0; j<matrixProduct.GetLength(1); j++){
//             int sum = 0;
//             for (int k =0; k<matrixA.GetLength(1);k++){
//                 sum += matrixA[i,k]*matrixB[k,j];
//             }
//             matrixProduct[i,j] = sum;
//         }
//     }
//     return matrixProduct;
// }

// Console.Write("Введите количество строк_А: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов_А/строк_В: ");
// int colsRows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов_В: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// while (rows<=0 || colsRows<=0 || columns<=0){
//     Console.WriteLine("Ошибка!");
//     Console.Write("Введите количество строк_А: ");
//     rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество столбцов_А/строк_В: ");
//     colsRows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество столбцов_В: ");
//     columns = Convert.ToInt32(Console.ReadLine());
// }
// Console.Write("Введите минимальное значение: ");    
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());
// while (min>max){
//     Console.WriteLine("Ошибка!");
//     Console.Write("Введите минимальное значение: ");    
//     min = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите максимальное значение: ");
//     max = Convert.ToInt32(Console.ReadLine());
// }
// int[,] matrixA = Matrix(rows, colsRows, min, max);
// int[,] matrixB = Matrix(colsRows, columns, min, max);
// ShowMatrix(matrixA);
// Console.WriteLine();
// ShowMatrix(matrixB);
// Console.WriteLine();
// int[,] matrixProduct = MatrixProduct(matrixA,matrixB);
// ShowMatrix(matrixProduct);



// // Задача № 60
// bool SearchMatches(int[,,] array3D, int num){
//     bool match = false;
//     for (int i =0; i <array3D.GetLength(0); i++){
//         for (int j =0; j <array3D.GetLength(1); j++){
//             for (int k =0; k <array3D.GetLength(2); k++){
//                 if (array3D[i,j,k] == num){
//                     match = true;
//                 }
//             }
//         }
//     }
//     return match;
// }

// int[,,] CreateArray3D(int x, int y, int z, int min, int max){
//     int[,,] array3D = new int[x, y, z];
//     for (int i =0; i <array3D.GetLength(0); i++){
//         for (int j =0; j <array3D.GetLength(1); j++){
//             for (int k =0; k <array3D.GetLength(2); k++){
//                 int num = new Random().Next(min, max+1);
//                 bool match = SearchMatches(array3D, num);
//                 while (match == true){
//                     num = new Random().Next(min, max+1);
//                     match = SearchMatches(array3D, num);         
//                 }
//                 array3D[i,j,k] = num;
//             }
//         }
//     }
//     return array3D;
// }

// void ShowArray3D(int[,,] array3D){
//     for (int i =0; i <array3D.GetLength(0); i++){
//         for (int j =0; j <array3D.GetLength(1); j++){
//             for (int k =0; k <array3D.GetLength(2); k++){
//                 Console.Write($"{array3D[i,j,k]}({i},{j},{k}) "); 
//             }
//             Console.WriteLine();
//         }
//     }
// }

// Console.Write("Введите размер X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размер Y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размер Z: ");    
// int z = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение: ");    
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение: ");    
// int max = Convert.ToInt32(Console.ReadLine());
// while (max-min < x*y*z){
//     Console.WriteLine("Ошибка! ");
//     Console.Write("Введите минимальное значение: ");    
//     min = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите максимальное значение: ");    
//     max = Convert.ToInt32(Console.ReadLine());
// }
// int[,,] array3D = CreateArray3D(x, y, z, min, max);
// ShowArray3D(array3D);
// Console.WriteLine();



// // Задача № 62
// int[,] MatrixSpiral(int rows, int columns){
//     int[,] matrix = new int[rows, columns];
//     int count = 1;
//     for (int k =0; count <=rows*columns; k++){
//         for (int j = 0+k; j<=matrix.GetLength(1)-(1+k) && count <=rows*columns || j==k; j++){
//             matrix[0+k, j] = count;
//             count++;
//         }
//         for (int i = 1+k; i<matrix.GetLength(0)-(1+k) && count <=rows*columns; i++){
//             matrix[i, matrix.GetLength(1)-(1+k)] = count;
//             count++;
//         }
//         for (int j = matrix.GetLength(1)-(1+k); j>0+k && count <=rows*columns; j--){
//             matrix[matrix.GetLength(0)-(1+k), j] = count;
//             count++;
//         }
//         for (int i = matrix.GetLength(0)-(1+k); i>0+k && count <=rows*columns; i--){
//             matrix[i, 0+k] = count;
//             count++;
//         }
//     }
//     return matrix;
// }

// void ShowMatrix(int[,] matrix){
//     for (int i =0; i <matrix.GetLength(0); i++){
//         for (int j =0; j <matrix.GetLength(1); j++){
//             if (matrix[i,j]<10){
//                 Console.Write($"0{matrix[i,j]} ");
//             }
//             else {
//                 Console.Write($"{matrix[i,j]} ");
//             } 
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = MatrixSpiral(rows, columns);
// ShowMatrix(matrix);
// Console.WriteLine();