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
        public Form1()
        {
            InitializeComponent();

            kapcsolodas();

            tablakLetrehozasa();

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
    }
}
