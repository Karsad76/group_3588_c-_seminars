// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Clear();
Print3DArrayWithIndex(Fill3DArrayUniqueValues(Fill1DArrUniqueRandomize()));

// METHODS
int[,,] Fill3DArrayUniqueValues(int[] valueArr)   // fill 3d array method with unique values
{
    int[,,] array3D = new int[4, 4, 5];
    int index = 0;

    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {

                array3D[i, j, k] = valueArr[index];
                index++;
            }
        }
    }
    return array3D;
}

void Print3DArrayWithIndex(int[,,] matrix)    // method for print 3d array
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write("   ".Substring(matrix[i, j, k].ToString().Length) + matrix[i, j, k] + " (" + i + ", " + j + ", " + k + ") ");
            }
            Console.WriteLine();
        }
    }
}

int[] Fill1DArrUniqueRandomize() // method for generate randomize array with unique values
{
    int[] nums = Enumerable.Range(10, 90).ToArray();
    var rnd = new Random();

    for (int i = 0; i < nums.Length; i++)   // Shuffle the array
    {
        int randomIndex = rnd.Next(nums.Length);
        int temp = nums[randomIndex];
        nums[randomIndex] = nums[i];
        nums[i] = temp;
    }
    return nums;
}

