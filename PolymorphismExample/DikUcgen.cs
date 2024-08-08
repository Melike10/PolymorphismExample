using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    internal class DikUcgen:BaseGeometrikSekil
    {
        public DikUcgen(int w,int h):base(w,h) {
            Console.WriteLine("Oluşturulan dik üçgenin yükseklik " + h + " ve genişlik bilgisi " + w);

        }
        public override double CountArea(int width, int height)
        {
            return width * height/2;
        }

    }
}
