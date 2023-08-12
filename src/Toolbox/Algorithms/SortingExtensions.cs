namespace Toolbox.Algorithms
{
    public static class SortingExtensions
    {
        public static void BubbleSort<T>(this T[] array) where T : IComparable
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        // Swap arr[j] and arr[j+1] because
                        // arr[j] is bigger than arr[j+1]

                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}
