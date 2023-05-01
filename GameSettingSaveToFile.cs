using OtusEducationHomework4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusEducationHomework4
{
    internal class GameSettingSaveToFile : GameSettingFromFile, IGameSettingSave
    {
        public GameSettingSaveToFile(string fileName) : base(fileName)
        {

        }

        public void SaveSettings(IGameSetting gameSetting)
        {
            Console.WriteLine($"Saved {gameSetting?.ToString()} to file {_fileName}");
        }
    }
}
