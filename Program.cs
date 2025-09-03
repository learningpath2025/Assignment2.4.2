namespace Assignment2._4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetInputAndFindLargest();
        }

        public static void GetInputAndFindLargest()
        {
            try
            {
                Console.Write("How many numbers are you planning to compare: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] numbers = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Input the {i + 1} number :");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }
                int maxIndex = 0;
                for (int i = 1; i < n; i++)
                {
                    if (numbers[i] > numbers[maxIndex])
                    {
                        maxIndex = i;
                    }
                }
                Console.WriteLine($"Largest value is {numbers[maxIndex]}");
                Console.WriteLine($"Index position of {numbers[maxIndex]} is {maxIndex}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e}");
            }
        }
    }
}
