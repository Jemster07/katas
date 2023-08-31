using System;

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
    }
}