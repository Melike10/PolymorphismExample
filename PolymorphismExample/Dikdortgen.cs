using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    internal class Dikdortgen:BaseGeometrikSekil
    {
        public Dikdortgen(int w, int h):base(w, h) {
            Console.WriteLine("Oluşturulan dikdörtgenin yükseklik " + h + " ve genişlik bilgisi " + w);
        }

        public override double CountArea(int width, int height)// runtime polymorphism örneği oluşturduk
        {
            return width * height; 
        }
    }
}
