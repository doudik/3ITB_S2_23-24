using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class JellyBeanIterator : IJellyBeanIterator
    {
        JellyBeanCollection jellyBeans;
        int current = 0;
        int step = 1;
        
        public JellyBeanIterator(JellyBeanCollection jellyBeans)
        {
            this.jellyBeans = jellyBeans;
        }


        public bool IsDone {
            get { return current >= jellyBeans.Count; }
        }

        public JellyBean CurrentBean {
            get { return jellyBeans[current] as JellyBean; }
        }

        public JellyBean First()
        {
            current = 0;
            return jellyBeans[current] as JellyBean;
        }

        public JellyBean Next()
        {
            current += step;
            if(!IsDone)
                return jellyBeans[current] as JellyBean;
            else
                return null;
        }

        

    }
}
