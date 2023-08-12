namespace Toolbox.Algorithms
{
    public class Fibonacci
    {
        public static IEnumerable<int> Generate(int maxValue = 0)
        {
            int previous = 0;
            int current = 1;
            int next = 0;

            yield return previous;
            yield return current;

            while (maxValue == 0
                || next < maxValue) 
            {
                next = previous + current;
                yield return next;

                previous = current;
                current = next;
            }
        }
    }
}
