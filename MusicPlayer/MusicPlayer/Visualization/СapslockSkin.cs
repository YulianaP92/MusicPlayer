using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Visualization
{
    class СapslockSkin : Skin
    {
        public override void Clear()
        {
            Console.Clear();
        }

        public override void Render(string text)
        {
            string newText = text.ToUpper();
            Console.WriteLine(newText);
        }
    }
}
