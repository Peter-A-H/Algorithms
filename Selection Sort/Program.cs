using Math = SelectionSort.Math;

List<int> input = [5, 3, 6, 2, 10];

foreach (int item in Math.SelectionSort(input))
{
    Console.Write($"{item} ");
}

Console.WriteLine();

List<int> input1 = [4534, 46567, 78978, 345, 2455];

foreach (int item in Math.SelectionSort(input1))
{
    Console.Write($"{item} ");
}