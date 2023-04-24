using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusEducationHomework4.Interfaces
{
    internal interface IGameSetting
    {
        byte NumberAttempts { get; }
        byte LowerLimitRange { get; }
        byte UpperLimitRange { get; }

    }
}
