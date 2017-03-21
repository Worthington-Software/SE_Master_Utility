using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace SE_Master_Utility
{
    class SXWObject
    {
        public string objectName;
        public string objectDescr;
        public string objectType;
        public List<SXWProperty> objectAttrList;

        public SXWObject(string name, string descr, string type, List<SXWProperty> attr = null)
        {
            objectName = name;
            objectDescr = descr;
            objectType = type;
            objectAttrList = attr;            
        }

        public SXWObject(XmlElement ele)
        {
            objectName = ele.GetAttribute("NAME");
            objectDescr = ele.GetAttribute("DESCR");
            objectType = ele.GetAttribute("TYPE");
            XmlNodeList nodeList = ele.GetElementsByTagName("PI"); //All property "PI" nodes
            //Do something with nodeList if needed
        }

        public string objName
        {
            get
            {
                return objectName;
            }
        }

        public string objDescription
        {
            get
            {
                return objectDescr;
            }
        }
    }
}
