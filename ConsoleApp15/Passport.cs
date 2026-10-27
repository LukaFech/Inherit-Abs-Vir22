using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp15
{
    internal class Passport
    {
        public int _id { get; set; }
        public string _Firstname { get; set; }
        public string _Lastname { get; set; }
        public string _Country { get; set; }
        public Passport(int id,string Firstname,string Lastname,string Country)
        {
            _id = id;
            _Firstname = Firstname;
            _Lastname = Lastname;
            _Country = Country;
        }
        virtual public void show()
        {
            Console.WriteLine($"Firstname is {_Firstname}, Lastname is {_Lastname}, Id is {_id}, Country is {_Country}");
        }
    }
    internal class Foreign_Passport : Passport
    {
        string[] visas = new string[0];
        public int _foreign { get; set; }
        public Foreign_Passport(int id, string Firstname, string Lastname, string Country, int foreign) : base(id, Firstname, Lastname, Country)
        {
            _foreign = foreign;
        }
        public override void show()
        {
            Console.WriteLine($"Firstname is {_Firstname}, Lastname is {_Lastname}, Id is {_id}, Country is {_Country}, Num of fp is {_foreign}");
        }
        public void add_visa(string visa)
        {
            string[] buff = new string[visas.Length+1];
            for (int i = 0; i < visas.Length; i++)
            {
                buff[i] = visas[i];
            }
            buff[visas.Length] = visa;
            visas = buff;
        }
        public void get_visa()
        {
            for (int i = 0; i < visas.Length; i++)
            {
                Console.WriteLine(visas[i]);
            }
        }
    }
}
