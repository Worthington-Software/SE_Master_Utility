using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Master_Utility
{
    class SXWProperty
    {
        private string propertySXWName;
        private string propertyDisplayName;
        private string propertyValue;
        private string propertyDisplayType;

        public SXWProperty(string pName, string pDispName, string pValue, string pDispTyp)
        {
            propertySXWName = pName;
            propertyDisplayName = pDispName;
            propertyValue = pValue;
            propertyDisplayType = pDispTyp;
        }

        public string SXWName
        {
            get { return propertySXWName;  }
            set { propertySXWName = SXWName; }
        }

        public string DispName
        {
            get { return propertyDisplayName; }
            set { propertyDisplayName = DispName; }
        }
        public string Value
        {
            get { return propertyValue; }
            set { propertyValue = Value; }
        }
        public string DType
        {
            get { return propertyDisplayType; }
            set { propertyDisplayType = DType; }
        }
    }
}
