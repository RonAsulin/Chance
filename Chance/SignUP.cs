using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chance
{
    public partial class SignUP : Form
    {
        public SignUP()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            for(int i = 0; i < str.Length; i++)
            {
                if (str.Length >= 2)
                    if (str[0] >= 'A' && str[0] <= 'Z')
                        lblResultuser.Text = "Ok";
                    else lblResultuser.Text = "Try Another";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string str = textBox2.Text;
            for (int i = 0; i < str.Length; i++)
            {
                if (str.Length >= 6)
                        lblresultpass.Text = "Ok";
                else lblresultpass.Text = "Try Another";
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string userName=textBox1.Text,passuser=textBox2.Text;
            try
            {

                SqlConnection cnn = new SqlConnection("server=(local)\\SQLEXPRESS;database=Chance ;Integrated Security=SSPI;");
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = $@"INSERT INTO usersdb (fname,passu) values ('{userName}','{passuser}')";
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Sucsess");

            }
            catch (Exception ex) { ThrowError(ex); }
        }
        public void ThrowError(Exception ex) => MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
