namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] arrays = new int[num];
            int sum = 0;
            for (int i = 0; i < arrays.Length; i++)
            {
                arrays[i] = int.Parse(Console.ReadLine());
                sum += arrays[i];

            }
            Console.WriteLine(string.Join(" ", arrays));
            Console.WriteLine(sum);

        }
    }
}