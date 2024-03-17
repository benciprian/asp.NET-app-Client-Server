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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Adaugare_Client client = new Adaugare_Client();
        private void button_programari_Click(object sender, EventArgs e)
        {
            client.Show();
        }

        private void button_iesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_rez_inspectie_Click(object sender, EventArgs e)
        {
            Adaugare_Rezultat_InspectieITP rez_inspect_itp = new Adaugare_Rezultat_InspectieITP();
            rez_inspect_itp.Show();
        }
    }
}
