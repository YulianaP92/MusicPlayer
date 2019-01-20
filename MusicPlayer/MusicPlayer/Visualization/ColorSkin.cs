using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Visualization
{
    class ColorSkin : Skin
    {
        private ConsoleColor _color { get; set; }
        public ColorSkin(ConsoleColor color)
        {
            _color = color;
        }
        public override void Clear()
        {
            Console.Clear();
        }

        public override void Render(string text)
        {
            Console.ForegroundColor = _color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
