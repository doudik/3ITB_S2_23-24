using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class JellyBeanCollection
    {
        ArrayList items = new ArrayList();

        public JellyBeanIterator CreateIterator() { 
            return new JellyBeanIterator(this);
        }
        public int Count {
            get { return items.Count; }
        }

        public object this[int index]
        {
            get { return items[index]; }
            set { items.Add(value); }
        }

    }
}
