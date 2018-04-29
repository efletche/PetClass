using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PetClass> PetList = new List<PetClass>();


            PetList.Add(new PetCat("Mittens","Cream"));
            PetList.Add(new CoolCat("Garfield"));
            PetList.Add(new PetDog("Bowser"));

            foreach(var pet in PetList)
            {
                pet.Speak();
                if(pet.petType == "cat")
                {
                    Console.WriteLine("Jon loves his best friend {0}", pet.name);
                    Console.WriteLine("and {0}", ((PetCat)pet).furColor);
                }
            }


            Console.WriteLine("Hello World");
            //.ReadLine();
        }
    }
}
