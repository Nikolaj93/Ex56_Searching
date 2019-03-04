using System;

namespace Ex56_Searching
{
    public class Search
    {
        public static int FindPositionInList_Linear(int[] data, int value)
        {
            int n = data.Length;
            for (int i = 0; i < n; i++)
            {
                if (data[i] == value)
                    return i;
            }
            return -1;
        }

        public static int FindPositionInList_Binary(int[] data, int value)
        {
            int low = 0, high = data.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                // Check if value is present at mid
                if (data[mid] == value)
                    return mid;

                // If value greater, ignore left half 
                if (data[mid] < value)
                    low = mid + 1;

                // If value is smaller, ignore right half
                else
                    high = mid - low;
            }
            return -1;
        }
    }
}
