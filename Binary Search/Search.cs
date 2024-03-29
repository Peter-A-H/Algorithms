﻿namespace Binary_Search;

public static class BinarySearch
{
    public static object Search(int[] input, int itemToSearch)
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

        return "null";
    }
}