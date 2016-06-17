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
            /*** Nampung list untuk integer ***/
            List<int> intList = new List<int>();
            
            /**** Nambain Element *****/
            intList.Add(3);
            intList.Add(5);
            intList.Add(7);
            intList.Add(9);
            intList.Add(2);
            intList.Add(6);


            /*** Ukuran/jumlah element dalam list ***/
            Console.WriteLine("Jumlah Element : "+intList.Count);
            Console.WriteLine("Isi intList : ");
            foreach (int a in intList) Console.WriteLine(a);

            Console.WriteLine("element 3 : "+intList[3]);

            /*** insert item baru ***/
            intList.Insert(2,99);
            intList.Insert(5, 99);
            Console.WriteLine("\nIsi intList setelah insert element : ");
            foreach (int a in intList) Console.WriteLine(a);
            
            
            /*** search element dalam list ****/
            Console.WriteLine(" search 7 : "+intList.Contains(7));
            Console.WriteLine(" index 7 : "+intList.IndexOf(7));
            Console.WriteLine(" search 77 : " + intList.Contains(77));
            Console.WriteLine(" index 77 : " + intList.IndexOf(77));


            /*** sort item dalam list ***/
            intList.Sort();
            Console.WriteLine("\nIsi intList setelah di-sort : ");
            foreach (int a in intList) Console.WriteLine(a);

            /*** remove item ***/
            Console.WriteLine(" remove 99 : " + intList.Remove(99));
            Console.WriteLine(" remove 999 : " + intList.Remove(999));


            /*** clear total isi list ***/
            intList.Clear();
                
            
            Console.ReadLine();
        }
    }
}
