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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Chance
{
    public partial class Login : Form
    {
        public string userName { get; set; }
        public string password { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection cnn = new SqlConnection("server=(local)\\SQLEXPRESS;database=Chance ;Integrated Security=SSPI;");
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = $"select * from usersdb where fname='{txtBoxNameUsers.Text}' and passu='{txtBoxPass.Text}';";
                cnn.Open();
                int n = Convert.ToInt32(cmd.ExecuteScalar());
                cnn.Close();
                if (n > 0)
                {
                    userName = txtBoxNameUsers.Text;
                    password = txtBoxPass.Text;
                    
                    Close();
                    MessageBox.Show($"Hello {userName}");
                }
                else
                    MessageBox.Show("Wrong user or email");
               
                staticClassForDb.SetGuest(txtBoxNameUsers.Text);
                
                staticClassForDb.SetName(userName);

            }
            catch (Exception ex) { ThrowError(ex); }
            
        }
        public void ThrowError(Exception ex) => MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
