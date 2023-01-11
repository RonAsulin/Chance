using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chance
{
    public partial class LastResult : Form
    {
        public static Random rand = new Random();
        public void ThrowError(Exception ex) => MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        public LastResult()
        {
            InitializeComponent();
            LastResult5();     
        }
        public void LastResult5()
        {
            try
            {
                SqlConnection cnn = new SqlConnection("server=(local)\\SQLEXPRESS;database=Chance ;Integrated Security=SSPI;");
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = $"select top 4 * from chance order by rid desc;";
                cnn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                int i = 0, j = 0;
                while (sdr.Read())
                {
                    staticClassForDb.cards[i, j] = sdr[0].ToString();
                    j++;
                    staticClassForDb.cards[i, j] = sdr[1].ToString();
                    j++;
                    staticClassForDb.cards[i, j] = sdr[2].ToString();
                    j++;
                    staticClassForDb.cards[i, j] = sdr[3].ToString();
                    j++;
                    staticClassForDb.cards[i, j] = sdr[4].ToString();
                    j++;
                    if (j > 4)
                    {
                        j = 0;
                        i++;
                    }

                }
                cnn.Close();

                lblC1L1.Text = staticClassForDb.cards[0, 1];
                lblC2L1.Text = staticClassForDb.cards[0, 2];
                lblC3L1.Text = staticClassForDb.cards[0, 3];
                lblC4L1.Text = staticClassForDb.cards[0, 4];

                lblC1L2.Text = staticClassForDb.cards[1, 1];
                lblC2L2.Text = staticClassForDb.cards[1, 2];
                lblC3L2.Text = staticClassForDb.cards[1, 3];
                lblC4L2.Text = staticClassForDb.cards[1, 4];

                lblC1L3.Text = staticClassForDb.cards[2, 1];
                lblC2L3.Text = staticClassForDb.cards[2, 2];
                lblC3L3.Text = staticClassForDb.cards[2, 3];
                lblC4L3.Text = staticClassForDb.cards[2, 4];

                lblC1L4.Text = staticClassForDb.cards[3, 1];
                lblC2L4.Text = staticClassForDb.cards[3, 2];
                lblC3L4.Text = staticClassForDb.cards[3, 3];
                lblC4L4.Text = staticClassForDb.cards[3, 4];
            }                  
            catch (Exception ex) { ThrowError(ex); }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
