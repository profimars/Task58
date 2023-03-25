// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
//https://github.com/profimars/Task58
void CreateMatrix(int[,] A)
{
    int m = A.GetLength(0);
    int n = A.GetLength(1);
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            A[i, j] = rnd.Next(1, 9);
        }
}

void PrintMatrix(int[,] A)
{
    Console.WriteLine();
    int m = A.GetLength(0);
    int n = A.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            Console.Write($"{A[i, j],3}   ");
        Console.WriteLine();
    }
}

int[,] MatrixMultiplication(int[,] A, int[,] B)
{
    int mA = A.GetLength(0);
    int nA = A.GetLength(1);
    int mB = B.GetLength(0);
    int nB = B.GetLength(1);
    int[,] C = new int[mA, nA];
    for (int i = 0; i < mA; i++)
    {
        Console.WriteLine();
        for (int j = 0; j < nB; j++)
        {
            int sum = 0;
            for (int k = 0; k < mB; k++)
            {
                int cc = A[i, k] * B[k, j];
                sum = sum + cc;
                C[i, j] = sum;
                Console.Write($"{cc,3}({A[i, k]} * {B[k, j]}); ");
            }
        }
    }
    Console.WriteLine();
    return C;
}

Console.WriteLine("Введите количество строк матрицы m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы n");
int n = Convert.ToInt32(Console.ReadLine());
int[,] A = new int[m, n];
CreateMatrix(A);
PrintMatrix(A);
int[,] B = new int[m, n];
CreateMatrix(B);
PrintMatrix(B);
int[,] C = MatrixMultiplication(A, B);
PrintMatrix(C);
