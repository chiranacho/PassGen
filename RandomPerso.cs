using System;
using System.Security.Cryptography;
namespace PasswordGenerator
{
    internal class RandomPerso
    {
        public int Next(int n)
        {
            if(n <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n), "The parameter must be greater than zero");
            }
            
            var byetArray = new byte[4];
            RandomNumberGenerator.Fill(byetArray);

            var randomInteger = BitConverter.ToUInt32(byetArray, 0);
            return Math.Abs((int)(randomInteger % n));
        }
    }
}
