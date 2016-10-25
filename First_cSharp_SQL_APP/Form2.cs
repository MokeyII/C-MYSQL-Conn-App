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
    public partial class Type_txt : Form
    {
        public Type_txt()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "datasource=127.0.0.1;port=3306;username=root;password=12345;database=bans";
            string Query = "insert into bans (GUID, BanTime, Reason, Proof,Bantype) Values('" + this.GUID_txt.Text + "','" + this.Ban_txt.Text + "','" + this.Reason_txt.Text + "','" + this.Proof_txt.Text + "','" + this.BanT_txt.Text + "') ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Ban Submitted and Applied!");
                while (myReader.Read())
                {
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void GUID_txt_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
