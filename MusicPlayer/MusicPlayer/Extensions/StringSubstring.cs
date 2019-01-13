using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Extensions
{
    //L9-HW-Player-2/3.
    public static class StringSubstring
    {
        public static string Substring_2(this string newString)
        {
            newString = newString.Substring(0, newString.Length - 2);

            return $"{newString}...";
        }
    }
}
