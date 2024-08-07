## PolymorphismExample
Bu proje, C# dilinde polymorphism (çok biçimlilik) kavramını açıklayan basit bir örnek içermektedir. Proje, bir temel sınıf (BaseGeometrikSekil) ve bu sınıftan türetilen üç alt sınıf (DikUcgen, Dikdortgen, Kare) içerir.

## İçerik
BaseGeometrikSekil: Geometrik şekillerin temel sınıfı.
DikUcgen: Dik üçgen sınıfı.
Dikdortgen: Dikdörtgen sınıfı.
Kare: Kare sınıfı.
Kullanım
Proje, temel bir geometrik şekil sınıfını (BaseGeometrikSekil) ve bu sınıftan türetilen dik üçgen (DikUcgen), dikdörtgen (Dikdortgen) ve kare (Kare) sınıflarını içerir. Bu sınıflar, polymorphism kavramını göstermek amacıyla tasarlanmıştır.

## Örnek Kod
csharp
Copy code
using System;

namespace PolymorphismExample
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseGeometrikSekil dikUcgen = new DikUcgen(3, 4);
            Console.WriteLine("Dik Üçgenin Alanı: " + dikUcgen.CountArea(dikUcgen.Width, dikUcgen.Height));

            BaseGeometrikSekil dikdortgen = new Dikdortgen(5, 6);
            Console.WriteLine("Dikdörtgenin Alanı: " + dikdortgen.CountArea(dikdortgen.Width, dikdortgen.Height));

            BaseGeometrikSekil kare = new Kare(4, 4);
            Console.WriteLine("Karenin Alanı: " + kare.CountArea(kare.Width, kare.Height));
        }
    }
}
## Açıklamalar
BaseGeometrikSekil Sınıfı
BaseGeometrikSekil, tüm geometrik şekiller için temel bir sınıftır. Bu sınıfın CountArea metodu, şeklin alanını hesaplamak için kullanılır ve virtual olarak tanımlanmıştır, böylece türetilmiş sınıflarda override edilebilir.

csharp
Copy code
internal abstract class BaseGeometrikSekil
{
    public int Width { get; set; }
    public int Height { get; set; }

    public BaseGeometrikSekil(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public virtual double CountArea(int width, int height)
    {
        return width * height;
    }
}
DikUcgen Sınıfı
DikUcgen, BaseGeometrikSekil sınıfından türetilmiştir ve CountArea metodunu override ederek üçgenin alanını hesaplar.

csharp
Copy code
internal class DikUcgen : BaseGeometrikSekil
{
    public DikUcgen(int w, int h) : base(w, h)
    {
        Console.WriteLine("Oluşturulan dik üçgenin yükseklik " + h + " ve genişlik bilgisi " + w);
    }

    public override double CountArea(int width, int height)
    {
        return base.CountArea(width, height) / 2;
    }
}
Dikdortgen Sınıfı
Dikdortgen, BaseGeometrikSekil sınıfından türetilmiştir ve CountArea metodunu override ederek dikdörtgenin alanını hesaplar.

csharp
Copy code
internal class Dikdortgen : BaseGeometrikSekil
{
    public Dikdortgen(int w, int h) : base(w, h)
    {
        Console.WriteLine("Oluşturulan dikdörtgenin yükseklik " + h + " ve genişlik bilgisi " + w);
    }

    public override double CountArea(int width, int height)
    {
        return base.CountArea(width, height);
    }
}
Kare Sınıfı
Kare, BaseGeometrikSekil sınıfından türetilmiştir ve CountArea metodunu override ederek karenin alanını hesaplar.

csharp
Copy code
internal class Kare : BaseGeometrikSekil
{
    public Kare(int w, int h) : base(w, h)
    {
        Console.WriteLine("Oluşturulan Karenin yükseklik " + h + " ve genişlik bilgisi " + w);
    }

    public override double CountArea(int width, int height)
    {
        return base.CountArea(width, height);
    }
}

## English Explanation
This project demonstrates the concept of polymorphism in C# using a simple example. The project includes a base class (BaseGeometrikSekil) and three derived classes (DikUcgen, Dikdortgen, Kare).

Example Code
csharp
Copy code
using System;

namespace PolymorphismExample
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseGeometrikSekil dikUcgen = new DikUcgen(3, 4);
            Console.WriteLine("Area of Right Triangle: " + dikUcgen.CountArea(dikUcgen.Width, dikUcgen.Height));

            BaseGeometrikSekil dikdortgen = new Dikdortgen(5, 6);
            Console.WriteLine("Area of Rectangle: " + dikdortgen.CountArea(dikdortgen.Width, dikdortgen.Height));

            BaseGeometrikSekil kare = new Kare(4, 4);
            Console.WriteLine("Area of Square: " + kare.CountArea(kare.Width, kare.Height));
        }
    }
}
## Class Descriptions
BaseGeometrikSekil Class
BaseGeometrikSekil is the base class for all geometric shapes. The CountArea method is used to calculate the area of the shape and is defined as virtual so it can be overridden in derived classes.

DikUcgen Class
DikUcgen is derived from BaseGeometrikSekil and overrides the CountArea method to calculate the area of a triangle.

Dikdortgen Class
Dikdortgen is derived from BaseGeometrikSekil and overrides the CountArea method to calculate the area of a rectangle.

Kare Class
Kare is derived from BaseGeometrikSekil and overrides the CountArea method to calculate the area of a square.

