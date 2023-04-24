using OtusEducationHomework4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusEducationHomework4
{
    internal class Game : IGame
    {
        private readonly IGameSetting _gameSetting;
        public Game(IGameSetting gameSetting)
        {
            _gameSetting = gameSetting;
        }

        int pickedNumber;
        Random rnd = new Random();


        public void Run()
        {
            bool exitGame = false;
            pickedNumber = rnd.Next(_gameSetting.LowerLimitRange, _gameSetting.UpperLimitRange);
            Console.WriteLine($"У вас {_gameSetting.NumberAttempts} попыток угадать число.");
            Console.WriteLine($"Введите число от {_gameSetting.LowerLimitRange} до {_gameSetting.UpperLimitRange}");
            var numberAttempt = 1;
            string? key;
            int userNumber;
            while (!exitGame)
            {

                key = Console.ReadLine();
                if (!int.TryParse(key, out userNumber))
                    Console.WriteLine("Это не число! Будьте внимательны.");
                else
                {
                    if (userNumber == pickedNumber)
                    {
                        Console.WriteLine("Ура! Вы угадали!");
                        exitGame = true;
                    }
                    else
                    {
                        if (userNumber > pickedNumber)
                            Console.WriteLine("Загаданное число меньше введенного");
                        else if (userNumber < pickedNumber)
                            Console.WriteLine("Загаданное число больше введенного!");
                        numberAttempt++;
                        if (numberAttempt > _gameSetting.NumberAttempts)
                        {
                            Console.WriteLine($"Увы! Закончилось кол-во попыток. Загаданное число: {pickedNumber}!");
                            exitGame = true;
                        }
                    }
                }
            }
        }
    }
}
