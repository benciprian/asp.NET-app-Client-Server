using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_ITP_client
{
    public partial class Adaugare_Inspector : Form
    {
        app_ITP_client.ServiceReference1.WebService1SoapClient service = new ServiceReference1.WebService1SoapClient();
        public Adaugare_Inspector()
        {
            InitializeComponent();
        }

        
        private void button_next_Click(object sender, EventArgs e)
        {
            Adaugare_Vehicul vehicul = new Adaugare_Vehicul();
            vehicul.Show();
            this.Close();
        }

        private void Adaugare_Inspector_Load(object sender, EventArgs e)
        {

        }

        private void button_salveaza_Click(object sender, EventArgs e)
        {
            int Id_Inspector = int.Parse(textBox_Id_Inspector.Text);
            string Nume = textBox_Nume.Text;
            string Prenume = textBox_Prenume.Text;
            string Specializare = textBox_Specializare.Text;
            try
            {
                service.AdaugareInspectori(Id_Inspector, Nume, Prenume, Specializare);
                MessageBox.Show("Datele d-voastra au fost adaugate cu succes!");
            }
            catch
            {
                MessageBox.Show("Problema tehnica! Va rugam reveniti mai tarziu!");
            }

            // Id_CLIENT = Id_Client;
            textBox_Id_Inspector.Clear();
            textBox_Nume.Clear();
            textBox_Prenume.Clear();
            textBox_Specializare.Clear();
            
        }
    }
}
