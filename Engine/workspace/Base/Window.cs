using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SFML;
using SFML.Graphics;
using SFML.Window;

namespace CC__graphical_framework.Engine.workspace.Base
{

    internal class Window(uint width, uint height, string title)
    {
        public static RenderWindow? windowsfml;


        public void Run()
        {
            windowsfml = new RenderWindow(new VideoMode(width, height), title);
            
        }


        public bool IsOpen() { return windowsfml.IsOpen; }
        public void Display() => windowsfml.Display();
        public void DispatchEvents() => windowsfml.DispatchEvents();
        public void DrawSpriteTS(Sprite Sprite) => windowsfml.Draw(Sprite);
    }
}
