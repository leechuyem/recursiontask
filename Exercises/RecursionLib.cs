using System;
using System.Collections.Generic;

namespace Exercises
{
    public class RecursionLib {

        public int FactorialRec(int num, int ans = 1) {

            if (num == 0) {
                return ans;
            }

            return FactorialRec(num-1, ans*num);
            // return num*FactorialRec(num-1)
        }

        /// <summary>
        /// Creates a list of numbers from 1 to num.  Initialise numsList with empty List.
        /// </summary>
        /// <param name="num"></param>
        /// <param name="numsList"></param>
        /// <returns></returns>
        public List<int> CountRec(int num, List<int> numsList) {

            if(numsList.Count < num) {
                numsList.Add(numsList.Count + 1);
                return CountRec(num, numsList);
            }
            return numsList;
        }

        /// <summary>
        /// Returns the result of num to the power of pow.
        /// </summary>
        /// <param name="num"></param>
        /// <param name="pow"></param>
        /// <param name="ans"></param>
        /// <returns></returns>
        public long ExponentialRec(int num, int pow, long ans = 1) {
            if(pow == 0) {
                return ans; 
            } else if(pow == 1) {
                return num; 
            } else {
                ans = num * ExponentialRec(num, pow - 1);
                return ans; 
            }

        }

        /// <summary>
        /// Returns word (string) in reverse order.  Treats all characters the same.
        /// </summary>
        /// <param name="word"></param>
        /// <param name="revWord"></param>
        /// <returns></returns>    
        public string WordReverseRec(string word, string revWord = "") {
            if ((word == null) || (word.Length <= 1)) {
                return word;
            }

           revWord = WordReverseRec(word.Substring(1)) + word[0];
           return revWord;
        }



    }
}
