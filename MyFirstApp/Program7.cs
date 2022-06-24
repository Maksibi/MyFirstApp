using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int picturesInLine = 3;
            int picturesInAlbum = 52;
            int pictureLines = picturesInAlbum / picturesInLine;
            int picturesOver = picturesInAlbum - pictureLines * picturesInLine;
            
            Console.WriteLine("Полностью заполненных рядов картинок {0}, не поместилось картинок {1}", pictureLines, picturesOver);
            Console.ReadKey();
        }
    }
}
