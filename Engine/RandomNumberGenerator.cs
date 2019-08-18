using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace Engine
{
    // Complex version of a Random Number Generator 
    // @Author: Scott Lilly
    class RandomNumberGenerator
    {
        private static readonly RNGCryptoServiceProvider _generator = new RNGCryptoServiceProvider();
        public static int NumberBetween(int minimumValue, int maximumValue)
        {
            byte[] randomNumber = new byte[1];
            _generator.GetBytes(randomNumber);

            double asciiValueOfRandomCharacter = Convert.ToDouble(randomNumber[0]);

            /* We are using Math.Max, and subtracting 0.00000000001
             * to ensure "multiplier will always be between 0.0 and .999999999999
             * otherwise its possible for it to be "1", which will cause problems in the rounding
             */
             double multiplier = Math.Max(0, (asciiValueOfRandomCharacter / 255d) - 0.00000000001d);

            // We need to add one to the range, to allow for the rounding down with Math.Floor
            int range = maximumValue - minimumValue + 1;
            double randomValueInRange = Math.Floor(multiplier * range);

            return (int)(minimumValue + randomValueInRange);
        }
    }
}
