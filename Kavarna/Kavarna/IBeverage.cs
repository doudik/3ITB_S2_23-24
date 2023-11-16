using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kavarna
{
    internal interface IBeverage
    {
        extra additional{ get; set; }
        void getAllInformation();
    }
}
