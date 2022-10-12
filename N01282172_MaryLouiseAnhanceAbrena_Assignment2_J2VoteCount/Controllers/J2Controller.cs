using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Web.Http;
using System.Xml.Schema;

namespace N01282172_MaryLouiseAnhanceAbrena_Assignment2_J2RollTheDice.Controllers
{
    public class J2Controller : ApiController
    {

        /// <summary>
        /// Returning how many ways two dice can sum to 10
        /// </summary>
        /// <param name="m">First dice</param>
        /// <param name="n">Second dice</param>
        /// <param name="ways">How many times the sides of two dice can sum to 10</param>
        /// <returns>
        /// How many ways the sides of the dices can sum to 10
        /// For example m = 9 n = 3
        /// 7    3  = 10
        /// 8    2  = 10
        /// 9    1  = 10
        /// It should return: There are 5 total ways to get the sum 10.
        /// </returns>
        /// <example>
        /// Get api/j2/dicegame/8/9 --> There are 8 total ways to get the sum 10.
        /// Get api/j2/dicegame/12/19 --> There are 9 total ways to get the sum 10.
        /// </example>

        [HttpGet]
        [Route("api/J2/dicegame/{m}/{n}")]
         public IEnumerable<string> Get(int m, int n)
        {
            int ways = 0;

            for (int i = 1; i <= m; i++)
                for (int k = 1; k <= n; k++)
                {
                    if (i + k == 10)
                    {
                        ways++;
                    }
                }
            return new string[] 
            {
                "There are " + ways + " ways to get the sum 10."}
            ;
        }
    }
}
