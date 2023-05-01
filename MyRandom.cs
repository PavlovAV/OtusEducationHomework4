using OtusEducationHomework4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusEducationHomework4
{
    internal class MyRandom : IMyRandom
    {
        private readonly Random rnd = new Random();

        public byte GetNext(byte lowerLimitRange, byte upperLimitRange)
        {
            return (byte)rnd.Next(lowerLimitRange, upperLimitRange);
        }
    }
}
