using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Ad_Sifre_Ekrani
{
    public partial class FormAnaform : Form
    {
        public FormAnaform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string yol = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + @"\\Data.accdb";
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = yol;

            cmd.Connection = con;
            cmd.CommandText = "select * from Kullanıcı where kadi=" + txtkadi.Text + " and şifre=" + txtşifre.Text;
            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();
            }
            else MessageBox.Show("Yanlış giriş yaptınız");
            con.Close();
        }
    }
}
