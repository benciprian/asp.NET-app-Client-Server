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
    public partial class Adaugare_Rezultat_InspectieITP : Form
    {
        app_ITP_client.ServiceReference1.WebService1SoapClient service = new ServiceReference1.WebService1SoapClient();
        public Adaugare_Rezultat_InspectieITP()
        {
            InitializeComponent();
        }

        private void button_end_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Adaugare_Rezultat_InspectieITP_Load(object sender, EventArgs e)
        {

        }

        private void button_salveaza_Click(object sender, EventArgs e)
        {
            int Id_Inspectie = int.Parse(textBox_Id_Inspectie.Text);
            string Status = textBox_Status.Text;
            string Observatii = textBox_Observatii.Text;
            int Id_Programare = int.Parse(textBox_Id_Programare.Text);
            try
            {
                service.AdaugareRezultateInspectii(Id_Programare, Status, Observatii, Id_Programare.ToString());

                MessageBox.Show("Rezultatul inspectiei  a fost afisat cu succes!");
            }
            catch
            {
                MessageBox.Show("Problema tehnica! Va rugam reveniti mai tarziu!");
            }
            textBox_Id_Inspectie.Clear();
            textBox_Status.Clear();
            textBox_Observatii.Clear();
            textBox_Id_Programare.Clear();
            
        }

        

        private void button_stergere_Click(object sender, EventArgs e)
        {
            int Id_Inspectie = int.Parse(textBox_Id_Inspectie.Text);
            try
            {
                service.StergereRezultateInspectii(Id_Inspectie);
                MessageBox.Show("Rezultatul inspectiei a fost stears! Va dorim o zi buna!");
            }
            catch
            {
                MessageBox.Show("Problema tehnica! Va rugam reveniti mai tarziu!");
            }
            textBox_Id_Inspectie.Clear();

        }
    }
}
