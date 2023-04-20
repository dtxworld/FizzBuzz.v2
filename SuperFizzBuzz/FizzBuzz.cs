using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperFizzBuzz
{
    /// <summary>
    /// FizzBuzz v3.0
    /// </summary>
    public class FizzBuzz
    {
        private List<int> _rangeList;
        private List<(int, string)> _tokenList;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rangeSet"></param>
        /// <param name="tokenList"></param>
        public FizzBuzz(Tuple<int, int> rangeSet, List<(int, string)> tokenList)
        {
            _rangeList = GetRange(rangeSet);
            _tokenList = tokenList;
        }

        public string Output()
        {
            string returnValue = String.Empty;
            foreach (int x in _rangeList)
            {
                returnValue += x.FizzBuzzCheck(_tokenList) + Environment.NewLine;
            }
            return returnValue;
        }

        /// <summary>
        /// Get range of numbers
        /// </summary>
        /// <param name="intList"></param>
        /// <returns>List of sequential integers</returns>
        public static List<int> GetRange(Tuple<int, int> rangeSet)
        {
            List<int> returnList = new List<int>();

            if (rangeSet != null)
            {
                int from = rangeSet.Item1;
                int end = rangeSet.Item2;
                if (from > end)
                {
                    for (int i = from; i >= end; i--)
                    {
                        returnList.Add(i);
                    }
                }
                else
                {
                    for (int i = from; i <= end; i++)
                    {
                        returnList.Add(i);
                    }
                }
            }
            return returnList;
        }

        /// <summary>
        /// Gets user supplied set of integers
        /// </summary>
        /// <param name="intList"></param>
        /// <returns>User defined set of integers</returns>
        public static List<int> GetUserSuppliedOutput(List<int> intList)
        {
            List<int> returnList = new List<int>();
            // 'output for a user supplied set of integers, even if they’re not sequential'
            foreach (int i in intList)
            {
                returnList.Add(i);
            }
            
            return returnList;
        }
    }
}
