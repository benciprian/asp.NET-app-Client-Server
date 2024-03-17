using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using static System.Net.WebRequestMethods;

namespace app_IPT_server
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        SqlConnection myCon = new SqlConnection();

        [WebMethod]
        public void AdaugareClienti(int Id_Client,string Nume, string Prenume, string Telefon, string Email)
        {
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\benfl\OneDrive\Desktop\programare avansata\app_IPT_server\app_IPT_server\App_Data\itp.mdf"";Integrated Security=True";
            myCon.Open();
            //SqlDataAdapter = contine un set de comenzi de date si conexiunea la db si este folosit pentru a interschimba date intre datatset si db
            SqlDataAdapter cursAdapter = new SqlDataAdapter("SELECT * FROM Clienti ORDER BY Id_Client", myCon);
            //SqlCommandBuilder poate genera instructiuni CRUD folosind proprietatea SelectCommand
            SqlCommandBuilder cursBuilder = new SqlCommandBuilder(cursAdapter);
            //DataSet - manipularea datelor
            DataSet newQueryClient = new DataSet();
            //folosind dataAdapterul si proprietatea Fill, vom face o copie a datelor din db in dataSet
            cursAdapter.Fill(newQueryClient, "Clienti");
            //se creaza un rand nou de tipul DatePersoane
            DataRow newRow = newQueryClient.Tables["Clienti"].NewRow();
            //populam noul rand creat
            newRow["Id_Client"] = Id_Client;
            newRow["Nume"] = Nume;
            newRow["Prenume"] = Prenume;
            newRow["Telefon"] = Telefon;
            newRow["Email"] = Email;
            //Facem adaugarea in dataSet 
            newQueryClient.Tables["Clienti"].Rows.Add(newRow);
            //facem update cu noul dataSet in db
            cursAdapter.Update(newQueryClient, "Clienti");
            myCon.Close();
        }
        
        [WebMethod]
        public void AdaugareInspectori(int Id_Inspector, string Nume, string Prenume, string Specializare)
        {
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\benfl\OneDrive\Desktop\programare avansata\app_IPT_server\app_IPT_server\App_Data\itp.mdf"";Integrated Security=True";
            myCon.Open();
            //SqlDataAdapter = contine un set de comenzi de date si conexiunea la db si este folosit pentru a interschimba date intre datatset si db
            SqlDataAdapter cursAdapter = new SqlDataAdapter("SELECT * FROM Inspector ORDER BY Id_Inspector", myCon);
            //SqlCommandBuilder poate genera instructiuni CRUD folosind proprietatea SelectCommand
            SqlCommandBuilder cursBuilder = new SqlCommandBuilder(cursAdapter);
            //DataSet - manipularea datelor
            DataSet newQueryInspect = new DataSet();
            //folosind dataAdapterul si proprietatea Fill, vom face o copie a datelor din db in dataSet
            cursAdapter.Fill(newQueryInspect, "Inspector");
            //se creaza un rand nou de tipul DatePersoane
            DataRow newRow = newQueryInspect.Tables["Inspector"].NewRow();
            //populam noul rand creat
            newRow["Id_Inspector"] = Id_Inspector;
            newRow["Nume"] = Nume;
            newRow["Prenume"] = Prenume;
            newRow["Specializare"] = Specializare;
            //Facem adaugarea in dataSet 
            newQueryInspect.Tables["Inspector"].Rows.Add(newRow);
            //facem update cu noul dataSet in db
            cursAdapter.Update(newQueryInspect, "Inspector");
            myCon.Close();
        }

        [WebMethod]
        public void AdaugareVehicule(int id_Vehicul, string Marca, string Model, string AnFabricatie,string NumarInmatriculare)
        {
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\benfl\OneDrive\Desktop\programare avansata\app_IPT_server\app_IPT_server\App_Data\itp.mdf"";Integrated Security=True";
            myCon.Open();
            //SqlDataAdapter = contine un set de comenzi de date si conexiunea la db si este folosit pentru a interschimba date intre datatset si db
            SqlDataAdapter cursAdapter = new SqlDataAdapter("SELECT * FROM Vehicule ORDER BY id_Vehicul", myCon);
            //SqlCommandBuilder poate genera instructiuni CRUD folosind proprietatea SelectCommand
            SqlCommandBuilder cursBuilder = new SqlCommandBuilder(cursAdapter);
            //DataSet - manipularea datelor
            DataSet newQueryVehicul = new DataSet();
            //folosind dataAdapterul si proprietatea Fill, vom face o copie a datelor din db in dataSet
            cursAdapter.Fill(newQueryVehicul, "Vehicule");
            //se creaza un rand nou de tipul DatePersoane
            DataRow newRow = newQueryVehicul.Tables["Vehicule"].NewRow();
            //populam noul rand creat
            newRow["id_Vehicul"] = id_Vehicul;
            newRow["Marca"] = Marca;
            newRow["Model"] = Model;
            newRow["AnFabricatie"] = AnFabricatie;
            newRow["NumarInmatriculare"] = NumarInmatriculare;
            //Facem adaugarea in dataSet 
            newQueryVehicul.Tables["Vehicule"].Rows.Add(newRow);
            //facem update cu noul dataSet in db
            cursAdapter.Update(newQueryVehicul, "Vehicule");
            myCon.Close();
        }

        [WebMethod]
        public void AdaugareProgramare(int Id_Programare, string DataProgramare, string OraProgramare, string id_Vehicul, string Id_Client, string Id_Inspector)
        {
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\benfl\OneDrive\Desktop\programare avansata\app_IPT_server\app_IPT_server\App_Data\itp.mdf"";Integrated Security=True";
            myCon.Open();
            //SqlDataAdapter = contine un set de comenzi de date si conexiunea la db si este folosit pentru a interschimba date intre datatset si db
            SqlDataAdapter cursAdapter = new SqlDataAdapter("SELECT * FROM Programari ORDER BY Id_Programare", myCon);
            //SqlCommandBuilder poate genera instructiuni CRUD folosind proprietatea SelectCommand
            SqlCommandBuilder cursBuilder = new SqlCommandBuilder(cursAdapter);
            //DataSet - manipularea datelor
            DataSet newQueryProg = new DataSet();
            //folosind dataAdapterul si proprietatea Fill, vom face o copie a datelor din db in dataSet
            cursAdapter.Fill(newQueryProg, "Programari");
            //se creaza un rand nou de tipul DatePersoane
            DataRow newRow = newQueryProg.Tables["Programari"].NewRow();
            //populam noul rand creat
            newRow["Id_Programare"] = Id_Programare;
            newRow["DataProgramare"] = DataProgramare;
            newRow["OraProgramare"] = OraProgramare;
            newRow["id_Vehicul"] = id_Vehicul;
            newRow["Id_Client"] = Id_Client;
            newRow["Id_Inspector"] = Id_Inspector;
            //Facem adaugarea in dataSet 
            newQueryProg.Tables["Programari"].Rows.Add(newRow);
            //facem update cu noul dataSet in db
            cursAdapter.Update(newQueryProg, "Programari");
            myCon.Close();
        }

        [WebMethod]
        public void AdaugareRezultateInspectii(int Id_Inspectie, string Status, string Observatii, string Id_Programare)
        {
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\benfl\OneDrive\Desktop\programare avansata\app_IPT_server\app_IPT_server\App_Data\itp.mdf"";Integrated Security=True";
            myCon.Open();
            //SqlDataAdapter = contine un set de comenzi de date si conexiunea la db si este folosit pentru a interschimba date intre datatset si db
            SqlDataAdapter cursAdapter = new SqlDataAdapter("SELECT * FROM Rezultate_Inspectii ORDER BY Id_Inspectie", myCon);
            //SqlCommandBuilder poate genera instructiuni CRUD folosind proprietatea SelectCommand
            SqlCommandBuilder cursBuilder = new SqlCommandBuilder(cursAdapter);
            //DataSet - manipularea datelor
            DataSet newQueryRezInspect = new DataSet();
            //folosind dataAdapterul si proprietatea Fill, vom face o copie a datelor din db in dataSet
            cursAdapter.Fill(newQueryRezInspect, "Rezultate_Inspectii");
            //se creaza un rand nou de tipul DatePersoane
            DataRow newRow = newQueryRezInspect.Tables["Rezultate_Inspectii"].NewRow();
            //populam noul rand creat
            newRow["Id_Inspectie"] = Id_Inspectie;
            newRow["Status"] = Status;
            newRow["Observatii"] = Observatii;
            newRow["Id_Programare"] = Id_Programare;
            
            //Facem adaugarea in dataSet 
            newQueryRezInspect.Tables["Rezultate_Inspectii"].Rows.Add(newRow);
            //facem update cu noul dataSet in db
            cursAdapter.Update(newQueryRezInspect, "Rezultate_Inspectii");
            myCon.Close();
        }

        [WebMethod]
        public void StergereProgramare(int Id_Programare)
        {
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\benfl\OneDrive\Desktop\programare avansata\app_IPT_server\app_IPT_server\App_Data\itp.mdf"";Integrated Security=True";
            myCon.Open();
            SqlDataAdapter cursAdapter = new SqlDataAdapter("SELECT * FROM Programari ORDER BY Id_Programare", myCon);
            SqlCommandBuilder cursBuilder = new SqlCommandBuilder(cursAdapter);
            DataSet deleteProg = new DataSet();
            cursAdapter.Fill(deleteProg, "Programari"); //in dataSet facem o copie a tabelei

            DataColumn[] pk = new DataColumn[1];//definim un array de ob DataColumn cu 1 elemenet
            pk[0] = deleteProg.Tables["Programari"].Columns["Id_Programare"];//pe primul elem din array  punem coloana Id_Programare care este de tipul DataColumn
            deleteProg.Tables["Programari"].PrimaryKey = pk;//setam pe dataSet ca si cheie primara Id_Programare pe care l-am definit anterior

            ////cautam Row-ul corespunzator id_p-ului primit pe metoda
            DataRow caut = null;

            while (caut == null)
            {
                caut = deleteProg.Tables["Programari"].Rows.Find(Id_Programare); //cauta dupa Id_Programare
            }
            caut.Delete(); //sterge randul gasit in dataSet
            cursAdapter.Update(deleteProg, "Programari");//updateaza tabela din db cu dataSetul 
            myCon.Close();
        }

        [WebMethod]
        public void StergereRezultateInspectii(int Id_Inspectie)
        {
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\benfl\OneDrive\Desktop\programare avansata\app_IPT_server\app_IPT_server\App_Data\itp.mdf"";Integrated Security=True";
            myCon.Open();
            SqlDataAdapter cursAdapter = new SqlDataAdapter("SELECT * FROM Rezultate_Inspectii ORDER BY Id_Inspectie", myCon);
            SqlCommandBuilder cursBuilder = new SqlCommandBuilder(cursAdapter);
            DataSet deleteRezInspect = new DataSet();
            cursAdapter.Fill(deleteRezInspect, "Rezultate_Inspectii"); //in dataSet facem o copie a tabelei

            DataColumn[] pk = new DataColumn[1];//definim un array de ob DataColumn cu 1 elemenet
            pk[0] = deleteRezInspect.Tables["Rezultate_Inspectii"].Columns["Id_Inspectie"];//pe primul elem din array  punem coloana Id_Inspectie care este de tipul DataColumn
            deleteRezInspect.Tables["Rezultate_Inspectii"].PrimaryKey = pk;//setam pe dataSet ca si cheie primara Id_Inspectie pe care l-am definit anterior

            ////cautam Row-ul corespunzator id_p-ului primit pe metoda
            DataRow caut = null;
            while (caut == null)
            {
                caut = deleteRezInspect.Tables["Rezultate_Inspectii"].Rows.Find(Id_Inspectie); //cauta dupa Id_Inspectie
            }
            caut.Delete(); //sterge randul gasit in dataSet
            cursAdapter.Update(deleteRezInspect, "Rezultate_Inspectii");//updateaza tabela din db cu dataSetul 
            myCon.Close();
        }

        [WebMethod]
        public void ModificareProgramare(int Id_Programare, string DataProgramare, string OraProgramare, int id_Vehicul, int Id_Client, int Id_Inspector)
        {
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\benfl\OneDrive\Desktop\programare avansata\app_IPT_server\app_IPT_server\App_Data\itp.mdf"";Integrated Security=True";
            myCon.Open();
            SqlDataAdapter cursAdapter = new SqlDataAdapter("SELECT * FROM Programari ORDER BY Id_Programare", myCon);
            SqlCommandBuilder cursBuilder = new SqlCommandBuilder(cursAdapter);
            DataSet updateProg = new DataSet();
            cursAdapter.Fill(updateProg, "Programari"); //in dataSet facem o copie a tabelei

            DataColumn[] pk = new DataColumn[1]; //definim un array de ob DataColumn cu 1 element
            pk[0] = updateProg.Tables["Programari"].Columns["Id_Programare"]; //pe primul elem din array punem coloana Id_Programare 
            updateProg.Tables["Programari"].PrimaryKey = pk; ////setam pe dataSet ca si cheie primara id pe care l-am definit anterior

            // ////cautam Row-ul corespunzator  primit pe metoda
            DataRow caut = null;
            while (caut == null)
            {
                caut = updateProg.Tables["Programari"].Rows.Find(Id_Programare); //cautam dupa Id_Programare
            }
            //populam randul creat
            caut["DataProgramare"] = DataProgramare;
            caut["OraProgramare"] = OraProgramare;
            caut["id_Vehicul"] = id_Vehicul;
            caut["Id_Client"] = Id_Client;
            caut["Id_Inspector"] = Id_Inspector;
            //facem update cu noul dataSet in db
            cursAdapter.Update(updateProg, "Programari");
            myCon.Close();
        }

        [WebMethod]
        public void ModificareClienti(int Id_Client, string Nume, string Prenume, string Telefon, string Email)
        {
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\benfl\OneDrive\Desktop\programare avansata\app_IPT_server\app_IPT_server\App_Data\itp.mdf"";Integrated Security=True";
            myCon.Open();
            SqlDataAdapter cursAdapter = new SqlDataAdapter("SELECT * FROM Clienti ORDER BY Id_Client", myCon);
            SqlCommandBuilder cursBuilder = new SqlCommandBuilder(cursAdapter);
            DataSet updateClient = new DataSet();
            cursAdapter.Fill(updateClient, "Clienti"); //in dataSet facem o copie a tabelei

            DataColumn[] pk = new DataColumn[1];//definim un array de ob DataColumn cu 1 element
            pk[0] = updateClient.Tables["Clienti"].Columns["Id_Client"];//pe primul elem din array punem coloana cnp
            updateClient.Tables["Clienti"].PrimaryKey = pk;////setam pe dataSet ca si cheie primara id pe care l-am definit anterior

            //cautam Row-ul corespunzator  primit pe metoda
            DataRow caut = null;
            while (caut == null)
            {
                caut = updateClient.Tables["Clienti"].Rows.Find(Id_Client);//cautam dupa Id_Client
            }
            //populam randul creat
            caut["Nume"] = Nume;
            caut["Prenume"] = Prenume;
            caut["Telefon"] = Telefon;
            caut["Email"] = Email;
            //facem update cu noul dataSet in db
            cursAdapter.Update(updateClient, "Clienti");
            myCon.Close();
        }

        [WebMethod]
        public DataSet GetListaClienti()
        {
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\benfl\OneDrive\Desktop\programare avansata\app_IPT_server\app_IPT_server\App_Data\itp.mdf"";Integrated Security=True";
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id_Client, Nume, Prenume FROM Clienti", myCon);
            DataSet dsClienti = new DataSet();
            adapter.Fill(dsClienti, "Clienti");
            return dsClienti;
        }

        [WebMethod]
        public DataSet GetListaVehicule()
        {
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\benfl\OneDrive\Desktop\programare avansata\app_IPT_server\app_IPT_server\App_Data\itp.mdf"";Integrated Security=True";
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id_Vehicul, Marca, Model FROM Vehicule", myCon);
            DataSet dsVehicule = new DataSet();
            adapter.Fill(dsVehicule, "Vehicule");
            return dsVehicule;
        }

        [WebMethod]
        public DataSet GetListaInspector()
        {
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\benfl\OneDrive\Desktop\programare avansata\app_IPT_server\app_IPT_server\App_Data\itp.mdf"";Integrated Security=True";
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id_Inspector, Nume, Prenume FROM Inspector", myCon);
            DataSet dsInspector = new DataSet();
            adapter.Fill(dsInspector, "Inspector");
            return dsInspector;
        }


    }
}
