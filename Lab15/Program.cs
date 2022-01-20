using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arithProgression = new ArithProgression();
            arithProgression.setStart(100);
            int number2=arithProgression.getNext();
            GeomProgression geomProgression = new GeomProgression();
            geomProgression.setStart(100);
            int number3 = geomProgression.getNext();
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            Console.ReadKey();
        }
    }
    interface Iseries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }
    class ArithProgression : Iseries
    {
        int start, val;
        public int getNext()
        {
            val = start + 1;
            return val;
        }

        public void reset()
        {
            val = start;
        }

        public void setStart(int x)
        {
        start = x;
        val=start;
        }
    }
    class GeomProgression : Iseries
    {
        int start, val;
        public int getNext()
        {
            val = start*2;
            return val;
        }

        public void reset()
        {
            val = start;
        }

        public void setStart(int x)
        {
            start = x;
            val = start;
        }
    }

}
