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
    public partial class Adaugare_Vehicul : Form
    {
        app_ITP_client.ServiceReference1.WebService1SoapClient service = new ServiceReference1.WebService1SoapClient();
        public Adaugare_Vehicul()
        {
            InitializeComponent();
        }

       
        private void Adaugare_Vehicul_Load(object sender, EventArgs e)
        {
            
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            Adaugare_Programare programare = new Adaugare_Programare();
            programare.Show();
            this.Close();

        }

        private void button_salveaza_Click(object sender, EventArgs e)
        {
            int id_Vehicul = int.Parse(textBox_id_Vehicul.Text);
            string Marca = textBox_Marca.Text;
            string Model = textBox_Model.Text;
            string AnFabricatie = textBox_AnFabricatie.Text;
            string NumarInmatriculare = textBox_NumarInmatriculare.Text;
            try
            {
                service.AdaugareVehicule(id_Vehicul, Marca, Model, AnFabricatie, NumarInmatriculare);
                MessageBox.Show("Datele d-voastra au fost adaugate cu succes!");
            }
            catch
            {
                MessageBox.Show("Problema tehnica! Va rugam reveniti mai tarziu!");
            }

            // Id_CLIENT = Id_Client;
            textBox_id_Vehicul.Clear();
            textBox_Marca.Clear();
            textBox_Model.Clear();
            textBox_AnFabricatie.Clear();
            textBox_NumarInmatriculare.Clear();

        }
    }
}
