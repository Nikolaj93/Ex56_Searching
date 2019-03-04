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
                {
                    return i;
                }   
            }
            return -1;
        }

        public static int FindPositionInList_Binary(int[] data, int low, int high, int value)
        {
            //     int low = 0, high = data.Length - 1;
            //     while (low <= high)
            //     {
            //         int mid = low + (high - low) / 2;
            //
            //         // Check if value is present at mid
            //         if (data[mid] == value)
            //         {
            //             return mid;
            //         } 
            //         // If value greater, ignore left half 
            //         if (data[mid] < value)
            //         {
            //             low = mid + 1;
            //         }
            //         // If value is smaller, ignore right half
            //         else
            //         {
            //             high = mid - low;
            //         }
            //     }
            //     return -1;

            // Øvelse 3: Binær søgning med rekursion

            
            if (high >= low)
            {
                int mid = low + (high - low) / 2;
                // If the element is present at the 
                // middle itself 
                if (mid == value)
                {
                    return mid;
                }
                // If element is smaller than mid, then 
                // it can only be present in left subarray
                if (mid > value)
                {
                    return FindPositionInList_Binary(data, low, mid - 1, value);
                }
                // Else the element can only be present 
                // in right subarray 
                return FindPositionInList_Binary(data, mid + 1, high, value);
            }
            // We reach here when element is not present 
            // in array 
            return -1;
        }
    }
}
