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
    //create table chance (rid int not null IDENTITY(1,1) primary key,cardA nvarchar(2) not null,cardL nvarchar(2) not null,cardY nvarchar(2) not null,cardT nvarchar(2) not null)

    //create table usersdb (rid int not null IDENTITY(1,1) primary key,fname nvarchar(20)not null,passu nvarchar(15)not null)

    //create table formuser (rid int not null IDENTITY(1,1) primary key,fname nvarchar(20)not null,moneysh int(4) not null,cardA nvarchar(2) not null,cardL nvarchar(2) not null,cardY nvarchar(2) not null,cardT nvarchar(2) not null)

    public partial class Form1 : Form
    {
        public void ThrowError(Exception ex) => MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        private static Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            //HgraldToDb(resultarr());
            resultLast();
            btnHmlazot.Enabled = false;
            btnLastResult.Enabled = false;
            btnCreateForm.Enabled = false;   
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLastResult_Click(object sender, EventArgs e)
        {
            
            LastResult lr = new LastResult();
            lr.ShowDialog();
            
            btnHmlazot.Enabled = true;
        }
        public void resultLast()
        {
            string card1 = "", card2 = "", card3 = "", card4 = "";
            try
            {
                SqlConnection cnn = new SqlConnection("server=(local)\\SQLEXPRESS;database=Chance ;Integrated Security=SSPI;");
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM chance WHERE rid=(SELECT MAX(rid) FROM chance);";
                cnn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                
                while (sdr.Read())
                {
                    card1 = sdr[1].ToString();
                    card2 = sdr[2].ToString();
                    card3 = sdr[3].ToString();
                    card4 = sdr[4].ToString();  
                }
                cnn.Close();
                lblNumOfAle.Text = card1;
                lblNumOfLev.Text = card2;
                lblNumOfYalom.Text = card3;
                lblNumOfTiltan.Text = card4;
            }
            catch (Exception ex) { ThrowError(ex); }
        }
        private void btnStatistica_Click(object sender, EventArgs e)
        {
            
            CreateForm cr = new CreateForm();
            cr.ShowDialog();
        }

        private void btnHmlazot_Click(object sender, EventArgs e)
        {
            Recommendations R = new Recommendations();
            R.ShowDialog();

        }
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login L = new Login();
            L.ShowDialog();

            lblGuest.Text = staticClassForDb.GetGuest();
            if (lblGuest.Text != "")
            {
                btnCreateForm.Enabled = true;
                btnLastResult.Enabled = true;
                menuStrip1.Enabled = false;
                btnLogOuy.Visible = true;
            }       
        }
        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignUP su = new SignUP();
            su.ShowDialog();
        }

        private void lblGuest_Click(object sender, EventArgs e)
        {
            
        }
        private void btnLogOuy_Click(object sender, EventArgs e)
        {
            btnCreateForm.Enabled = false;
            btnLastResult.Enabled = false;
            lblGuest.Text = "";
            menuStrip1.Enabled = true;
            btnLogOuy.Visible = false;

        }
    }
}
