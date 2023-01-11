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
    public partial class BilForm : Form
    {
        private string[] cards = new string[4];
        public BilForm()
        {
            InitializeComponent();
            GetFormUser();
            resultLast();
        }
        public BilForm(string card1,string card2, string card3,string card4 )
        {
            InitializeComponent();
            GetFormUser();
            resultLast();
            cards[0] = card1;
            cards[1] = card2;
            cards[2] = card3;
            cards[3] = card4;
        }
        public void GetFormUser() 
        {
            int m=0;
            try
            {
                SqlConnection cnn = new SqlConnection("server=(local)\\SQLEXPRESS;database=Chance ;Integrated Security=SSPI;");
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = $"select * from formuser where fname='{staticClassForDb.fname}';";
                cnn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                int i = 1, j = 0;
                while (sdr.Read())
                {
                    הטפסים.Items.Add($"{i}: ₪:{sdr[2]} ♠:{sdr[3]} ♥:{sdr[4]} ♦:{sdr[5]} ♣:{sdr[6]} ");
                    i++;
                    m = (int)sdr[2];
                }
               
            }
            
            catch (Exception ex) { ThrowError(ex); }
            staticClassForDb.SetMoney(m);
        }
        public void ThrowError(Exception ex) => MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                lblAle.Text = card1;
                staticClassForDb.cardForEqual[0] = card1;
                lblLev.Text = card2;
                staticClassForDb.cardForEqual[1] = card2;
                lblYalom.Text = card3;
                staticClassForDb.cardForEqual[2] = card3;
                lblTiltan.Text = card4;
                staticClassForDb.cardForEqual[3] = card4;
            }
            catch (Exception ex) { ThrowError(ex); }
        }
        private void btnCheckWin_Click(object sender, EventArgs e)
        {
            AfterEqual();
        }
        private bool EqualRes()
        {
            string[] arr = staticClassForDb.GetcardForEqual();
            //string[] arr2 = staticClassForDb.GetcardForEqualUser();
            string[] arr2 = cards;
            int i = 0, j = 0;
            for (i = 0, j = 0; i < arr.Length && arr[i] == arr2[j]; i++,j++) ;
            if (arr.Length > i || arr2.Length > j)
                return false;
            return true;
        }
        private void AfterEqual()
        {
            if(EqualRes()==true)
            {
                int money=staticClassForDb.GetMoney();
                int res = 2000*money;

                lblResultWin.Text += " מזל טוב זכית בסכום";
                lblResultWin.Text += $" :{res} שח";
            }
            else
            {
                lblResultWin.Text = "לא זכית נסה שוב ";
            }
        }
    }

}

