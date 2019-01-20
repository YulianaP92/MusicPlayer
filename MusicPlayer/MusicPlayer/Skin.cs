using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
   abstract class Skin
    {
        public abstract void Clear();//очистка экрана плеера
        public abstract void Render(string text);//вывод строки на экран плеера
    }
}
