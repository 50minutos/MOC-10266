using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _002_IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            var quadrados = new Quadrados();

            foreach (var item in quadrados)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }

    class EnumeratorQuadrados : IEnumerator<int>
    {
        private int i = 0;

        public int Current
        {
            get { return (int)System.Math.Pow(i, 2); }
        }

        Object IEnumerator.Current
        {
            get { return Current; }
        }

        public bool MoveNext()
        {
            i++;
        
            if (i > 10)
                return false;
            else
                return true;
        }

        public void Reset()
        {
            i = 0;
        }

        public void Dispose() { }
    }

    class Quadrados : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            return new EnumeratorQuadrados();
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
