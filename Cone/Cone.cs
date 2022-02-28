using System;

namespace ThirdTask
{
    public class Cone
    {
        public Cone(double r, double h)
        {
            _r = r;
            _h = h;
        }
        double _r;
        double _h;

        public void SBase(double rad)
        {
            double result;
            double pi = Math.PI;
            result = pi * rad * rad;
            Console.WriteLine($" Площадь основания равна {result}");

        }
        public void FullS(double Hi, double rad)
        {
            double result;
            double pi = Math.PI;
            result = pi * rad * Hi;
            Console.WriteLine($"Полная площадь равна {result}");
            
        }
        public void Result()
        {
            SBase(_r);
            FullS(_h,_r);            
        }



    }
}
