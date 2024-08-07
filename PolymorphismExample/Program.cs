// See https://aka.ms/new-console-template for more information
namespace PolymorphismExample
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Dikdortgen dikdortgen = new Dikdortgen(2, 3);
            Console.WriteLine("Dikdörtgenin Alanı "+ dikdortgen.CountArea(dikdortgen.Width, dikdortgen.Height));
            Console.WriteLine("---------------------------------------------------");
            Kare kare = new Kare(4, 4);
            Console.WriteLine("Karenin Alanı "+ kare.CountArea(kare.Width, kare.Height));
            Console.WriteLine("---------------------------------------------------");
            DikUcgen dikUcgen = new DikUcgen(3,4);
            Console.WriteLine("Dik Üçgenin Alanı "+ dikUcgen.CountArea(dikUcgen.Width, dikUcgen.Height)) ;


        }
    }
}