using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Master_Utility
{
    class Class_SXWComponent
    {
        public string componentName;
        public string componentDescription;
        public List<Class_SXWObject> listSWXObjects;

        public Class_SXWComponent(string cn, string cd, List<Class_SXWObject> so)
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
