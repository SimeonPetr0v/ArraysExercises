namespace Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int seq = 1;
            int bestSeq = 0;
            int bestSeqN = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                int curNum = arr[i];
                for(int j = 1 + 1; j < arr.Length; j++)
                {
                    int rNum = arr[j];
                    if(curNum == rNum)
                    {
                        seq += 1;

                    }
                    else
                    {
                        break;
                    }
                }
                if(seq > bestSeq)
                {
                    bestSeq = seq;
                    bestSeqN = arr[i];
                }
                seq = 1;
            }
            for(int k = 0; k<bestSeq; k++)
            {
                Console.Write($"{bestSeqN}");
            }
        }
    }
}