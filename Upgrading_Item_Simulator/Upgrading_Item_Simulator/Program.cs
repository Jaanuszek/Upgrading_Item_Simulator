// See https://aka.ms/new-console-template for more information
using Upgrading_Item_Simulator;

GameEngine game = new GameEngine(new Shop(), new Player(1000));
game.RunGame();
