using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace LatvanyossagokApplication
{
    public partial class VarosModositas : Form
    {
        MySqlConnection conn;
        int id;
        public VarosModositas(int id, string nev, int lakossag)
        {
            InitializeComponent();
            kapcsolodas();
            this.id = id;
            txtBx_varosnevMod.Text = nev;
            txtBx_lakossagMod.Text = lakossag.ToString();

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
        private void bttn_varosMod_Click(object sender, EventArgs e)
        {
            if (txtBx_varosnevMod.Text != "" && txtBx_lakossagMod.Text != "")
            {
                var updateComm = conn.CreateCommand();

                updateComm.CommandText = @"
                    UPDATE varosok
                    SET nev=@nev,
                        lakossag=@lakossag
                    WHERE id=@id";
                updateComm.Parameters.AddWithValue("@id", this.id);
                updateComm.Parameters.AddWithValue("@nev", txtBx_varosnevMod.Text);
                updateComm.Parameters.AddWithValue("@lakossag", txtBx_lakossagMod.Text);

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
                }
            }
            else MessageBox.Show("Ellenőrízze, hogy mindent kitöltött e!", "Hiba!");
        }
    }
}
