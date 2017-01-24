using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Nature
{
    class Muurahainen
    {

        public void Kavele() //Pam metodi KAVELe
        {
            Console.WriteLine("Muurahainen lähtee liikkeelle");
        }
        public void Pure() //PAM metodi Pure
        {
            Console.WriteLine("Muurahainen puree leuat yhteen");
        }
    }

    class OphiocordycepsUnilateralis : Muurahainen
    {
        public void ExtendedPhenotype() // Hito Scifi setitystä. Kysy R.Dawkinsilta lisätietoja
        {
            Console.WriteLine("OphiocordycepsUnilateralis ottaa muurahaisen hallintaa");
        }

        public void Kasva() //Pistää OphiocordycepsUnilateralisen kasvamaa
        {
            Console.WriteLine("OphiocordycepsUnilateralis kasvaa tyytyväisenä");
        }
    }

    class Viidakko
    {
        static void Main(string[] args)
        {
            //Kaikki hyvin. Muurahainen ilmestyy kuviin. Mukavaa musaa.
            Muurahainen CarpenterAnt = new Muurahainen();
            //Attenborough höpisee mukavia ja muurahainen vipeltää menemään           
            CarpenterAnt.Kavele();  // Muurahainen kavelee

            //Musa tiivistyy ja Davidn pälätys kiihtyy.
            //Vaikea nähä mutta kuvioon ilmestyy Opie the Ophiocordyceps unilateralis
            OphiocordycepsUnilateralis Opie = new OphiocordycepsUnilateralis();
            // Opie käyttää Extended Phenotypeä
            Opie.ExtendedPhenotype();  // Opie ottaa muurahaisen haltuun
            // Nyt Attenboroughilta lentää kuola suusta. Homma menee mahottomaksi
            // Opie otti muurahaisen haltuun ja ohjailee muurahaista. Science bitch!
            Opie.Kavele();  //  OphiocordycepsUnilateralis kavelee
            //Opie pistää muurahaisen ottamaan puremalla "death gripin" lehdestä
            Opie.Pure();    //   OphiocordycepsUnilateralis puree
            Opie.Kasva();   // Opie kasvaa. Nature Bitches.
           
           
        }
    }
}


