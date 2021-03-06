using System;
using SadConsole;
using Console = SadConsole.Console;
using Microsoft.Xna.Framework;

namespace RogueSharpTest
{
    class Program
    {

        public const int Width = 80;
        public const int Height = 25;

        static void Main(string[] args)
        {
            // Setup the engine and creat the main window.
            SadConsole.Game.Create("C64.font", Width, Height);

            // Hook the start event so we can add consoles to the system.
            SadConsole.Game.OnInitialize = Init;

            // Hook the update event that happens each frame so we can trap keys and respond.
            SadConsole.Game.OnUpdate = Update;
                        
            // Start the game.
            SadConsole.Game.Instance.Run();

            //
            // Code here will not run until the game window closes.
            //
            
            SadConsole.Game.Instance.Dispose();
        }
        
        private static void Update(GameTime time)
        {
            // Called each logic update.

            // As an example, we'll use the F5 key to make the game full screen
            if (SadConsole.Global.KeyboardState.IsKeyReleased(Microsoft.Xna.Framework.Input.Keys.F5))
            {
                SadConsole.Settings.ToggleFullScreen();
            }
        }

        private static void Init()
        {
            // Any custom loading and prep. We will use a sample console for now

            Console startingConsole = new Console(Width, Height);
            startingConsole.Print(40, 12, "Hello SadConsole");

            // Set our new console as the thing to render and process
            SadConsole.Global.CurrentScreen = startingConsole;
        }
    }
}
