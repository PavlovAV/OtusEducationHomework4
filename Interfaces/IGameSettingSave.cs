using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusEducationHomework4.Interfaces
{
    internal interface IGameSettingSave : IGameSettingOperations
    {
        public void SaveSettings(IGameSetting gameSetting);
    }
}
