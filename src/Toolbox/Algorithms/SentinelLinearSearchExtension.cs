namespace Toolbox.DataStructures
{
    public static class SentinelLinearSearchExtension
    {
        /// <summary>
        ///     Sentinel linear search avoids the unencessary upper bound  
        ///     check when iterating over a for loop to find an item.
        /// 
        ///    // Consider the following, which sentinel linear search avoids,
        ///    // that does two comparisons with each iteration:
        ///    //  - comparisson 1 = the upper bound check in the for loop: i < length
        ///    //  - comparisson 2 = the array[i] == elementToSearch
        ///
        ///    for (int i = 0; i < length; i++)
        ///    { 
        ///        if (array[i] == elementToSearch)
        ///        { 
        ///            return i;
        ///        }
        ///    }
        ///
        /// </summary>
        /// <typeparam name="T">They Type.</typeparam>
        /// <param name="array">The array or type T.</param>
        /// <param name="value">The value to search for in the array.</param>
        /// <returns>Returns the index of value in the array, else returns -1 if it isn't in the array.</returns>
        public static int IndexOf<T>(this T[] array, T value)
        {
            // Check if the value is equal to the last item,
            // if it is return the index of the last item.

            if (EqualityComparer<T>.Default.Equals(value, array[array.Length - 1]))
            {
                return array.Length - 1;
            }

            // Swap the last item for the value you are looking for.
            // This eliminates the need for the upper bound check
            // because if the last item is reached, we know value is
            // not in the array.

            T temp = array[array.Length - 1];
            array[array.Length - 1] = value;

            int i = 0;
            while (!EqualityComparer<T>.Default.Equals(value, array[i]))
            {
                i++;
            }

            // Put the original last item back.

            array[array.Length - 1] = temp;

            if(i < array.Length - 1)
            {
                // If the value was found before the last element,
                // then we know it is in the list and return it's index.

                return i;
            }
            else
            {
                // If the value was only found at the last element,
                // then we know it never was in the list and return -1.
                return -1;
            }
        }
    }
}
