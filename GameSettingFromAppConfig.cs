using OtusEducationHomework4.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusEducationHomework4
{
    internal class GameSettingFromAppConfig : IGameSettingLoad
    {
        public IGameSetting LoadSettings()
        {
            var numberAttempts = Convert.ToByte(ConfigurationManager.AppSettings["NumberAttempts"]);
            var lowerLimitRange = Convert.ToByte(ConfigurationManager.AppSettings["LowerLimitRange"]);
            var upperLimitRange = Convert.ToByte(ConfigurationManager.AppSettings["UpperLimitRange"]);
            return new GameSetting() { NumberAttempts = numberAttempts, LowerLimitRange = lowerLimitRange, UpperLimitRange = upperLimitRange };
        }
    }
}
