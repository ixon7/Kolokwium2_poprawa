using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Kolokwium2_poprawa
{
    class Program
    {
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        //public List<Mieszkanie> Mieszkania = new List<Mieszkanie>();
        //foreach (var item in Mieszkanie.Mieszkania)
        //        {
        //        Mieszkanie h = new Mieszkanie(item.Mieszkania);
        //Mieszkanie.Mieszkania.Add(Mieszkanie);
        //        }

        static void Main(string[] args) => Console.WriteLine("Hello World!"); public List<Mieszkanie> Mieszkania = new List<Mieszkanie>();
        }
    }

    //Mieszkania.Add();
    //for (int i = 0; i < 50; i++)
    //{
    //    Mieszkanie.Mieszkania.Add()
    //}