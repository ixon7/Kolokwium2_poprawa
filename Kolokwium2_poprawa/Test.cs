using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium2_poprawa
{
    public class Test
    {
        private int id;
        private string nazwa;
        private string opis;
        private bool powodzenie;
        private string tester;
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public bool Powodzenie { get; set; }
        public string Tester { get; set; }

        public Test(int id, string nazwa, string opis, bool powodzenie, string tester)
        {
            Id = id;
            Nazwa = nazwa;
            Opis = opis;
            Powodzenie = powodzenie;
            Tester = tester;
        }
        //~test()
        //{
        //    id = id;
        //    powodzenie = powodzenie;
        //}
        ~Test()
        {
            Id = id;
            Nazwa = nazwa;
            Opis = opis;
            Powodzenie = powodzenie;
            Tester = tester;
        }


    }
}
