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
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        MySqlDataAdapter da;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();

            kapcsolodas();

            tablakLetrehozasa();

            adatbetoltes();

            cmbBx_nev.DataSource = ds.Tables[0];
            cmbBx_nev.DisplayMember = "nev";
            cmbBx_nev.ValueMember = "id";

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
            catch (MySqlException ex)
            {
                MessageBox.Show("Sikertelen kapcsolódás az adatbázishoz!\nA program bezáródik!");
                Environment.Exit(0);
            }
        }

        void tablakLetrehozasa()
        {
            var varosok = @"CREATE TABLE IF NOT EXISTS varosok (
                          id int(11) NOT NULL AUTO_INCREMENT,
                          nev text COLLATE utf8mb4_hungarian_ci NOT NULL,
                          lakossag int(11) NOT NULL,
                          PRIMARY KEY (id),
                          UNIQUE KEY nev (nev) USING HASH
                          )";
            var latvanyossagok = @"CREATE TABLE IF NOT EXISTS latvanyossagok (
                                   id int(11) NOT NULL AUTO_INCREMENT,
                                   varos_id int(11),
                                   nev text COLLATE utf8mb4_hungarian_ci NOT NULL,
                                   leiras text COLLATE utf8mb4_hungarian_ci NOT NULL,
                                   ar int(11)  DEFAULT NULL,
                                   PRIMARY KEY (id),
                                   FOREIGN KEY (varos_id) REFERENCES varosok(id)
                                   )";
            var varosokComm = this.conn.CreateCommand();
            var latvanyossagokComm = this.conn.CreateCommand();
            varosokComm.CommandText = varosok;
            latvanyossagokComm.CommandText = latvanyossagok;
            try
            {
                varosokComm.ExecuteNonQuery();
                latvanyossagokComm.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Hiba a tábla létrehozása közben!\n A program bezáródik!");
                Environment.Exit(0);
            }
        }

        void adatbetoltes()
        {
            string query = "SELECT * FROM varosok";
            this.da = new MySqlDataAdapter(query, this.conn);
            this.ds = new DataSet();
            da.Fill(ds);
        }

        private void txtBx_lakossag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtBx_ar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bttn_varos_Click(object sender, EventArgs e)
        {
            if (txtBx_varosnev.Text == "" || txtBx_lakossag.Text == "")
                MessageBox.Show("Ellenőrizze, hogy minden mezőt kitöltött e!", "Hiba!");
            else
            {
                var nevSelectComm = this.conn.CreateCommand();
                nevSelectComm.CommandText = "SELECT nev FROM varosok";
                var nevek = new List<string>();
                using (var reader = nevSelectComm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nevek.Add(reader.GetString("nev").ToLower());
                    }
                }
                if (nevek.Contains(txtBx_varosnev.Text.ToLower()))
                {
                    MessageBox.Show("Ilyen névvel már szerepel város az adatbázisban!", "Hiba!");
                }
                else
                {
                    int lakossag;
                    if (!int.TryParse(txtBx_lakossag.Text, out lakossag))
                        MessageBox.Show("A lakosságot csak számmal lehet megadni!", "Hiba!");
                    else
                    {
                        var varosInsertComm = this.conn.CreateCommand();
                        varosInsertComm.CommandText = @"INSERT INTO varosok (nev, lakossag)
                                                  VALUES (@nev,@lakossag)";

                        varosInsertComm.Parameters.AddWithValue("@nev", txtBx_varosnev.Text);
                        varosInsertComm.Parameters.AddWithValue("@lakossag", txtBx_lakossag.Text);
                        try
                        {
                            var muvelet = varosInsertComm.ExecuteNonQuery();
                            if (muvelet >= 1)
                            {
                                MessageBox.Show("Sikeres adatfelvétel", "Siker!");
                                txtBx_varosnev.Text = "";
                                txtBx_lakossag.Text = "";
                                ds.Clear();
                                da.Fill(ds);
                            }
                            else
                                MessageBox.Show("Nem sikerült az adatot beszúrni!", "Hiba!");
                        }
                        catch (MySqlException)
                        {
                            MessageBox.Show("Adatbázis hiba!", "Hiba!");
                        }
                    }
                }
            }
        }

        private void bttn_latvanyossag_Click(object sender, EventArgs e)
        {
            if (txtBx_ar.Text == "" || txtBx_leiras.Text == "" || cmbBx_nev.SelectedValue == null)
                MessageBox.Show("Ellenőrizze, hogy minden mezőt kitöltött e!", "Hiba!");
            else
            {
                int ar;
                if (!int.TryParse(txtBx_ar.Text, out ar))
                    MessageBox.Show("Az árat csak számmal lehet megadni!", "Hiba!");
                else
                {
                    var latvanyossagInsertComm = this.conn.CreateCommand();
                    latvanyossagInsertComm.CommandText = @"
                        INSERT INTO latvanyossagok (varos_id,nev, leiras, ar)
                        VALUES (@id,@nev,@leiras,@ar)";

                    latvanyossagInsertComm.Parameters.AddWithValue("@nev", txtBx_nevLatvanyossag.Text);
                    latvanyossagInsertComm.Parameters.AddWithValue("@leiras", txtBx_leiras.Text);
                    latvanyossagInsertComm.Parameters.AddWithValue("@ar", txtBx_ar.Text);
                    latvanyossagInsertComm.Parameters.AddWithValue("@id", cmbBx_nev.SelectedValue);

                    try
                    {
                        var muvelet = latvanyossagInsertComm.ExecuteNonQuery();
                        if (muvelet >= 1)
                        {
                            MessageBox.Show("Sikeres adatfelvétel", "Siker!");
                            txtBx_ar.Text = "";
                            txtBx_leiras.Text = "";
                            txtBx_nevLatvanyossag.Text = "";
                            ds.Clear();
                            da.Fill(ds);
                        }
                        else
                            MessageBox.Show("Nem sikerült az adatot beszúrni!", "Hiba!");
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Adatbázis hiba!", "Hiba!");
                    } 
                }

            }
        }
    }
}
