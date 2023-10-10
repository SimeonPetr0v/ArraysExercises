namespace Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            int[]array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
            int num = int.Parse(Console.ReadLine());
            
            for (int i= 0;i < num; i++)
            {
                for(int j = array.Length - 1; j >= 0; j--)
                {
                    int temp = array[array.Length - 1];
                    array[array.Length - 1] = array[j];
                    array[j] = temp;

                }
            }
            Console.WriteLine(string.Join(" ", array));
            
        }
    }
}