/* Создать двумерный массив с размерами 3х5
состоящий из целых чисел.
Вывести его элементы на экран. */


//тело кода до добавления функции
/* int[,] matrix = new int[3, 5];
Random rnd = new Random();//запрос на случайные числаб лучше создавать за пределами цикла

for (int i = 0; i < matrix.GetLength(0); i++)// позволяет пройти по строкам GetLength- позвол. выяснить кол-во строк или столбцов
{
    for (int j =0; j < matrix.GetLength(1); j++) // позволяет пройти по столбцам
{

        matrix[i, j] = rnd.Next(1, 11);

    }
} */

//Вывидим заполненный массив на экран для этого нужен еще один цикл for

/* for (int i =0; i < matrix.GetLength(0); i++)
{
    for (int j =0; j < matrix.GetLength(1); j++) 
    {
        Console.Write($"{matrix[i, j]} ");//вывод элементов в консоль
    }
    Console.WriteLine(); // для вывода информации ввиде таблицы
} */


// создаем функцию на заполнение и вывод на экран
int[,] CreateMatrix (int rowCount, int columsCount)//тело функции
{
int[,] matrix = new int[rowCount, columsCount];
Random rnd = new Random();//запрос на случайные числаб лучше создавать за пределами цикла

for (int i = 0; i < matrix.GetLength(0); i++)// позволяет пройти по строкам GetLength- позвол. выяснить кол-во строк или столбцов
{
    for (int j =0; j < matrix.GetLength(1); j++) // позволяет пройти по столбцам
{

        matrix[i, j] = rnd.Next(1, 11);

    }
}
return matrix;// выводим значение matrix
}
//код вывода массива на экран тоже ввиде функции - void

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
//создаем переменную matrix для хронения массива
int[,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix); //вывод массива в консоль