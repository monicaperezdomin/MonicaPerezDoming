using log4net;
using System;
using System.Collections.Generic;
using System.Web;
using System.Windows.Forms;
using WebServiceClient.ServiceReference2;


namespace WebServiceClient
{
    public partial class Form1 : Form
    {
        private readonly ILog _log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
         
         ServiceReference2.WebServiceImperialSoapClient ClientSoap=new WebServiceImperialSoapClient();
           
            var r= TestRebeld(txtName.Text, txtPlanet.Text);
            if (r)
            {

                string total = txtName.Text.ToString() + " " +txtPlanet.Text.ToString();
                txtFind.Text= ClientSoap.Find(total);
               
            }
            else
            {
                MessageBox.Show("Debe introducir el nombre y el planeta del rebelde");
            }
        }
        
           
    
        public bool TestRebeld(string name,string planet) {
            if (name.Equals("") || planet.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

       
    }

}
