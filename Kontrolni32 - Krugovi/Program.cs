using System;

namespace Kontrolni32___Krugovi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Napraviti klase:
                Tacka2D, koja ima:
                    polja:
                        - x i y, dva javna polja tipa double,
                    metode:
                        - konstruktor,
                        - ToString,
                        - RastojanjeOdTacke (opciono),
                Krug, koja ima:
                    polja: 
                        - r, javno polja tipa double koje predstavlja poluprecnik kruga,
                        - centar, javno polje tipa Tacka2D koje predstavlja centar kruga,
                    metode:
                        - 2 konstrukora
                        - ToString, koja prikazuje krug u obliku oznaka(r,x,y), npr. K1(40,3,1),
                        - Pripada, proverava da li se jedan krug nalazi unutar drugog,
                        - SekuSe, proverava da li se krugovi seku,
                        - DvostrukiKoncetricni, stvara novi krug sa istim centrom kao i dati krug ali sa dvostruko vecim poluprecnikom.
             */
            
            Console.WriteLine("Hello World!");
            /*
            double r, x, y;
            string oznaka;            
            Console.WriteLine("Unesi naziv prvog kruga ");
            oznaka = Console.ReadLine();
            Console.WriteLine("Unesi poluprečnik prvog kruga ");
            r = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesi x koordinatu centra  prvog kruga");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesi y koordinatu centra prvog kruga");
            y = double.Parse(Console.ReadLine());
            Krug k1 = new Krug(oznaka, r, x, y);
            Console.WriteLine("");
            Console.WriteLine("Unesi naziv drugog kruga ");
            oznaka = Console.ReadLine();
            Console.WriteLine("Unesi poluprečnik drugog kruga ");
            r = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesi x koordinatu centra  drugog kruga");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesi y koordinatu centra drugog kruga");
            y = double.Parse(Console.ReadLine());
            Tacka t1 = new Tacka(x,y);
            Krug k2 = new Krug(oznaka, r, t1);
            // Ulančavanje ova dva konstruktora ne morate da uradite, ali
            // ako uradite ulančavanje onda ne morate da uradite neku od metoda Pripada ili SekuSe.            
            Console.WriteLine("********* Prikaz unetih krugova *************");           
            Console.WriteLine(k1);
            Console.WriteLine(k2);
            Console.WriteLine("*********************************************");

            // dovde je za 3!
            /*
            if (k1.Pripada(k2))
            {
                Console.WriteLine("Krug "+k1+" je ceo unutar kruga"+k2+"!");
            }
            else if (k2.Pripada(k1))
            {
                Console.WriteLine("Krug " + k2 + " je ceo unutar kruga" + k1 + "!");
            }
            else if (k1.SekuSe(k2))
            {
                Console.WriteLine("Krugovi se seku!");
            }
            else
            {
                Console.WriteLine("Krugovi se ne seku!");
            }

            //dovde je za 4!
            /*
            Krug k3 = k1.DvostrukiKoncetricni();
            Console.WriteLine("Krug "+k3+" je dvostruko veci od kruga "+k1+", a centri su im u tacki "+k3.centar+" i "+k1.centar+" respektivno.");
            */
        }
    }
}
