using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hajr1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an object from Persons
            Persons myNiggas = new Persons();

            // create a niggas...
            Person nigga1 = new Person { FName = "Jalmari", LName = "Kasapaskaa", Sotu = "010101-01E6"};
            Person nigga2 = new Person { FName = "Peppi", LName = "Heinämies", Sotu = "020202-02C8" };
            Person nigga3 = new Person { FName = "Dickhead", LName = "Rääväsuu", Sotu = "030303-1234" };
            Person nigga4 = new Person { FName = "Poor", LName = "Juustopää", Sotu = "040404-5678" };

            // add persons to collection
            myNiggas.AddPerson(nigga1);
            myNiggas.AddPerson(nigga2);
            myNiggas.AddPerson(nigga3);
            myNiggas.AddPerson(nigga4);

            // Print collection

            myNiggas.PrintCollection();

            // get one person
            Console.WriteLine("Get one person from collection");
            Person nigga5 = myNiggas.GetPerson(1);
            if (nigga5 != null)
            {
                Console.WriteLine(nigga5.ToString());

            }
            else
            {
                Console.WriteLine("Cannot find nigga in that position, must be too dark.");
            }

            // find person with sotu
            string sotu = "010101-11E6";
            Console.WriteLine("Find person with sotu: " + sotu);
            Person nigga6 = myNiggas.FindPerson(sotu);
            if (nigga6 != null)
            {
                Console.WriteLine(nigga6.ToString());
            }else
            {
                Console.WriteLine("Not found nigga that u looking for...");
            }
        }
    }
}
