using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioLecteur
{
    public partial class FormInsertEmprunt : Form
    {
        public FormInsertEmprunt()
        {
            InitializeComponent();
        }

        private void buttonInsEmp_Click(object sender, EventArgs e)
        {
            ServiceReferenceEmprunts.ServiceEmpruntsClient ser = new ServiceReferenceEmprunts.ServiceEmpruntsClient();
           
            try
            {

                

                ser.beforeEmprunter(textBoxTitre.Text, Form1.mybiblio, Form1.myuser);
                MessageBox.Show("emprunt effectué");

            }
            catch (FaultException<ServiceReferenceEmprunts.ExceptionContainer> ex2)

            {
                string message = ex2.Message;
                message = message.Replace("The transaction ended in the trigger. The batch has been aborted.", "");
                MessageBox.Show(message);
              
            }
         




        }

        private void FormInsertEmprunt_Load(object sender, EventArgs e)
        {
            textBoxTitre.Text = Form1.titre;
        }

        private void textBoxTitre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
