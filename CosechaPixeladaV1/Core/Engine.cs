using Raylib_cs;
using CosechaPixeladaV1.Entities;

namespace CosechaPixeladaV1.Core
{
    public static class Engine
    {

        public static void Start(IScene scene)
        {

            Raylib.InitWindow(Global.ScreenWidth, Global.ScreenHeight, Global.Title);
            Raylib.SetTargetFPS(Global.FPS);

            scene.Init();

            while (!Raylib.WindowShouldClose())
            {
                float deltaTime = Raylib.GetFrameTime();
                scene.Update(deltaTime);

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.White);

                scene.Draw();

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}
