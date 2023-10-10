namespace TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for(int i = 0; i< arr.Length; i++)
            {
                int n = arr[i];
                bool topN = true;
                for(int j = i + 1; j < arr.Length; j++)
                {
                    int nextNumber = arr[j];
                    if(nextNumber >= n)
                    {
                        topN = false;
                        break;
                    }
                }
                if(topN)
                {
                    Console.Write($"{n} ");
                }
            }
        }
    }
}