using System;

namespace MusicPlayer.Visualization
{
    class ClassicSkin : Skin
    {
        public override void Clear()
        {
            Console.Clear();
        }

        public override void Render(string text)
        {
            Console.WriteLine(text);
        }
    }
}
