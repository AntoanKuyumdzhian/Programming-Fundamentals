namespace Longest_Increasing_Subsequence__LIS_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LIS
    {
        public static void Main()
        {
            int[] numbers = { 3, 14, 5, 12, 15, 7, 8, 9, 11, 10, 1 };

            int currPossition = 0;
            int currCounter = 1;
            var output = new List<int>();
            var sortedArray = numbers.Select(x => x).OrderBy(x => x).ToArray();

            if (numbers.Length > 1)
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    currPossition = i;
                    var tempList = new List<int>();
                    tempList.Add(numbers[i]);

                    for (int j = Array.IndexOf(sortedArray,numbers[currPossition]); j < sortedArray.Length -1; j++)
                    {
                        int currIndex = Array.IndexOf(numbers, sortedArray[j]);
                        int num1 = numbers[currIndex];
                        int nextIndex = Array.IndexOf(numbers, sortedArray[j + 1]);
                        int num2 = numbers[nextIndex];

                        if (nextIndex > currIndex)
                        {
                            currCounter++;
                            tempList.Add(numbers[nextIndex]);
                        }
                    }
                    if (tempList.Count > output.Count)
                    {
                        output = tempList;
                    }
                }
            }
            else
            {
                Console.WriteLine(numbers);
            }


        }
    }
}
