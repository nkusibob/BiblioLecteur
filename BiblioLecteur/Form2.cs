using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioLecteur
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
          
        }

       

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReferenceReservations.ReservationsServiceClient se = new ServiceReferenceReservations.ReservationsServiceClient();
                se.insertReservation(textBoxLivreNom.Text, Form1.myuser);
                MessageBox.Show("reservation effectuée");
            }
            catch (Exception ex)
            {

                MessageBox.Show("veuillez vérifier les données entrées  "); 
            }
        }

        private void gridData2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBoxLivreNom.Text = Form1.titre;
        }
    }
}
