using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Master_Utility
{
    class Class_AttributeParent
    {
        private string attributeSXWName;
        private string attributeDisplayName;
        private string attributeValue;
        private string attributeDisplayType;

        public Class_AttributeParent(string asn, string adn, string av, string adt)
        {
            attributeSXWName = asn;
            attributeDisplayName = adn;
            attributeValue = av;
            attributeDisplayType = adt;
        }

        public string SXWName
        {
            get { return attributeSXWName;  }
            set { attributeSXWName = SXWName; }
        }

        public string DName
        {
            get { return attributeDisplayName; }
            set { attributeDisplayName = DName; }
        }
        public string AValue
        {
            get { return attributeValue; }
            set { attributeValue = AValue; }
        }
        public string DType
        {
            get { return attributeDisplayType; }
            set { attributeDisplayType = DType; }
        }
    }
}
