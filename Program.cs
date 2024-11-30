
using CC__graphical_framework.Engine.workspace.Base;
using CC__graphical_framework.Engine.workspace.Graphics;

Window window = new(700, 700, "CC+");

window.Run();

while (window.IsOpen())
{
    window.Display();
    window.DispatchEvents();
    var gray = CSprite.create(0, 0, "test.png");
    window.DrawSpriteTS(gray);
}