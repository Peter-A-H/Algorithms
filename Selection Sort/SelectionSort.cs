namespace SelectionSort;

public static class Math
{
    private static int FindSmallest(List<int> input)
    {
        int smallestElement = input[0];
        int smallestIndex = 0;

        for (int i = 0; i < input.Count; i++)
        {
            if (input[i] < smallestElement)
            {
                smallestElement = input[i];
                smallestIndex = i;
            }
        }

        return smallestIndex;
    }

    public static int[] SelectionSort(List<int> input)
    {
        int[] sortedArray = new int[input.Count];
        int count = input.Count;

        for (int i = 0; i < count; i++)
        {
            int indexOfSmallestElement = FindSmallest(input);
            int smallestElement = input.ElementAt(indexOfSmallestElement);
            sortedArray[i] = smallestElement;
            input.RemoveAt(indexOfSmallestElement);
        }

        return sortedArray;
    }
}