using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatvanyossagokApplication
{
    public partial class LatvanyossagModositas : Form
    {
        MySqlConnection conn;
        int id, ar;
        string nev, leiras;
        public LatvanyossagModositas(int id, string nev, string leiras, int ar)
        {
            InitializeComponent();
            kapcsolodas();
            this.id = id;
            this.nev = nev;
            this.leiras = leiras;
            this.ar = ar;
            txtBx_nevLatvanyossagMod.Text = nev;
            txtBx_leirasMod.Text = leiras;
            txtBx_arMod.Text = ar.ToString();

            this.FormClosed += (sender, args) =>
            {
                if (conn != null)
                {
                    conn.Close();
                }
            };
        }
        void kapcsolodas()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "root";
            sb.Database = "latvanyossagokdb";
            try
            {
                conn = new MySqlConnection(sb.ToString());
                conn.Open();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Sikertelen kapcsolódás az adatbázishoz!\nA program bezáródik!");
                Environment.Exit(0);
            }
        }

        private void bttn_latvanyossagMod_Click(object sender, EventArgs e)
        {
            if (txtBx_nevLatvanyossagMod.Text == "" || txtBx_arMod.Text == "" || txtBx_leirasMod.Text == "")
                MessageBox.Show("Ellenőrízze, hogy mindent kitöltött e!", "Hiba!");
            else if (txtBx_nevLatvanyossagMod.Text == nev && txtBx_arMod.Text == ar.ToString() && txtBx_leirasMod.Text == leiras)
                MessageBox.Show("Nem módosított egyetlen adatot sem!", "Hiba!");
            else
            {
                var updateComm = conn.CreateCommand();

                updateComm.CommandText = @"
                    UPDATE latvanyossagok
                    SET nev=@nev,
                        leiras=@leiras,
                        ar=@ar
                    WHERE id=@id";
                updateComm.Parameters.AddWithValue("@id", this.id);
                updateComm.Parameters.AddWithValue("@nev", txtBx_nevLatvanyossagMod.Text);
                updateComm.Parameters.AddWithValue("@leiras", txtBx_leirasMod.Text);
                updateComm.Parameters.AddWithValue("@ar", txtBx_arMod.Text);

                try
                {
                    var muvelet = updateComm.ExecuteNonQuery();
                    if (muvelet >= 1)
                        MessageBox.Show("Sikeres módosítás", "Siker!");
                    else
                        MessageBox.Show("Nem sikerült az adatot módosítani!", "Hiba!");
                    this.Close();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Adatbázis hiba!", "Hiba!");
                    this.Close();
                }
            }
        }
    }
}
