int[] arr1 = { 3, 1, 4, 1, 5, 9, 2, 6, 5 };
int max = int.MinValue, secondMax = int.MinValue;
foreach (int n in arr1)
{
    if (n > max) { secondMax = max; max = n; }
    else if (n > secondMax && n != max) secondMax = n;
}
Console.WriteLine($"Task 1 - Second largest: {secondMax}");

//== ==================================================

int[,] matrix2 = { { 9, 3, 7 }, { 1, 5, 8 }, { 4, 2, 6 } };
int rows = matrix2.GetLength(0), cols = matrix2.GetLength(1);
int[] flat = new int[rows * cols];
int idx = 0;
for (int i = 0; i < rows; i++) for (int j = 0; j < cols; j++) flat[idx++] = matrix2[i, j];
Array.Sort(flat);
idx = 0;
for (int i = 0; i < rows; i++) for (int j = 0; j < cols; j++) matrix2[i, j] = flat[idx++];
Console.Write("Task 2 - Sorted 2D: ");
for (int i = 0; i < rows; i++) for (int j = 0; j < cols; j++) Console.Write($"{matrix2[i, j]} ");
Console.WriteLine();

//============================================================================

int[] arr3 = { 10, 20, 30, 40, 50 };
int deleteAt = 2;
int[] result3 = new int[arr3.Length - 1];
int ni = 0;
for (int i = 0; i < arr3.Length; i++) { if (i != deleteAt) result3[ni++] = arr3[i]; }
Console.WriteLine($"Task 3 - After delete: {string.Join(", ", result3)}");

//==========================================================================

int[,] matrix4 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
int diagSum = 0;
for (int i = 0; i < matrix4.GetLength(0); i++) diagSum += matrix4[i, i];
Console.WriteLine($"Task 4 - Diagonal sum: {diagSum}");

//=============================================================
