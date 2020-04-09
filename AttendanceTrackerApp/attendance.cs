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
        static List<string> logTimeStart = new List<string>();
        static List<string> logTimeEnd = new List<string>();
        static List<int> indexOfTimedUser = new List<int>();

        public attendance()
        {
            logins.Add("user1");
            passwords.Add("pass1");
            clockedIn.Add(false);
            logins.Add("user2");
            passwords.Add("pass2");
            clockedIn.Add(false);
            logins.Add("user3");
            passwords.Add("pass3");
            clockedIn.Add(false);           
            InitializeComponent();
            notificationLabel.Text = "";
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
                        logTimeStart.Add(DateTime.Now.ToString("HH:mm:ss"));
                        notificationLabel.Text = "Pradėjote darbą:  " + logins[index] + "\nLaikas: "  + DateTime.Now.ToString("HH:mm:ss");
                        indexOfTimedUser.Add(index);                       
                        clearInput();
                    }
                    else
                    {
                        notificationLabel.Text = "Jau esate prisijungę!";
                    }
                }
                else
                {
                    notificationLabel.Text = "Blogas slaptažodis!";
                    userEntryPass.Text = "";
                }
            }
            else
            {
                notificationLabel.Text = "Tokio vartotojo nėra!";
                clearInput();
            }
        }

        private int findingLatestClockIn (List<int> indexOfTimedUser , int index)
        {
            int i = 0;
            int returnvalue = -1;
            while (i < indexOfTimedUser.Count)
            {
                if(index == indexOfTimedUser[i])
                {
                    returnvalue = i;
                }
                i++;
            }
            return returnvalue;
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
                        int indexOfLatestStart = findingLatestClockIn(indexOfTimedUser, index);
                        string startTime = logTimeStart[indexOfTimedUser[indexOfLatestStart]];
                        DateTime start;
                        DateTime.TryParse(startTime, out start);
                        TimeSpan diff = start - DateTime.Now;
                        
                        notificationLabel.Text = "Baigėte darbą: " + logins[index] + "\nLaikas: " + DateTime.Now.ToString("HH:mm:ss") + "\nDirbote: " + diff.ToString(@"hh\:mm\:ss");
                        clearInput();
                    }
                    else
                    {
                        notificationLabel.Text = "Nesate prisijungę!";
                    }
                }
                else
                {
                    notificationLabel.Text = "Blogas slaptažodis!";
                    userEntryPass.Text = "";
                }
            }
            else
            {
                notificationLabel.Text = "Tokio vartotojo nėra!";
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