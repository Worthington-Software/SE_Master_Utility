using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace SE_Master_Utility
{
    public partial class Form1 : Form
    {
        //Global Items
        XDocument doc = new XDocument();
        List<Class_SXWComponent> listMasterSXWComponents = new List<Class_SXWComponent>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {            
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //Open dialog box and if the user hit "OK"
            {
                doc = XDocument.Load(openFileDialog1.FileName); //load document as XDocument (not XMLDocument) for the use of LINQ
                getValueAndPointNames();//Get the list of objects
            }

        }

        private void getValueAndPointNames()
        {
            var xm = doc.Descendants().Where(x => x.Attribute("TYPE") != null); //Get all the elements that has a "TYPE" attribute
            foreach (var vn in xm)
            {
                if (vn.Attribute("TYPE").Value != null) //Check again to prevent any runtime errors
                {
                    MessageBox.Show(vn.Name.ToString());
                } //ends if type.value != null
            } //ends foreach vn in xm
        }//ends getValueAndPointNames()

        public void loadPredefinedComponents()
        {

            /*
            //For Now Simulate a loaded XML "SaFanType=01"
            List<Class_SXWAttributeAnalog> taa = new List<Class_SXWAttributeAnalog>();
            List<Class_SXWAttributeDigital> tad = new List<Class_SXWAttributeDigital>();
            List<Class_SXWAttributeString> tas = new List<Class_SXWAttributeString>();
            List<Class_SXWObject> tso = new List<Class_SXWObject>();

            tad.Add(new Class_SXWAttributeDigital("AudibleAlert", "0"));
            tad.Add(new Class_SXWAttributeDigital("FlashingAlert", "1"));

            tas.Add(new Class_SXWAttributeString("Name", "AlmSaFanStsAlm"));
            tas.Add(new Class_SXWAttributeString("Description", "Supply Air Fan Status Alarm"));
            tas.Add(new Class_SXWAttributeString("AlarmMessage", "Supply Air Fan Status Alarm"));
            tas.Add(new Class_SXWAttributeString("ResetMessage", "Supply Air Fan Status Alarm Returned To Normal"));

            tso.Add(new Class_SXWObject("AlmSaFanStsAlm", "Supply Air Fan Status Alarm", taa, tad, tas));

            taa.Clear();
            tad.Clear();
            tas.Clear();

            tso.Add(new Class_SXWObject("SaFanCmd", "Supply Air Fan Command", taa, tad, tas));

            taa.Clear();
            tad.Clear();
            tas.Clear();

            tso.Add(new Class_SXWObject("SaFanSts", "Supply Air Fan Status", taa, tad, tas));

            listMasterSXWComponents.Add(new Class_SXWComponent("SaFan-Type01", "Supply Air Fan Command/Status - Status Alarm - Status Trend", tso));
            */



            //List<Class_AttributeParent> tap = new List<Class_AttributeParent>();
            //tap.Add(new Class_AttributeParent("AlarmMessage", "Alarm Message", "Supply Air Fan Status Alarm"));

            /*
                List<Class_AttributeParent> tap = new List<Class_AttributeParent>();

                List<String> editableAttributes = GetEditableAttributes("bacnet.EventEnrollment")
                if(editableAttributes.Count > 0) 
                {
                    foreach (string ea in editableAttributes)
                        
                        

                }
            */

            

        }

        public void testListCreation()
        {
            MessageBox.Show(listMasterSXWComponents.Count.ToString());
            lb_SWComps.DataSource = listMasterSXWComponents;
            lb_SWComps.DisplayMember = "compName";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_SWComps_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_SWComps.DataSource = listMasterSXWComponents;
            lb_SWComps.DisplayMember = "compName";
        }
    }
}
