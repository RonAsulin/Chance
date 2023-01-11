using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chance
{
    static public class staticClassForDb
    {
        private static Random random = new Random();

        public static  string[,] cards = new string[4, 5];
        public static string fname;
        public static string password;
        public static string Guest;
        public static int money;
        public static string[] cardForEqual = new string[4];
        public static string[] cardForEqualUser = new string[4];
       // public static string[,] cardsFormUser = new string[3, 6];
        public static string[,] Getarr() => cards;
        //public static string[,] GetcardsFormUser() => cardsFormUser;
        public static string GetName() =>fname;
        public static void SetName(string name)=>fname = name;
        public static string GetPassword() =>password;
        public static string GetGuest()=>Guest;
        public static void SetGuest(string G) => Guest = G;
        public static int GetMoney() =>money;
        public static void SetMoney(int Money) =>money = Money;
        public static string[] GetcardForEqual() => cardForEqual;
        public static string[] GetcardForEqualUser() => cardForEqualUser;

        public static void HgraldToDb(string[] arr)
        {
            try
            {

                SqlConnection cnn = new SqlConnection("server=(local)\\SQLEXPRESS;database=Chance ;Integrated Security=SSPI;");
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = $@"INSERT INTO chance (cardA,cardL,cardY,cardT) values ('{arr[0]}','{arr[1]}','{arr[2]}','{arr[3]}')";
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public static string[] resultarr()
        {
            string[] arr = new string[4];
            for (int i = 0; i <= 3; i++)
                arr[i] = Hgrala();
            return arr;
        }
        public static string Hgrala()
        {
            string[] options = { "7", "8", "9", "10", "J", "Q", "K", "A" };
            return options[random.Next(options.Length)];
        }


    }
}
