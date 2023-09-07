using System;
using System.Linq;

namespace katas
{
    public class Solution
    {
        public int[] TwoSum()
        {
            int[] nums = new int[] { 11, 15, 2, 7 };
            int target = 9;

            //--------------------------------------

            int counter = 0;
            int[] twoSum = new int[2];

            foreach (int item in nums)
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[counter] + nums[i] == target)
                    {
                        twoSum[0] = i;
                        twoSum[1] = counter;

                        break;
                    }
                }

                counter++;
            }

            return twoSum;
        }

        public int LengthOfLongestSubstring()
        {
            string s = "abcabcbb";
            //string s = "bbbbb";
            //string s = "pwwkew";

            //--------------------------------------

            char[] charArray = s.ToCharArray();
            List<char> resultList = new List<char>();
            int resultLength = 0;

            foreach (char c in charArray)
            {
                if (!resultList.Contains(c))
                {
                    resultList.Add(c);
                }
                else
                {
                    int charIndex = resultList.IndexOf(c);
                    resultList = resultList.Skip(charIndex + 1).ToList();
                    resultList.Add(c);
                }

                resultLength = resultLength < resultList.Count ? resultList.Count : resultLength++;
            }

            return resultLength;
        }

        public bool IsPalindrome()
        {
            // compare the first integer to the last integer
            // if the integer has a length longer than three, we need to compare more than just the first and last integers
            // negative indicators (like the "-" in -1) are considered separate characters from the number they're associated with

            // convert to a char array

            int x = 121;

            //--------------------------------------

            char[] myNumber = x.ToString().ToCharArray();

            for (int i = 0; i < myNumber.Length - 1; i++)
            {
                int lastNumber = myNumber.Length - (i + 1);

                if (myNumber[i] != myNumber[lastNumber])
                {
                    return false;
                }
            }

            return true;
        }

        public bool ContainsDuplicate()
        {
            // loop through array and compare the first value to the others until a positive match is made
            // once a positive match occurs, break out of the loop and return true
            // if no positive match occurs, move to the next value and repeat the matchmaking
            // can use a .Contains<int>(i) method to check if the array contains the iterated value
            // need to make sure to exclude the number currently being searched for
            // to do so, remove the number currently being searched for from the remaining numbers

            //int[] nums = new int[] {1, 2, 3, 1};
            //int[] nums = new int[] { 1, 2, 3, 4 };
            //int[] nums = new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            //int[] nums = new int[] { 7, 6, 5, 4, 3, 2, 2 };
            int[] nums = new int[] { 22, 19, 5, 65, 22 };

            //--------------------------------------

            List<int> remainingNums = nums.ToList<int>();

            for (int i = 0; i <= nums.Length - 1; i++)
            {
                remainingNums.RemoveAt(0);

                if (remainingNums.Contains<int>(nums[i]))
                {
                    return true;
                }
            }

            return false;

            //--------------------------------------

            Array.Sort(nums);

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    return true;
                }
            }

            return false;
        }
    }
}