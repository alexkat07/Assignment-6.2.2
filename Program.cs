using System.Runtime.Intrinsics.X86;

namespace Assignment_6._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4 };

            int[] result = new int[nums.Length];
            int prefix = 1;
            int postfix = 1;

            //for every index in nums were putting its correspoding prefix in the same index insided the result array
            //so if we want to know the prefix of nums[i] we can find it in results[i]
            
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = prefix;
                prefix *= nums[i];
            }

            //start from the end of the list and multipy each index of result by its postfix to get the final result

            for (int i = nums.Length - 1; i >= 0; i--) 
            {
                result[i]*=postfix;
                postfix *= nums[i];
            }
            foreach (int num in result) 
            { 
                Console.Write(num + " ");
            }
        }
    }
}
