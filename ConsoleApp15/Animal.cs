using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    internal abstract class Animal
    {
        public string _name { get; set; }
        public string _characteristics { get; set; }
        public Animal(string name, string ch)
        {
            _name = name;
            _characteristics = ch;
        }
        public abstract void voice();
    }
    internal class Tiger : Animal
    {
        public Tiger(string name, string ch) : base(name, ch) { }
        public override void voice()
        {
            Console.WriteLine("WAaaaahhhhhhrarhh");
        }
    }
    internal class Crocodile : Animal
    {
        public Crocodile(string name, string ch, string sp) : base(name, ch) { }
        public override void voice()
        {
            Console.WriteLine("MHHHHHHhapeearc#");
        }
    }
    internal class Kenguru : Animal
    {
        public Kenguru(string name, string ch, string sp) : base(name, ch) { }
        public override void voice()
        {
            Console.WriteLine("Hophophophop awahrfsa#");
        }
    }
}
