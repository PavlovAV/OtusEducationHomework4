using OtusEducationHomework4;
using OtusEducationHomework4.Interfaces;

var gameSet = new GameSettingSaveToFile("GameSettings.xml");
var gameSettings = new GameSettings(gameSet);
var game = new Game(gameSettings, new MyRandom());
game.Run();
if (gameSet is not null && gameSet is IGameSettingSave)
{
    (gameSet as IGameSettingSave).SaveSettings(gameSettings);
}
