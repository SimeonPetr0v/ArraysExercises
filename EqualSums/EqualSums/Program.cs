namespace EqualSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] num = input.Split(" ");
            int[] arr = new int[num.Length];
            for(int i = 0; i < num.Length; i++)
            {
                arr[i] = int.Parse(num[i]);
            }

            int res = -1;

            for(int i = 0; i < arr.Length; i++)
            {
                int sum1 = 0;
                int sum2 = 0;
                for(int j = 0; j < i; j++)
                {
                    sum1 += arr[j];
                }
                for(int k = i + 1; k < arr.Length; k++)
                {
                    sum2 += arr[k];
                }
                if(sum1 == sum2)
                {
                    res = i;
                    break;
                }
            }
            if(res != -1)
            {
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}