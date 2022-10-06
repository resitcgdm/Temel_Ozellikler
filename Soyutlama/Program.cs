using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soyutlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EyePen eyePen = new EyePen();
            eyePen.Brand = "Shaoi";
            eyePen.Color = "Green";
            eyePen.DoesHaveBrush = true;
            Console.WriteLine("Marka :" + " " + eyePen.Brand + " =>" + eyePen.Write());

            BoardPen boardPen = new BoardPen();
            boardPen.Brand = "Mlaos";
            boardPen.Color = "Red";
            boardPen.CanRefill = false;
            Console.WriteLine("Markası :" + " " + boardPen.Brand + "=> " + boardPen.Write());

            Console.ReadKey();
        }
    }
}
