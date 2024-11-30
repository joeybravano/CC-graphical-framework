using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Window;
using SFML.Graphics;
using CC__graphical_framework.Engine.workspace.Base;
using System.Numerics;
using System.Runtime.CompilerServices;
namespace CC__graphical_framework.Engine.workspace.Graphics
{
    internal class CSprite : SFML.Graphics.Sprite
    {
      
        public static Sprite create(int x, int y, string key)
        {
        
            try
            {
                Texture texture = new Texture(Paths.Image + key);
                Sprite sprite = new Sprite(texture);
                sprite.Position = new SFML.System.Vector2f(x, y);
                return sprite;
            }
            catch (SFML.LoadingFailedException e)
            {
                // just revert to the base error texture
                Texture texture = new Texture(Paths.Image + "error.png");
                Sprite sprite = new Sprite(texture);
                sprite.Position = new SFML.System.Vector2f(x, y);//put the error texture were the good ones supposed to be
                return sprite;
            }
        }
    }
}
