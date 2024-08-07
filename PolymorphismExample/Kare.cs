using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    internal class Kare:BaseGeometrikSekil // base class ı inherit aldık
    {
        public Kare(int w, int h):base(w, h) {
            Console.WriteLine("Oluşturulan Karenin yükseklik "+ h +" ve genişlik bilgisi "+ w);

        }

        public override double CountArea(int width, int height) // runtime polymorphism örneği oluşturduk
        {
            return base.CountArea(width, height);
        }
    }
}
