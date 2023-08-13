namespace Toolbox.DataStructures
{
    public static class ReverseStringExtension
    {
        public static string Reverse(this string value)
        {
            int startIndex = 0;
            int endIndex = value.Length - 1;

            // First reverse the whole string

            char[] reversedArray = Reverse(value.ToCharArray(), startIndex, endIndex);

            for(int i = 0; i <= reversedArray.Length; i++)
            {
                if (i == reversedArray.Length || reversedArray[i] == ' ')
                {
                    // Reverse the individual words, separated by spaces

                    reversedArray = Reverse(reversedArray, startIndex, i - 1);

                    // Reset the startIndex to the beginning of the next word

                    startIndex = i + 1;
                }
            }

            return new string(reversedArray);
        }

        private static char[] Reverse(char[] value, int startIndex, int endIndex)
        {
            char temp;

            while(startIndex < endIndex)
            {
                // Swap the character at startIndex
                // with the character at endIndex

                temp = value[startIndex];
                value[startIndex] = value[endIndex];
                value[endIndex] = temp;

                // Increment the startIndex
                // Decrement the endIndex

                startIndex++;
                endIndex--;
            }

            return value;
        }
    }
}
