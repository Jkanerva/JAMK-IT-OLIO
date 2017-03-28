using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Program
    {
        static void TestPersonClass()
        {
            // Luodaan ns henkilörekisteri
            Persons myFriends = new Persons();

            // Lisätään muutama kaveri rekisteriin
            Person friend1 = new Person();
            friend1.Firstname = "Kirsi";
            friend1.Lastname = "Kernell";
            friend1.SocialSecurityNumber = "1212270-123A";

            // Lyhyempi tapa luoda olio ominaisuuksineen
            Person friend2 = new Person { Firstname = "Jack", Lastname = "Russell", SocialSecurityNumber = "14217+BBB1" };
            Person friend3 = new Person { Firstname = "Mathias", Lastname = "Töttenström", SocialSecurityNumber = "142190+123A" };
            Person friend4 = new Person { Firstname = "Teppo", Lastname = "Testaaja", SocialSecurityNumber = "010101+0000" };

            // Lisätään kaverit yksi kerrallaan kaveri-rekisteriin
            myFriends.Add(friend1);
            myFriends.Add(friend2);
            myFriends.Add(friend3);

            // Näytetään rekisteri
            Console.WriteLine("**** Kaverirekisterisi ****");
            myFriends.ShowPersons();

            // Testataan kaverin hakua
            Console.WriteLine("Anna kaverinumero: ");
            string retval = Console.ReadLine();
            int i = 0;
            if (int.TryParse(retval, out i))
            {
                // Huom Get-metodi palauttaa null jos indeksin osoittamaa kaveria ei löydy
                Person searchedFriend = myFriends.Get(int.Parse(retval));
                if (searchedFriend != null)
                { 
                Console.WriteLine(string.Format("Löytyi ystävä nimeltä {0}", searchedFriend.ToString()));
                }
                else
                {
                    Console.WriteLine("Annetulla numerolla ei löydy kaveria.");
                }
            }
            // Testataan kaverin hakua HETUlla
            Console.WriteLine("Anna kaverisi HETU");
            retval = Console.ReadLine();
            Person sp = myFriends.Find(retval);
            if (sp != null)
                Console.WriteLine(string.Format("Löytyi:{0}", sp.ToString()));
            else
                Console.WriteLine(string.Format("Annetulla {0} HETUlla ei löydy kavereita"));
        }
        static void Main(string[] args)
        {
            TestPersonClass();
        }
    }
}
