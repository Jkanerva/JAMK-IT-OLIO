using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demot
{
    class Ikkuna
    {
        // Properties = ominaisuudet
        public float Leveys { get; set; }
        public float Korkeus { get; set; }
        public float Pintaala
        {
            get { return Leveys * Korkeus; }
        }
        public float Piiri
        {
            get { return 2 * (Leveys * Korkeus); }
        }
        // Constructors = konstruktorit. 'rakentajat'
        public Ikkuna()
        {
            // Tämä on ns. oletuskonstruktori
        }
        public Ikkuna (float leveys, float korkeus)
        {
            Korkeus = korkeus;
            Leveys = leveys;
        }
        // Methods = metodit
        public float LaskePintaala()
        {
            return Leveys * Korkeus;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OOIkkunaDemo();
        }
        static void OOIkkunaDemo()
        {
            // Ohjelma laskee ikkunan pinta-alan ja piirin
            float Leveys = 0;
            float Korkeus = 0;
            float Ala, Piiri = 0;

            // Kysytään käyttäjältä mitat
            Console.WriteLine("Lasken ikkunan pinta-alan ja piirin, syötä ikkunan leveys millimetreinä ");
            Leveys = float.Parse(Console.ReadLine());
            Console.WriteLine("Anna korkeus millimetreinä ");
            Korkeus = float.Parse(Console.ReadLine());

            // Lasketaan pinta-ala ja piiri ja ilmoitetaan ne käyttäjälle
            Ala = Leveys * Korkeus;
            Piiri = 2 * (Leveys + Korkeus);
            Console.WriteLine("Ikkunan ala {0} ja piiri {1}", Ala, Piiri);

            // Sama homma olion avulla
            Ikkuna ikkuna = new Ikkuna();
            ikkuna.Leveys = Leveys;
            ikkuna.Korkeus = Korkeus;

            // Ala = ikkuna.LaskePintaala();
            Console.WriteLine("Olion avulla laskettuna ikkunan ala {0} ja piiri {1}", ikkuna.Pintaala, ikkuna.Piiri);

            // Kokeillaan puolta pienemmällä ikkunalla toista konstruktoria
            Ikkuna ikkuna2 = new Ikkuna(Leveys, Korkeus);
            Console.WriteLine("Olioikkuna2 ala {0} ja piiri {1}", ikkuna2.Pintaala, ikkuna2.Piiri);
        }
    }
}
