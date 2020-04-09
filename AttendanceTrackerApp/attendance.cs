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
    public partial class attendance : Form
    {
        static List<string> logins = new List<string>();
        static List<string> passwords = new List<string>();
        static List<string> qr = new List<string>();
        static List<bool> clockedIn = new List<bool>();

        public attendance()
        {
            logins.Add("user1");
            passwords.Add("password1");
            clockedIn.Add(false);
            logins.Add("user2");
            passwords.Add("password2");
            clockedIn.Add(false);
            logins.Add("user3");
            passwords.Add("password3");
            clockedIn.Add(false);           
            InitializeComponent();
            notificationLabel.Text = "";

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

        private void clearInput()
        {
            userEntryID.Text = "";
            userEntryPass.Text = "";
        }

        private void pradetiDarbaButton_Click(object sender, EventArgs e)
        {
            if (logins.Contains(userEntryID.Text))
            {
                int index = logins.IndexOf(userEntryID.Text);
                if (userEntryPass.Text == passwords[index])
                {
                    if (!clockedIn[index])
                    {
                        clockedIn[index] = true;
                        notificationLabel.ForeColor = System.Drawing.Color.Green;
                        notificationLabel.Text = "Pradėjote darbą:  " + logins[index] + "\nLaikas: "  + DateTime.Now.ToString("HH:mm:ss");                
                        clearInput();
                    }
                    else
                    {
                        notificationLabel.Text = "Jau esate prisijungę!";
                    }
                }
                else
                {
                    notificationLabel.Text = "Wrong Password!";
                    userEntryPass.Text = "";
                }
            }
            else
            {
                notificationLabel.Text = "There's no such user!";
                clearInput();
            }
        }
       
        private void baigtiDarbaButton_Click(object sender, EventArgs e)
        {
            if (logins.Contains(userEntryID.Text))
            {
                int index = logins.IndexOf(userEntryID.Text);
                if (userEntryPass.Text == passwords[index])
                {
                    if (clockedIn[index])
                    {
                        clockedIn[index] = false;
                        notificationLabel.ForeColor = System.Drawing.Color.Red;
                        notificationLabel.Text = "Baigėte darbą: " + logins[index] + "\nLaikas: " + DateTime.Now.ToString("HH:mm:ss");
                        clearInput();
                    }
                    else
                    {
                        notificationLabel.Text = "Jau nesate prisijungę!";
                    }
                }
                else
                {
                    notificationLabel.Text = "Wrong Password!";
                    userEntryPass.Text = "";
                }
            }
            else
            {
                notificationLabel.Text = "There's no such user!";
                clearInput();
            }
        }

        private void notificationLabel_TextChange(object sender, EventArgs e)
        {
            if (notificationLabel.Text != "")
            {
                notificationTimer.Enabled = false;
                notificationTimer.Enabled = true;
            }
        }

        private void notificationTimer_Tick(object sender, EventArgs e)
        {
            notificationLabel.Text = "";
            notificationLabel.ForeColor = System.Drawing.Color.Black;
            notificationTimer.Enabled = false;
        }
    }
}

///