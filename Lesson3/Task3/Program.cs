// Дан массивб который нужно проверить на 
// четность и заменить четные числа на 0

void ZeroEvenElements(int[] arr) // Спараметрамиб без возвращения значения
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) // проверка четности
        {
            arr[i] = 0; // если условие выполняется присваеваем значение 0
        }
    }
}
void PrintArray(int[] arr) // Функция с парамерами, без возв. значения
{
    foreach (int e in arr) // служит для перебора элементов
    {
        Console.Write($"{e} "); // вывод переменной
    }
}
int[] array = {1,2,3,4,5};
ZeroEvenElements(array); 
PrintArray(array);