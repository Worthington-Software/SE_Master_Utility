using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Master_Utility
{
    class SXWComponent
    {
        public string componentName;
        public string componentDescription;
        public List<SXWObject> listSWXObjects;

        public SXWComponent(string cn, string cd, List<SXWObject> so)
        {
            componentName = cn;
            componentDescription = cd;
            listSWXObjects = so;
        }

        public string compName
        {
            get
            {
                return componentName;
            }
        }
    }
}
