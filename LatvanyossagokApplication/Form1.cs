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
                MessageBox.Show("Sikertelen kapcsolódás az adatbázishoz!");
            }
        }

        void tablakLetrehozasa()
        {

        }
    }
}
