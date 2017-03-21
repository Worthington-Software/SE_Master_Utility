using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Master_Utility
{
    class BACnetAnalogValue : SXWObject
    {
        public BACnetAnalogValue(string name, string descr, string type, Dictionary<string, string> addProps) : base(name, descr, type)
        {
           
        }
    }
}
