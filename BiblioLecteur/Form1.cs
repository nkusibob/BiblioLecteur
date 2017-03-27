using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace BiblioLecteur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            loadingData();

            MajorPanel.Hide();

        }
        public static string myuser;
        public static string mybiblio;
        public static string titre;

        public static string getHashSha256(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }
        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                ServiceReferenceLecteur.ServiceLecteurClient s_lect = new ServiceReferenceLecteur.ServiceLecteurClient();






                var x = s_lect.getAll(userTextBox.Text, textBoxPassword.Text, comboBoxBiblio.SelectedItem.ToString());
         


                if (x.Count() > 0)
                {
                    myuser = userTextBox.Text;
                    mybiblio = comboBoxBiblio.SelectedValue.ToString();
                    gridData.DataSource = null;

                    ServiceReferenceCopy.ServiceExemplairesClient se = new ServiceReferenceCopy.ServiceExemplairesClient();
                    gridData.DataSource = se.GetAllExemBiblio(comboBoxBiblio.SelectedValue.ToString());
                    gridData.Columns["achat"].Visible = false;
                    gridData.Columns["date_emprunt"].Visible = false;
                    gridData.Columns["id_biblio"].Visible = false;
                    gridData.Columns["idLivre"].Visible = false;

                    label1.Text = "Bonjour " + userTextBox.Text + ",  vous êtes à " + comboBoxBiblio.SelectedValue.ToString();
                    if (gridData != null)
                    {
                        gridData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        gridData.Columns[gridData.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    MessageBox.Show("Hello " + userTextBox.Text + ", you're now connected to  " + comboBoxBiblio.SelectedValue.ToString());
                  
                    panelLog.Hide();
                    MajorPanel.Show();
                    
                }
                else
                {

                    MessageBox.Show("utisateur non connu ");

                }


            }
            catch (SqlException ex)
            {
                string myerror;
                switch (ex.Number)
                {
                    case 18456:
                        myerror = "mauvais user";
                        break;
                    case 4060:
                        myerror = "mauvaise db";
                        break;
                    default:
                        myerror = ex.Message;
                        break;

                }
                MessageBox.Show("une erreur est survenue détails: " + myerror);

            }

        }




        private void button2_Click(object sender, EventArgs e)
        {
            gridData.DataSource = null;
            MajorPanel.Hide();
            panelLog.Show();
            userTextBox.Text = "";
            textBoxPassword.Text = "";

        }


        private void buttonRetard_Click(object sender, EventArgs e)
        {
            ServiceReferenceRetard.RetardsClient scv = new ServiceReferenceRetard.RetardsClient();
         
            gridData.DataSource = null;


            gridData.DataSource = scv.GetAllRetardsUsers(myuser);
            
            gridData.Columns["tarifEmprunt"].Visible = false;
            gridData.Columns["exemplaireID"].Visible = false;
            gridData.Columns["tarifParJour"].Visible = false;
            gridData.Columns["tarifRetard"].Visible = false;
            gridData.Columns["date_retour"].Visible = false;
            gridData.Columns["date_Emprunt"].Visible = false;
            if (gridData != null)
            {
                gridData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                gridData.Columns[gridData.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

        private void loadingData()
        {
            try
            {
                ServiceReferenceBiblio.ServiceBiblioClient sb1 = new ServiceReferenceBiblio.ServiceBiblioClient();


                sb1.GetAll();

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = sb1.GetAll();
                comboBoxBiblio.DataSource = bindingSource.DataSource;
                comboBoxBiblio.DisplayMember = "libellé";
                comboBoxBiblio.ValueMember = "libellé";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }




        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            try
            {

                ServiceReferenceReservations.ReservationsServiceClient sres = new ServiceReferenceReservations.ReservationsServiceClient();
                gridData.DataSource = null;
                gridData.DataSource = sres.getAllReservations(mybiblio, myuser);
                if (gridData != null)
                {
                    gridData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    gridData.Columns[gridData.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReferenceReservations.ReservationsServiceClient sres = new ServiceReferenceReservations.ReservationsServiceClient();
                gridData.DataSource = null;
                gridData.DataSource = sres.getAllUserReservations(myuser);
                if (gridData != null)
                {
                    gridData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    gridData.Columns[gridData.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
     

        private void buttonSearch_Click(object sender, EventArgs e)
        {


            string searchValue = textBoxCode.Text;
           
     
            try
            {
               ServiceReferenceCopy.ServiceExemplairesClient se = new ServiceReferenceCopy.ServiceExemplairesClient();

                gridData.DataSource = se.SearchExemBiblio(comboBoxBiblio.SelectedValue.ToString(), textBoxCode.Text);
                if (gridData != null)
                {
                    gridData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    gridData.Columns[gridData.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                gridData.Columns["achat"].Visible = false;
                gridData.Columns["date_emprunt"].Visible = false;
                gridData.Columns["id_biblio"].Visible = false;
                gridData.Columns["idLivre"].Visible = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        








        }
      
        private void reserverToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form2 f = new Form2();

            f.ShowDialog();
        }

        private void emprunterToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormInsertEmprunt oForm = new FormInsertEmprunt();
           
            oForm.ShowDialog();

        }

        private void buttonExemplaireBibliotheque_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReferenceCopy.ServiceExemplairesClient se = new ServiceReferenceCopy.ServiceExemplairesClient();

                gridData.DataSource = se.GetAllExemBiblio(comboBoxBiblio.SelectedValue.ToString());
                if (gridData != null)
                {
                    gridData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    gridData.Columns[gridData.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                gridData.Columns["achat"].Visible = false;
                gridData.Columns["date_emprunt"].Visible = false;
                gridData.Columns["id_biblio"].Visible = false;
                gridData.Columns["idLivre"].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void gridData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 3)
                {
                    titre = gridData.SelectedCells[0].Value.ToString();
                    ServiceReferenceLivre.ServiceLivresClient se = new ServiceReferenceLivre.ServiceLivresClient();
                    string imageUrl = se.getImageEF(titre);

                    pictureBoxImageLivre.ImageLocation = imageUrl;
                    pictureBoxImageLivre.SizeMode = PictureBoxSizeMode.AutoSize;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBoxImageLivre_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }



       
    }
 }


