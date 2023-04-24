using OtusEducationHomework4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusEducationHomework4
{
    internal class GameSetting : IGameSetting
    {
        public byte NumberAttempts { get; set; }

        public byte LowerLimitRange { get; set; }

        public byte UpperLimitRange { get; set; }
    }
}
