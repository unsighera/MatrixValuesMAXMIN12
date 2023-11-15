//2.1 MATRINX IN PYTHON BIM BIM BAM BAM

//переменная для определения размерности
using System.Data;

int n;

//вводим размерность массива
Console.WriteLine("Введите кол-во строк, ну и столбцов в матрице (n <= 100):");
n = Convert.ToInt32(Console.ReadLine());

//ввдоим условие для n
if (n > 100)
{
    Console.WriteLine("Введено неверное значение для n, введите его повторно:");
    n = Convert.ToInt32(Console.ReadLine());
}

//определяем сам двумерный массив, ну матрицу эту стремную
int[,] matrix = new int[n, n];


//заполняем массивчик
int row = matrix.GetUpperBound(0) + 1;
int col = matrix.Length / row;

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        Console.WriteLine($"Введите значение для элемента на позиции {i}, {j}");
        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

PrintMatrix();
isMatrixSymmetric(matrix, row, col);

//метод вывода массива
void PrintMatrix()
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.Write(matrix[i, j]);
        }
        Console.WriteLine();
    }
}

//Функция матрицы 
static bool isMatrixSymmetric(int[,] matrix, int row, int col)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            if (matrix[i, j] != matrix[j, i])
            {
                Console.WriteLine("Матрица НЕ симметричная");
                return false;
            }
        }
    }
    Console.WriteLine("Матрица симметричная");
    return true;
}
