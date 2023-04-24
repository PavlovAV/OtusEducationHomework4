using OtusEducationHomework4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusEducationHomework4
{
    internal class GameSettings : IGameSetting
    {
        IGameSetting _gameSetting;
        public byte NumberAttempts { get { return _gameSetting.NumberAttempts; } }
        public byte LowerLimitRange { get { return _gameSetting.LowerLimitRange; } }
        public byte UpperLimitRange { get { return _gameSetting.UpperLimitRange; } }

        public GameSettings(IGameSettingOperations gameSettingOperations)
        {
            _gameSetting = gameSettingOperations.LoadSettings();
        }
    }
}
