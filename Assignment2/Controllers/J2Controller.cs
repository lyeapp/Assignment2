using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// determines how many ways one can roll the value of 10 with two dice
        /// </summary>
        /// <param name="m">
        /// total no of sides in first die
        /// </param>
        /// <param name="n">
        /// total no of sides in second die
        /// </param>
        /// <returns>
        /// number of ways to roll the value of 10
        /// </returns>
        /// <example>
        /// GET api/J2/DiceGame/6/8 => "There are 5 total ways to get the sum 10."
        /// </example>
        /// <example>
        /// GET api/J2/DiceGame/12/4 => "There are 4 ways to get the sum 10."
        /// </example>
        /// <example>
        /// GET api/J2/DiceGame/3/3 => "There are 0 ways to get the sum 10."
        /// </example>
        /// <example>
        /// GET api/J2/DiceGame/5/5 => "There is 1 way to get the sum 10."
        /// </example>
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string RollTen(int m, int n)
        {
            int count = 0;

            // Iterate through all possible combinations
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    // If the sum is 10,  count is incremented by 1
                    if (i + j == 10)
                    {
                        count++;
                    }
                }
            }

            // Return message with the count
           if (count == 1)
            {
                return "There is 1 way to get the sum 10.";
            }
            else
            {
                return $"There are {count} total ways to get the sum 10.";
            }
        }



    }
}
