using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            /*** Deklarasi ***/
            List<akatsuki> myList = new List<akatsuki>();
            
            /*** Nambain element baru ***/
            myList.Add(new akatsuki() { name = "Itachi", rating=91, jutsu="Izanami"});
            myList.Add(new akatsuki() { name = "Hyosoka", rating = 93, jutsu = "Bungeejigum" });
            myList.Add(new akatsuki() { name = "Nagato", rating = 91, jutsu = "Sira Tensei" });
            myList.Add(new akatsuki() { name = "Poipo", rating = 91, jutsu = "xxxxx" });

            /* Nampilin element */
            foreach (akatsuki a in myList) Console.WriteLine("Nama : "+a.name + " Rating : "+a.rating+ " Jutsu : "+a.jutsu);


            /* Search item */
            Console.WriteLine("\nElement dengan nama Itachi : "+myList.Find(x=>x.name.Contains("Itachi")));
            Console.WriteLine("Element dengan rating 91 :" + myList.Find(x => x.rating == 91));
            Console.WriteLine("Element dengan rating 90:" + myList.Find(x => x.rating == 90));

            /*Exist method*/
            Console.WriteLine("\nApa ada yg ratingnya 93 ? : "+myList.Exists(x=>x.rating == 93));
            Console.WriteLine("Apa ada yg ratingnya 95 ? : " + myList.Exists(x => x.rating == 95));


            
            Console.ReadLine();
        }
    }



    public class akatsuki
    {
        public string name { get; set; }
        public int rating { get; set; }
        public string jutsu { get; set; }


        public override string ToString()
        {
            return "Name : "+ name+ ", Rating : "+ rating+ ", Jutsu "+jutsu;
        }
    }


}
