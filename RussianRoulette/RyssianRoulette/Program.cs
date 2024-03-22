using Raylib_cs;
using RyssianRoulette;

const int screenWidth = 300;
const int screenHeight = 300;

Raylib.InitWindow(screenWidth, screenHeight, "Tic Tac Toe");
Raylib.SetTargetFPS(60);

Game game = new Game(screenWidth, screenHeight);

while (!Raylib.WindowShouldClose())
{
    game.Update();
    game.Draw();
}

Raylib.CloseWindow();
