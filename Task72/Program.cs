/* Задача 72: Заданы 2 массива: info и data. 
В массиве info хранятся двоичные представления 
нескольких чисел (без разделителя). В массиве 
data хранится информация о количестве бит, которые 
занимают числа из массива info. Напишите программу, 
которая составит массив десятичных представлений 
чисел массива data с учётом информации из массива info.

входные данные:
data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
info = {2, 3, 3, 1 }
выходные данные:
1, 7, 0, 1 */

void ArrayOfDecimalRepresentationsArrayNumbers(int[] data, int[] info)
{
    int[] resultArray = new int[info.Length];
    int k = 0;
    for (int i = 0; i < info.Length; i++)
    {
        int elementOfResultArray = 0;
        for (int j = info[i]; j > 0; j--)
        {
            elementOfResultArray+= Convert.ToInt32(Math.Pow(2, j-1)) * data[k];
            k++;
        }
        resultArray[i] = elementOfResultArray;
        Console.Write($"{resultArray[i]}\t");
    }
            
}

int[] data = {0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = {2, 3, 3, 1};
ArrayOfDecimalRepresentationsArrayNumbers(data, info);
