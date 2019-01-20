using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Visualization
{
    class ColorSkin_2 : Skin
    {
        public override void Clear()
        {
            Console.Clear();
            Console.WriteLine(new string('\u058d', 30));
        }
        
        public override void Render(string text)
        {
            Random randomColor = new Random();
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));//получаем массив цветов
            ConsoleColor color= (ConsoleColor)consoleColors.GetValue(randomColor.Next(consoleColors.Length));
            Console.ForegroundColor = color;
            Console.WriteLine(text);
        }       
    }
}
