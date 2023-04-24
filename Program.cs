using OtusEducationHomework4;
using OtusEducationHomework4.Interfaces;

var gameSettings = new GameSettings(new GameSettingFromFile());
var game = new Game(gameSettings);
game.Run();

/*

*/