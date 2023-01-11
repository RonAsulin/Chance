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
    public partial class Recommendations : Form
    {private static Random random = new Random();
        public void ThrowError(Exception ex) => MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        public Recommendations()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hmlaza();
        }
        public void hmlaza()
        {
            string[] arr = Hgrala();
            lblA1.Text = arr[0];
            lblL1.Text = arr[1];
            lblT1.Text = arr[2];
            lblY1.Text = arr[3];
        }
        public string[] Hgrala()
        {
            string[,] arr = staticClassForDb.Getarr();
            string[] options = { arr[random.Next(0,4), random.Next(1, 5)], arr[random.Next(0, 4), random.Next(1, 5)], arr[random.Next(0, 4), random.Next(1, 5)], arr[random.Next(0, 4), random.Next(1, 5)] };
            return options;
        }
        public void Hgrala2()
        {
            string[,] arr = staticClassForDb.Getarr();
            string[] options = { arr[random.Next(0, 4), random.Next(1, 5)], arr[random.Next(0, 4), random.Next(1, 5)], arr[random.Next(0, 4), random.Next(1, 5)],""};
            string[]o = new string[options.Length];
            foreach (string s in options)
            {
                o[random.Next(0,4)] = s;
            
            }
            lbl2A.Text = o[0];
            lbl2L.Text = o[1];
            lbl2T.Text = o[2];
            lbl2Y.Text = o[3];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hgrala2();
        }
    }
}
