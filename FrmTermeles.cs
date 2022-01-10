using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TojasManufaktura
{
    public partial class FrmTermeles : Form
    {
        public string ConnectionString { get; private set; }
        public FrmTermeles(string connectionString)
        {
            ConnectionString = connectionString;
            InitializeComponent();
        }

        private void FrmTermeles_Load(object sender, EventArgs e)
        {
            FillDGV();
            FillCB();
        }

        private void FillDGV()
        {
            
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                var r = new SqlCommand("SELECT Termeles.Datum, Tojas.Szin, Termeles.Mennyiseg, Nyul.Nev FROM Termeles, Tojas, Nyul WHERE Termeles.TipusId = Tojas.Id " +
                    "AND Termeles.NyulId = Nyul.Id ORDER BY Termeles.Datum;", c).ExecuteReader();
                while (r.Read())
                {
                    dgv.Rows.Add(r.GetDateTime(0).ToString("yyyy-MM-dd"),r[1],r[2] + "db",r[3]);
                }
                
            }
        }
        private void FillCB()
        {
            
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                var r = new SqlCommand("SELECT Szin FROM Tojas;", c).ExecuteReader();
                while (r.Read()) cbTojas.Items.Add(r[0]);
                
            }
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                var r = new SqlCommand("SELECT Nev FROM Nyul;", c).ExecuteReader();
                while (r.Read()) cbMunkas.Items.Add(r[0]);
            }
        }

        private void BtnUjbejegyzes_Click(object sender, EventArgs e)
        {
            string datum = dtpDatum.Value.ToString("yyyy-MM-dd");
            string tojasId = $"{cbTojas.SelectedIndex + 1}";
            string munkasId = $"{cbMunkas.SelectedIndex + 1}";
            string mennyiseg = $"{nudMennyiseg.Value}";
            string szin = cbTojas.Text;
            string munkas = cbMunkas.Text;
            string hibaUzenet = "";

            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                try
                {
                    if (!string.IsNullOrEmpty(hibaUzenet))
                        throw new Exception(hibaUzenet);
                    if (string.IsNullOrWhiteSpace(munkas))
                        hibaUzenet += "A munkás neve nem maradhat üresen!";
                    if (string.IsNullOrWhiteSpace(szin))
                        hibaUzenet += "A tojás színe nem maradhat üresen!";
                    if (int.Parse(mennyiseg) == 0)
                        hibaUzenet += "A mennyiség nem lehet nulla!";
                    
                    new SqlCommand($"INSERT INTO Termeles VALUES('{datum}', {tojasId}, {munkasId}, {mennyiseg});", c).ExecuteNonQuery();
                    MessageBox.Show("Sikeres felvétel!");
                    FillDGV();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }

        }
    }
}
