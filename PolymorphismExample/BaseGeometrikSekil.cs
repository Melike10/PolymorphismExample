using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    // base class 
    internal abstract class BaseGeometrikSekil
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public BaseGeometrikSekil(int width, int height)
        {
            Width = width;
            Height = height;
        }
        // override edilip kullanılması için virtual tanımı kullanılmıştır.
        public abstract double CountArea(int width,int height);
       

    }
}
