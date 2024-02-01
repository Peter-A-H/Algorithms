static int BinarySearch(int[] input, int item)
{
    Array.Sort(input);
    int low = 0;
    int high = input.Length - 1;

    while (low <= high)
    {
        int mid = (low + high) / 2;
        int guess = input[mid];

        if (guess == item) return mid;
        if (guess > item) high = mid - 1;
        else low = mid + 1;
    }

    return -1;
}

int[] inputArr = [9, 1, 7, 3, 5];

Console.WriteLine(BinarySearch(inputArr, 3)); //1
Console.WriteLine(BinarySearch(inputArr, 9)); //4