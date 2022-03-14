using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
      
        static double Length(double sin,double cos,double v0,double h0)
        {
            return ((2 * sin * v0 + h0) / 9.81) * cos * v0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начальную высоту");
            double h0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите начальную скорость (м/с)");
            double v0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите начальный угол");
            double a = Convert.ToDouble(Console.ReadLine()) * Math.PI/180;

            double cos = Math.Cos(a);
            double sin = Math.Sin(a);

            //var Lmax = new List<maxL>();

            Console.WriteLine("\nДлина полета снаряда = " + Length(sin,cos,v0,h0));
            Console.WriteLine("\nМаксимальная высота = " + (((v0*v0*sin*sin)/(2*9.81))+h0));
            double maxl = 0;
            int maxalpha = 0;
            for (int i = 0; i < 90; i++)
            {

                a = i * Math.PI / 180;
                cos = Math.Cos(a);
                sin = Math.Sin(a);

                if (maxl < Length(sin, cos, v0, h0)) 
                {
                    maxl = Length(sin, cos, v0, h0);
                    maxalpha = i; 
                }
                    
                //Lmax.Add( new maxL() { alpha = i, L = Length(sin, cos, v0, h0) });
            }

            Console.WriteLine("\nУгол, при котором дальность полета будет максимальной - " + maxalpha + "\nМаксимальная длина полета равна " + maxl);
            /* var sortedLmax = from l in Lmax
                              orderby l.L descending,l.alpha
                              select l;
             bool write = false;

             foreach(maxL l in sortedLmax)
             {
                 if (write == false) { 
                     Console.WriteLine("\nУгол, при котором дальность полета будет максимальной - " + l.alpha + "\nМаксимальная длина полета равна "+ l.L);
                     write = true;
                 }

             }*/
            Console.ReadKey();
        }
       /* public class maxL
        {
            public int alpha { get; set; }
            public double L { get; set; }
        }*/
    }
}
