using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TojasManufaktura
{
    public partial class FrmMain : Form
    {
        public string ConnectionString { get; private set; }
        public FrmMain()
        {
            ConnectionString =
               @"Server = (localdb)\MSSQLLocalDB;" +
                "Database = TojasGyar;";
            InitializeComponent();
        }



        private void tbKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            pbNyuszi.Image = Image.FromFile(@"..\..\Resources\nyul.gif");
        }

        private void tbStatisztika_Click(object sender, EventArgs e)
        {
            var frm = new FrmStatisztika(ConnectionString);
            frm.ShowDialog();
        }

        

        private void tbTermeles_Click(object sender, EventArgs e)
        {
            var frm = new FrmTermeles(ConnectionString);
            frm.ShowDialog();
        }
    }
}
