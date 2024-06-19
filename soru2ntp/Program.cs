using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace soru2ntp
{
    internal class Points
    {
        private int x;
        private int y;
        public void kordinatAta(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int[] koordinatYazdır()
        {
            return new int[] { this.x, this.y };
        }

       
        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        } 
        static void Main(string[] args)
        {
            Points point = new Points();
            point.kordinatAta(19, 6);

            Console.WriteLine("X koordinatı:");
            Console.WriteLine(point.GetX());

            Console.WriteLine("Y koordinatı:");
            Console.WriteLine(point.GetY());

            int[] coordinates = point.koordinatYazdır();
            Console.WriteLine("Tüm koordinatlar:");
            foreach (int coord in coordinates)
            {
                Console.WriteLine(coord);

            }
            Console.ReadKey();
        }
    }
}
