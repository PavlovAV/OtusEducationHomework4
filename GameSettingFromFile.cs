using OtusEducationHomework4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OtusEducationHomework4
{
    internal class GameSettingFromFile : IGameSettingOperations
    {
        string _fileName = "GameSettings.xml";
        public GameSettingFromFile()
        { }
        public GameSettingFromFile(string fileName)
        { 
            _fileName = fileName;
        }
        public IGameSetting LoadSettings()
        {
            XDocument xdoc = XDocument.Load(_fileName);
            var numberAttempts = Convert.ToByte(xdoc.Descendants("NumberAttempts").First().Value);
            var lowerLimitRange = Convert.ToByte(xdoc.Descendants("LowerLimitRange").First().Value);
            var upperLimitRange = Convert.ToByte(xdoc.Descendants("UpperLimitRange").First().Value);
            return new GameSetting() { NumberAttempts = numberAttempts, LowerLimitRange = lowerLimitRange, UpperLimitRange = upperLimitRange };
        }
    }
}
