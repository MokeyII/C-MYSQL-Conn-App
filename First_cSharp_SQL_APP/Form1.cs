using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace First_cSharp_SQL_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            password_txt.PasswordChar = '•';
            password_txt.MaxLength = 16;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=127.0.0.1;port=3306;username=root;password=12345";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand SelectCommand = new MySqlCommand("select * from bans.admins where Username = '" + this.username_txt.Text + "'and Password= '" + this.password_txt.Text + "' ;", myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    MessageBox.Show("Username and Password is correct!");
                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate Username and Password!");
                }
                else
                    MessageBox.Show("Incorrect Username or Password!");
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
