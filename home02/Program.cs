// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int[, ] CreateArrayA(int m, int n)
{
    int[, ] A = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            A[i, j] = new Random().Next(1, 100);
            Console.Write(A[i, j] + "\t");
        }
    Console.WriteLine();
    }
Console.WriteLine();        
return A;
}


int[, ] CreateArrayB(int m, int n)
{
    int[, ] B = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            B[i, j] = new Random().Next(1, 100);
            Console.Write(B[i, j] + "\t");
        }
    Console.WriteLine();
    }    
return B;
}


void CheckMatrix(int[, ] A, int[, ] B)
{  
    Console.WriteLine();
    int[, ] result = new int[A.GetLength(0), A.GetLength(1)];
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for(int j = 0; j < A.GetLength(1); j++)
        {
            result[i, j] = A[i, j] * B[i, j];
            Console.Write(result[i, j] + "\t");
        }
        Console.WriteLine();
    }  
}

CheckMatrix(CreateArrayA(4, 4), CreateArrayB(4, 4));
