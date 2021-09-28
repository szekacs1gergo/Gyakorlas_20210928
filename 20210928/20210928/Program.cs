using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20210928
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat1();
            //feladat2();
            //feladat3();
            //feladat4();
            //feladat5();
            //feladat6();
            //feladat7();
            //feladat8();
            //feladat9();
            feladat10();
        }
        static void feladat1()
        {
            Console.WriteLine("a)");
            int cv = 1;
            do
            {
                Console.Write("{0} ", cv);
                cv++;
            } while (cv<21);
            Console.WriteLine();
            for ( cv = 1; cv < 21; cv++)
            {
                Console.WriteLine("{0} ", cv);
            }
            Console.ReadLine();
        }
        static void feladat2()
        {
            int cv = 15;
            do
            {
                Console.Write("{0} ", cv);
                cv++;
            } while (cv<93);
            Console.ReadLine();
        }
        static void feladat3()
        {
            for (int i = 1; i < 31; i++)
            {
                if (i%2==0)
                {
                    Console.Write("{0} ",i);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < 31; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine("{0} ",i);
                }  
            }
            Console.ReadLine();
        }
        static void feladat4()
        {
            int cv = int.Parse(Console.ReadLine());
            for (int i = 0; i < cv; i++)
            {
                Console.Write("{0} ",i);
            }
            Console.ReadLine();
        }
        static void feladat5()
        {
            int cv = int.Parse(Console.ReadLine());
            for (int i = 0; i < cv; i++)
            {
                Console.WriteLine("{0} ", i);
            }
            Console.ReadLine();
        }
        static void feladat6()
        {
            int i = 0;
            do
            {
                Console.WriteLine("{0} ",i*i);
                i++;
            } while (i<16);
            Console.ReadLine();
        }
        static void feladat7()
        {
            for (int i = 100; i < 401; i++)
            {
                if (i%4==0)
                {
                    Console.WriteLine("{0} ",i);
                }
               Console.ReadLine();
            } 
        }
        static void feladat8()
        {
            for (int i = 30; i+9 < 100;i=i+9)
            {
                Console.Write(i+" "); 
                Console.ReadLine();
            }
            
        }
        static void feladat9()
        {
            for (int i = 150; i-12 > 40; i=i-12)
            {
                Console.Write(i+" ");
            }
            Console.ReadLine();
        }
        static void feladat10()
        {
            for (int i = 100; i > 0; i=i/9)
            {
                Console.WriteLine(i+" ");
            }
           
            Console.ReadLine();
        }
    }
}
