using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test {

    class Den{
        public string name = "Fred";
        public int age = 20;

        public void print() {
            Console.WriteLine(name);
        }
    }


    class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Hellow world");
            //Console.ReadKey();
            string a;
            //a = Convert.ToChar(Console.ReadLine());
            int[] mas = new int[2];
            mas[0] = 1;
            mas[1] = 2;
            for(int i = 0; i < mas.Length; i++) {
                Console.WriteLine(mas[i]);
            }

            HellowWorld("HI");

            /*foreach (int b in mas) {
                Console.WriteLine(mas[b]);
            }*/

            Den cat = new Den();
            Console.WriteLine(cat.name);
            cat.name = "Tom";
            Console.WriteLine(cat.name);
            cat.print();

            Console.ReadKey();
        }

        public static void HellowWorld(string str) {
            Console.WriteLine("Helow World (OOP)");
            Console.WriteLine(str);
        }

    }
}
