using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetClassTest
{
    public class PetClass
    {
        public string name { get; set; }
        public string petType { get; set; }
        
        public PetClass(string n)
        {
            this.name = n;
        }

        public virtual void Speak()
        {
            Console.WriteLine("Speak");
        }
    }

    public class PetCat : PetClass
    {
        public string color { get; set; }

        public PetCat(string na) : base(na)
        {
            this.name = na;
            this.petType = "cat";
        }

        public override void Speak()
        {
            Console.WriteLine("Meow");
        }

        public void SetColor(string color)
        {
            this.color = color;
            GetColor();
        }

        public void GetColor()
        {
            Console.WriteLine("This cat's fur is now", color);
        }
    }

    public class CoolCat : PetCat
    {
        public CoolCat(string name) : base(name) 
        {
            this.name = name;
        }

        public void sing()
        {
            Console.WriteLine("Haha, no.");
        }

    }

    public class PetDog : PetClass
    {
        public PetDog (string name) : base(name)
        {
            this.name = name;
            this.petType = "dog";
        }

        public override void Speak()
        {
            Console.WriteLine("Woof");
        }
    }
}
