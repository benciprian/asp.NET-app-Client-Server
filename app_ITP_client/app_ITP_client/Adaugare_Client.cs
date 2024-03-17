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
    public partial class Adaugare_Client : Form
    {
        app_ITP_client.ServiceReference1.WebService1SoapClient service = new ServiceReference1.WebService1SoapClient();
       // public static string Id_CLIENT;
        public Adaugare_Client()
        {
            InitializeComponent();
            label1.Text = "Bine ati venit! Va rugam completati formularul de mai jos pentru a crea contul dvs.";
        }

       
        private void button_next_Click(object sender, EventArgs e)
        {
            Adaugare_Inspector inspector = new Adaugare_Inspector();
            inspector.Show();
            this.Close();
        }

        private void Adaugare_Client_Load(object sender, EventArgs e)
        {

        }

        private void button_salveaza_Click(object sender, EventArgs e)
        {
            int Id_Client = int.Parse(textBox_Id_Client.Text);
            string Nume = textBox_Nume.Text;
            string Prenume = textBox_Prenume.Text;
            string Telefon = textBox_Telefon.Text;
            string Email = textBox_Email.Text;
            try
            {
                service.AdaugareClienti(Id_Client, Nume, Prenume, Telefon, Email);
                MessageBox.Show("Datele d-voastra au fost adaugate cu succes!");
            }
            catch
            {
                MessageBox.Show("Problema tehnica! Va rugam reveniti mai tarziu!");
            }

             // Id_CLIENT = Id_Client;
            textBox_Id_Client.Clear();
            textBox_Nume.Clear();
            textBox_Prenume.Clear();
            textBox_Telefon.Clear();
            textBox_Email.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_modifica_Click(object sender, EventArgs e)
        {
            int Id_Client =int.Parse(textBox_Id_Client.Text);
            string Nume = textBox_Nume.Text;
            string Prenume = textBox_Prenume.Text;
            string Telefon = textBox_Telefon.Text;
            string Email = textBox_Email.Text;
            try
            {
                service.ModificareClienti(Id_Client, Nume, Prenume, Telefon, Email);
                MessageBox.Show("Datele d-voastra au fost modificate!");
            }
            catch
            {
                MessageBox.Show("Problema tehnica! Va rugam reveniti mai tarziu!");
            }
            //CNP = cnp;
            textBox_Id_Client.Clear();
            textBox_Nume.Clear();
            textBox_Prenume.Clear();
            textBox_Telefon.Clear();
            textBox_Email.Clear();
        }
    }
}
