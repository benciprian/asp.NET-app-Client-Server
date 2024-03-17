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
    public partial class Adaugare_Programare : Form
    {
        app_ITP_client.ServiceReference1.WebService1SoapClient service = new ServiceReference1.WebService1SoapClient();
        public Adaugare_Programare()
        {
            InitializeComponent();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            Finalizare_Programare end = new Finalizare_Programare();
            end.Show();
            this.Close();
        }

        private void button_salveaza_Click(object sender, EventArgs e)
        {
            int Id_Programare = int.Parse(textBox_Id_Programare.Text);
            string DataProgramare = textBox_DataProgramare.Text;
            string OraProgramare = textBox_OraProgramare.Text;
            int id_Vehicul = int.Parse(textBox_id_Vehicul.Text);
            int Id_Client = int.Parse(textBox_Id_Client.Text);
            int Id_Inspector = int.Parse(textBox_Id_Inspector.Text);    
            try
            {
                service.AdaugareProgramare(Id_Programare, DataProgramare, OraProgramare, id_Vehicul.ToString(), Id_Client.ToString(), Id_Inspector.ToString());

                MessageBox.Show("Programarea d-voastra a fost realizata cu succes!");
            }
            catch
            {
                MessageBox.Show("Problema tehnica! Va rugam reveniti mai tarziu!");
            }
            textBox_Id_Programare.Clear();
            textBox_DataProgramare.Clear();
            textBox_OraProgramare.Clear();
            textBox_id_Vehicul.Clear();
            textBox_Id_Client.Clear();
            textBox_Id_Inspector.Clear();

        }

        private void button_modifica_Click(object sender, EventArgs e)
        {
            int Id_Programare = int.Parse(textBox_Id_Programare.Text);
            string DataProgramare = textBox_DataProgramare.Text;
            string OraProgramare = textBox_OraProgramare.Text;
            int id_Vehicul = int.Parse(textBox_id_Vehicul.Text);
            int Id_Client = int.Parse(textBox_Id_Client.Text);
            int Id_Inspector = int.Parse(textBox_Id_Inspector.Text);
            try
            {
                service.ModificareProgramare(Id_Programare, DataProgramare, OraProgramare, id_Vehicul, Id_Client, Id_Inspector);
                MessageBox.Show("Programarea d-voastra a fost modificata!");
            }
            catch
            {
                MessageBox.Show("Problema tehnica! Va rugam reveniti mai tarziu!");
            }
             textBox_Id_Programare.Clear();
             textBox_DataProgramare.Clear();
             textBox_OraProgramare.Clear();
             textBox_id_Vehicul.Clear();
             textBox_Id_Client.Clear();
             textBox_Id_Inspector.Clear();

        }

        private void button_sterge_Click(object sender, EventArgs e)
        {
            int Id_Programare = int.Parse(textBox_Id_Programare.Text);
            try
            {
                service.StergereProgramare(Id_Programare);
                MessageBox.Show("Programarea d-voastra a fost stearsa! Va dorim o zi buna!");
            }
            catch
            {
                MessageBox.Show("Problema tehnica! Va rugam reveniti mai tarziu!");
            }
            textBox_Id_Programare.Clear();

        }
    }
}
