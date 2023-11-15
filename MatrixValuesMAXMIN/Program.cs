/*

//2.1 MATRINX IN PYTHON BIM BIM BAM BAM

//переменная для определения размерности
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
*/

/*
//Opposite values 2.2 task

//делаем длинну массива считываемую с консоли
int n;
Console.WriteLine("Введите длину массива:");
n = Convert.ToInt32(Console.ReadLine());

//делаем массивчик
int[] numbers = new int[n];

//Заполнение массива
for (int j = 0; j < numbers.Length; j++)
{
    Console.WriteLine($"Значение {j} элемента массива:");
    numbers[j] = Convert.ToInt32(Console.ReadLine());
}

//ввыод массива
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

//пробежка по массиву
bool found = false; //типо крутая переменная, что нашел совпадения

for (int i = 0; i < numbers.Length; i++)
{
    for (int j = i + 1; j < numbers.Length; j++)
    {
        if (numbers[i] + numbers[j] == 0)
        {
            found = true;
            Console.WriteLine($"Противоположные числа найдены: {numbers[i]} (индекс {i}) и {numbers[j]} (индекс {j})");
        }
    }
}
*/

//ласт таск

// Ввод количества дней в таблице
Console.WriteLine("Введите количество дней в таблице =>3:");
int daysCount = Convert.ToInt32(Console.ReadLine());

//мини проверка что больше 3 дней или равно
if (daysCount < 3)
{
    Console.WriteLine("количество дней должно быть не менее 3.");
    return;
}

// Ввод значений температуры для каждого дня уфуфуфуф, пробежечки по массиву
double[] temperatures = new double[daysCount];
Console.WriteLine("Введите температуру:");

for (int i = 0; i < daysCount; i++)
{
    Console.Write($"День {i + 1}: ");
    temperatures[i] = Convert.ToDouble(Console.ReadLine());
}

// Поиск локальных минимумов и максимумов, типо умным насрал
Console.WriteLine("\nРезультат:");

for (int i = 0; i < daysCount; i++)
{
    double currentTemperature = temperatures[i];
    bool isMax = true;  //зачем не скажу, для проверки нужно
    bool isMin = true;

    for (int j = 0; j < daysCount; j++)
    {
        if (i != j)
        {
            if (currentTemperature >= temperatures[j])
            {
                isMin = false;
            }                                                   // а тута мои проверочки

            if (currentTemperature <= temperatures[j])
            {
                isMax = false;
            }
        }
    } 

    if (isMax)
    {
        Console.WriteLine($"День {i + 1}: {currentTemperature} как биток нынче, максимальные цифры короче");
    }
    else if (isMin)
    {
        Console.WriteLine($"День {i + 1}: {currentTemperature} а тут крипта упала, минимум");
    }
}