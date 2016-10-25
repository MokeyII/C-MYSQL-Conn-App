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
            GUID_txt.MaxLength = 32;
            BanT_txt.MaxLength = 4;
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
            if (BanT_txt.Text.Length < 4)
            {
                MessageBox.Show("Please enter ''GUID'' for ban type");
                return;
            }
            if (GUID_txt.Text.Length < 32)
            {
                MessageBox.Show("Invalid GUID");
            }
            if (Ban_txt.Text.Length < 2)
            {
                MessageBox.Show("Please enter ''-1'' under ban time to ensure a permanant ban");
                return;
            }
            if (Reason_txt.Text.Length < 10)
            {
                MessageBox.Show("Please Enter a Valid Reason, Ensure you add your Appeal Process to the reason. I.E. ''Hacking | Appeal your ban @ www.yoursitehere.com''");
                return;
            }
            if (Proof_txt.Text.Length < 10)
            {
                MessageBox.Show("Please Enter Valid Proof, I.E. Script Logs, Youtube Link, Sound File Link, etc...");
                return;
            }
            else
                try
                {
                    string str1 = "Banning this Player may result in the player NOT being able to play on many servers!@@If Bans are falsified, your user and all bans applied by you are subject to be removed from the database which will result in all bans being removed from any server using this tool.@@Are you sure you want to do this?";
                    str1 = str1.Replace("@", " " + System.Environment.NewLine);
                    var confirmResult = MessageBox.Show(str1, "CONFIRM BAN!!", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Ban Submitted and Applied!");
                        while (myReader.Read())
                        {

                        }
                        conDataBase.Close();
                    }
                        else
                        {
                        return;
                        }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

        }

        private void GUID_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DLbans_txt_Click(object sender, EventArgs e)
        {

            StringBuilder sb = new StringBuilder();

            try
            {
                string myConnection = "datasource=127.0.0.1;port=3306;username=root;password=12345";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand SelectCommand = new MySqlCommand("select * from bans.bans order by BanType asc", myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

            
                              
                while (myReader.Read())
                {
                    string GuidStr = myReader["GUID"].ToString();
                    string BanTimeStr = myReader["BanTime"].ToString();
                    string ReasonjStr = myReader["Reason"].ToString();

                    sb.Append(GuidStr);
                    sb.Append(" ");
                    sb.Append(BanTimeStr);
                    sb.Append(" ");
                    sb.Append(ReasonjStr);
                    sb.AppendLine();
                }


                myReader.Close();
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            string OutputFileText = sb.ToString();

        }

        private void BanT_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
