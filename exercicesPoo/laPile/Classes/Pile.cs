using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laPile.Classes
{
    internal class Pile<T>
    {
        private T[] elements;
        private int count;

        public Pile(int taille)
        {
            elements = new T[taille];
            count = 0;
        }

        public void Empiler(T element)
        {
           if (count < elements.Length) 
            {
                elements[count++] = element;
            }
        }

        public void Depiler() 
        { 
            if(count > 0)
            {
                count--;
                elements[count] = default(T);
            }
        }

        public T Get(int index)
        {
            if (index >= 0 && index < count)
            {
                return elements[index];
            }
            return default(T);
        }

    }
}
