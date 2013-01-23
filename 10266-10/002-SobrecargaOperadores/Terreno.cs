using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_SobrecargaOperadores
{
    class Terreno
    {
        //prop tab tab
        public int Frente { get; set; }
        public int Lateral { get; set; }

        //ctor tab tab
        public Terreno(int frente, int lateral)
        {
            Frente = frente;
            Lateral = lateral;
        }

        //override space
        public override string ToString()
        {
            return String.Format("{0} x {1} = {2}", Frente, Lateral, Frente * Lateral);
        }

        public static Terreno operator +(Terreno t1, Terreno t2)
        {
            if (t1.Lateral != t2.Lateral)
            {
                throw new Exception("as laterais tem que ser iguais");
            }

            return new Terreno(t1.Frente + t2.Frente, t1.Lateral);
        }

        public static bool operator >(Terreno t1, Terreno t2)
        {
            return t1.Frente * t1.Lateral > t2.Frente * t2.Lateral;
        }

        public static bool operator <(Terreno t1, Terreno t2)
        {
            return !(t1 > t2);
        }

        public static bool operator ==(Terreno t1, Terreno t2)
        {
            return t1.Frente * t1.Lateral == t2.Frente * t2.Lateral;
        }

        public static bool operator !=(Terreno t1, Terreno t2)
        {
            return !(t1 == t2);
        }

        //override space
        public override bool Equals(object obj)
        {
            return this == obj as Terreno;
        }

        public override int GetHashCode()
        {
            return Frente * Lateral;
        }
    }
}
