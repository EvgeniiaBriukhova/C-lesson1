/* Назавем число "интересным" если его сумма
цифр четная

Создать двумерный массив состоящий из целых чисил.
Вывести на экран "интересные" элемнты массива */

// создаем функцию на заполнение и вывод на экран

int[,] CreateMatrix(int rowCount, int columsCount)//тело функции
{
    int[,] matrix = new int[rowCount, columsCount];
    Random rnd = new Random();//запрос на случайные числаб лучше создавать за пределами цикла

    for (int i = 0; i < matrix.GetLength(0); i++)// позволяет пройти по строкам GetLength- позвол. выяснить кол-во строк или столбцов
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // позволяет пройти по столбцам
        {

            matrix[i, j] = rnd.Next(1, 1000);

        }
    }
    return matrix;// выводим значение matrix
}

void ShowMatrix(int[,] matrix)
{
    for (int i =0; i < matrix.GetLength(0); i++)
{
    for (int j =0; j < matrix.GetLength(1); j++) 
    {
        Console.Write($"{matrix[i, j]} ");//вывод элементов в консоль
    }
    Console.WriteLine(); // для вывода информации ввиде таблицы
}
}
//создаем двумерный массив - вход программы
int[,] matrix = CreateMatrix(3, 4);
ShowMatrix(matrix);
{
    foreach (int e in matrix) //двумерный массив можно перебрать через foreach
    {
        if (isInteresting(e) == true)
        {
            Console.WriteLine(e);// вывидет true на екран
        }

    }
}
//создаем функцию для isInteresting тип bool
bool isInteresting(int value) // value целое число для проверки
{
    int sumOfDigits = getSumOfDigits(value);
    if (sumOfDigits % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}
// функция для вычисления суммы
int getSumOfDigits(int value)
{
    int sum = 0; // переменная для хранения
    while (value > 0)// пока значение > 0 цикл будет повторяться
    {
        sum = sum + value % 10; // получим самую правую цифру числа
        value = value / 10; // отрежим еще одну цифру
    }
    return sum; //возвращяем значение которое хранится в sum
}



