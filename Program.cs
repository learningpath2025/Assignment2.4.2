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
                Console.Write("Input the 1st number :");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Input the 2nd number :");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Input the 3rd number :");
                double num3 = Convert.ToDouble(Console.ReadLine());
                string result = FindLargest(num1, num2, num3);
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e}");
            }
        }
        public static string FindLargest(double num1, double num2, double num3)
        {
            if (num1 >= num2 && num1 >= num3)
            {
                return "The 1st Number is the greatest among three";
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                return "The 2nd Number is the greatest among three";
            }
            else
            {
                return "The 3rd Number is the greatest among three";
            }
        }
    }
}
