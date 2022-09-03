﻿int[] GetArray(int size, int minValue, int maxValue)
{
int[] res = new int[size];

for (int i = 0; i < size; i++)
{
res[i] = new Random().Next(minValue, maxValue + 1);
}
return res;
}

int[] PositiveAndNegativeSum(int[] array)
{
int[] res = new int[2];

for (int i = 0; i < array.Length; i++)
{
if (array[i] > 0)
{
res[0] += array[i];
}
else
{
res[1] += array[i];
}

}

return res;
}

int[] myArray = GetArray(10,-100, 100);
int[] result = PositiveAndNegativeSum(myArray);
Console.WriteLine(String.Join(" ", myArray));
Console.WriteLine(String.Join(" ", result));