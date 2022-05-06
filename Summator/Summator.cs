namespace Summator
{
    public static class Summator
    {
        public static long Sum(int[] arr)
        {
            long sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        // Correct type of the variable sum and return type of method Average from int -> double, because:
        // when dividing an odd result of sum by an even separator, the result is not an integer. 
        public static double Average(int[] arr)
        {
            double sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum/arr.Length;
        }

        //Add new method for Summator. It`s calculate sum and return if is odd or even.
        public static string SumOddOrEven(int[] arr)
        {
            long sum = 0;

            foreach (var digit in arr)
            {
                sum += digit;
            }

            if (sum % 2 == 0)
            {
                return "Sum result is even!";
            }

            return "Sum result is odd!";
        }
    }
}
