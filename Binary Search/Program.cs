static int BinarySearch(int[] input, int itemToSearch)
{
    Array.Sort(input);
    int smallestElement = 0;
    int largestElement = input.Length - 1;

    while (smallestElement <= largestElement)
    {
        int middleElement = (smallestElement + largestElement) / 2;
        int pickedElement = input[middleElement];

        if (pickedElement == itemToSearch) return middleElement;
        if (pickedElement > itemToSearch) largestElement = middleElement - 1;
        else smallestElement = middleElement + 1;
    }

    return -1;
}

int[] inputArr = [9, 1, 7, 3, 5];

Console.WriteLine(BinarySearch(inputArr, 3)); //1
Console.WriteLine(BinarySearch(inputArr, 9)); //4