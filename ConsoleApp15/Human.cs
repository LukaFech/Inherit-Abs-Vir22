using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    internal class Human
    {
        public string _Firstname { get; set; }
        public string _Lastname { get; set; }
        public string _Sex { get; set; }
        public Human(string Fn, string Ln, string sex)
        {
            _Firstname = Fn;
            _Lastname = Ln;
            _Sex = sex;
        }
        public virtual void show()
        {
            Console.WriteLine($"Firstname is {_Firstname}, Lastname is {_Lastname}, Sex is {_Sex}");
        }
    }
    internal class Builder : Human
    {
        public string _Sphere { get; set; }
        public Builder(string Fn, string Ln, string sex, string Sphere) : base(Fn, Ln, sex)
        {
            _Sphere = Sphere;
        }
        public override void show()
        {
            Console.WriteLine($"Firstname is {_Firstname}, Lastname is {_Lastname}, Sex is {_Sex}, Sphere of building is {_Sphere}");
        }
    }
    internal class Sailor : Human
    {
        public string _Ship_name { get; set; }
        public Sailor(string Fn, string Ln, string sex, string ship) : base(Fn, Ln, sex)
        {
            _Ship_name = ship;
        }
        public override void show()
        {
            Console.WriteLine($"Firstname is {_Firstname}, Lastname is {_Lastname}, Sex is {_Sex}, Name of the ship is {_Ship_name}");
        }
    }
    internal class Pilot : Human
    {
        public string _Plane { get; set; }
        public Pilot(string Fn, string Ln, string sex, string plane) : base(Fn, Ln, sex)
        {
            _Plane = plane;
        }
        public override void show()
        {
            Console.WriteLine($"Firstname is {_Firstname}, Lastname is {_Lastname}, Sex is {_Sex}, Planes name is {_Plane}");
        }
    }
}
