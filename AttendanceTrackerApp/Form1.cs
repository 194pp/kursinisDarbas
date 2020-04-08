using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceTrackerApp
{
    public partial class Form1 : Form
    {
        static List<string> logins = new List<string>();
        static List<string> passwords = new List<string>();
        static List<string> qr = new List<string>();
        
        


        //static string 

        public Form1()
        {
            logins.Add("user1");
            passwords.Add("password1");
            logins.Add("user2");
            passwords.Add("password2");
            logins.Add("user3");
            passwords.Add("password3");

            InitializeComponent();
        }

        private void sysTime_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sysTime.Text = "Laikas: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void registracijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var regPopup = new Form();
            regPopup.Show(this);
        }

        private void pradetiDarbaButton_Click(object sender, EventArgs e)
        {
            if (logins.Contains(userEntryID.Text))
            {

            }
            else
            {
                // No user
            }
        }

        private void baigtiDarbaButton_Click(object sender, EventArgs e)
        {

        }
    }
}
