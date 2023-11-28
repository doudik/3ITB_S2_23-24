using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class JellyBean
    {
        private string flavor;
        public string Flavor { get { return flavor; } }

        public JellyBean(string flavor)
        {
            this.flavor = flavor;
        }

    }
}
