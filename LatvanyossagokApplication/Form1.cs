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
        MySqlDataAdapter da, da2;
        DataSet ds, ds2;
        List<Varos> varosok;
        List<Latvanyossag> latvanyossagok;
        public Form1()
        {
            InitializeComponent();

            kapcsolodas();

            tablakLetrehozasa();

            adatbetoltes();

            lstBx_varosok.SelectedItem = null;

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
                                   FOREIGN KEY (varos_id) REFERENCES varosok(id) ON DELETE CASCADE ON UPDATE RESTRICT
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
            catch (MySqlException)
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
            cmbBx_nev.DataSource = ds.Tables[0];
            cmbBx_nev.DisplayMember = "nev";
            cmbBx_nev.ValueMember = "id";

            varosok = new List<Varos>();
            latvanyossagok = new List<Latvanyossag>();

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                var varos = new Varos
                {
                    Id = (int)item[0],
                    Nev = item[1].ToString(),
                    Lakossag = (int)item[2],
                    Latvanyossagok = new List<Latvanyossag>()
                };
                varosok.Add(varos);
            }
            lstBx_varosok.DataSource = varosok;
            string sql = "SELECT * FROM latvanyossagok";
            this.da2 = new MySqlDataAdapter(sql, this.conn);
            this.ds2 = new DataSet();
            da2.Fill(ds2);
            foreach (DataRow item in ds2.Tables[0].Rows)
            {
                var latv = new Latvanyossag
                {
                    Id = (int)item[0],
                    VarosId = (int)item[1],
                    Nev = item[2].ToString(),
                    Leiras = item[3].ToString(),
                    Ar = (int)item[4]
                };
                latvanyossagok.Add(latv);
            }
            foreach (var item in latvanyossagok)
            {
                varosok.Find((x) => x.Id == item.VarosId).Latvanyossagok.Add(item);
            }
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

                        varosInsertComm.Parameters.AddWithValue("@nev", txtBx_varosnev.Text.ToUpper());
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
                                adatbetoltes();
                            }
                            else
                                MessageBox.Show("Nem sikerült az adatot beszúrni!", "Hiba!");
                        }
                        catch (MySqlException)
                        {
                            MessageBox.Show("Adatbázis hiba!", "Hiba!");
                        }
                        lstBx_varosok.SelectedItem = null;
                    }
                }
            }
        }

        private void lstBx_varosok_MouseClick(object sender, MouseEventArgs e)
        {
            if (lstBx_varosok.SelectedItem != null)
            {
                bttn_varosMod.Enabled = true;
            }
            else
            {
                bttn_varosMod.Enabled = false;
            }
        }

        private void bttn_varosMod_Click(object sender, EventArgs e)
        {
            if (lstBx_varosok.SelectedItem != null)
            {
                var mod = new VarosModositas(((Varos)lstBx_varosok.SelectedItem).Id,
                    ((Varos)lstBx_varosok.SelectedItem).Nev,
                    ((Varos)lstBx_varosok.SelectedItem).Lakossag);
                mod.Show();
                mod.FormClosed += (sender, args) =>
                {
                    adatbetoltes();
                };
            }
        }

        private void lstBx_varosok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBx_varosok.SelectedItem != null)
            {
                bttn_varosMod.Enabled = true;
                var v = (Varos)lstBx_varosok.SelectedItem;
                if (v.Latvanyossagok != null)
                {
                    lstBx_latvanyossagok.Items.Clear();
                    foreach (var item in v.Latvanyossagok)
                    {
                        lstBx_latvanyossagok.Items.Add(item);
                    }
                }
            }
            else
            {
                bttn_varosMod.Enabled = false;
            }
        }

        private void lstBx_latvanyossagok_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstBx_latvanyossagok.SelectedItem != null)
            {
                var result = MessageBox.Show("Biztos törli a kijelölt látványosságot?", "Törlés", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var deleteComm = conn.CreateCommand();

                    deleteComm.CommandText = @"
                    DELETE FROM latvanyossagok 
                    WHERE id=@szam";

                    var szam = (Latvanyossag)lstBx_latvanyossagok.SelectedItem;
                    deleteComm.Parameters.AddWithValue("@szam", szam.Id);
                    try
                    {
                        var muvelet = deleteComm.ExecuteNonQuery();
                        if (muvelet >= 1)
                        {
                            MessageBox.Show("Sikeres törlés", "Siker!");
                            adatbetoltes();
                        }
                        else MessageBox.Show("Nem sikerült az adatot törölni!", "Hiba!");
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Adatbázis hiba!", "Hiba!");
                    }
                    lstBx_varosok.SelectedItem = null;
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
                            adatbetoltes();
                        }
                        else
                            MessageBox.Show("Nem sikerült az adatot beszúrni!", "Hiba!");
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Adatbázis hiba!", "Hiba!");
                    }
                    lstBx_varosok.SelectedItem = null;
                }
            }
        }

        private void lstBx_varosok_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstBx_varosok.SelectedItem != null)
            {
                var result = MessageBox.Show("Biztos törli a kijelölt várost?\n" +
                    "Ha törli, akkor a látványosság is törlődik vele együtt", "Törlés", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var deleteComm = conn.CreateCommand();

                    deleteComm.CommandText = @"
                    DELETE FROM varosok 
                    WHERE id=@szam";

                    var szam = (Varos)lstBx_varosok.SelectedItem;
                    deleteComm.Parameters.AddWithValue("@szam", szam.Id);
                    try
                    {
                        //Az adatbázisban CASCADE-ra van állítva az idegen kulcs, így ha kitöröljük a várost
                        //a hozzátartozó látványosság is törlödik
                        var muvelet = deleteComm.ExecuteNonQuery();
                        if (muvelet >= 1)
                        {
                            MessageBox.Show("Sikeres törlés", "Siker!");
                            adatbetoltes();
                        }
                        else MessageBox.Show("Nem sikerült az adatot törölni!", "Hiba!");
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Adatbázis hiba!", "Hiba!");
                    }
                    lstBx_varosok.SelectedItem = null;
                }
            }
        }
    }
}
