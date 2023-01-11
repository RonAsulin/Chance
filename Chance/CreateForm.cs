using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Chance
{
    public partial class CreateForm : Form
    {

        public CreateForm()
        {
            InitializeComponent();
        }
        public void ThrowError(Exception ex) => MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        private void btnCheck_Click(object sender, EventArgs e)
        {
            foreach (RadioButton rdo in gboxMoney.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    lblmoney.Text = rdo.Text;
                }
            }
            foreach (RadioButton rdo in groupBoxAle.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    lblresultA.Text += rdo.Text;
                }
            }
            foreach (RadioButton rdo in groupBoxLev.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    lblresultL.Text += rdo.Text;
                }
            }
            foreach (RadioButton rdo in groupBoxYalom.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    lblresultY.Text += rdo.Text;
                }
            }
            foreach (RadioButton rdo in groupBoxTiltan.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    lblresultT.Text += rdo.Text;
                }
            }
            btnCheck.Enabled = false;   
        }
        private void btnrestore_Click(object sender, EventArgs e)
        {
            lblresultA.Text = "";
            lblresultL.Text = "";
            lblresultY.Text = "";
            lblresultT.Text = "";
            lblmoney.Text = "";
            btnCheck.Enabled = true;
            btnsend.Enabled = true;
           
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            string name = staticClassForDb.GetName();
            string card1 = "", card2 = "", card3 = "", card4 = "";
            try
            {

                SqlConnection cnn = new SqlConnection("server=(local)\\SQLEXPRESS;database=Chance ;Integrated Security=SSPI;");
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = $@"INSERT INTO formuser (fname,moneysh,cardA,cardL,cardY,cardT) values ('{name}','{lblmoney.Text}','{lblresultA.Text}','{lblresultL.Text}','{lblresultY.Text}','{lblresultT.Text}')";
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Good Luck!!");

            }
            catch (Exception ex) { ThrowError(ex); }
            staticClassForDb.HgraldToDb(staticClassForDb.resultarr());

            card1 = lblresultA.Text;
            staticClassForDb.cardForEqualUser[0] = card1;
            card2=lblresultL.Text;
            staticClassForDb.cardForEqualUser[1] = card2;
            card3=lblresultY.Text;
            staticClassForDb.cardForEqualUser[2] = card3;
            card4=lblresultT.Text;
            staticClassForDb.cardForEqualUser[3] = card4;
            btnsend.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //BilForm bf = new BilForm(lblresultA.Text,lblresultL.Text,lblresultY.Text,lblresultT.Text);
            BilForm bf = new BilForm();
            bf.ShowDialog();
            btnsend.Enabled = true;
            
        }
    }
}



