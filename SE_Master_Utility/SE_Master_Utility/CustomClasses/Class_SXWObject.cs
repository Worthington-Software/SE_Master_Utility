using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Master_Utility
{
    class Class_SXWObject
    {
        public string objectName;
        public string objectDescription;
        public List<Class_AttributeParent> listSXWAttributeParent;
        
        public Class_SXWObject(string on, string od, List<Class_AttributeParent> ap)
        {
            objectName = on;
            objectDescription = od;
            listSXWAttributeParent = ap;            
        }

        public string objName
        {
            get
            {
                return objectName;
            }
        }
    }
}
