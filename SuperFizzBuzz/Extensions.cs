using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperFizzBuzz
{
    public static class Extensions
    {
        /// <summary>
        /// Applies FizzBuzz rules
        /// </summary>
        /// <param name="value"></param>
        /// <param name="tupleList"></param>
        /// <returns></returns>
        public static string FizzBuzzCheck(this int value, List<(int dividedBy, string token)> tokenRuleList)
        {
            string returnValue = String.Empty;
            StringBuilder sb = new StringBuilder();
            for(int x = 0; x < tokenRuleList.Count(); x++)
            {
                if (value % tokenRuleList[x].dividedBy == 0)
                {
                    sb.Append(tokenRuleList[x].token);
                }
            }
            return String.IsNullOrEmpty(sb.ToString()) ? value.ToString() : sb.ToString();
        }
    }
}