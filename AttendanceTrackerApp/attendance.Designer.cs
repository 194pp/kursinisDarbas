namespace AttendanceTrackerApp
{
    partial class attendance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sysTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.userEntryID = new System.Windows.Forms.TextBox();
            this.pradetiDarbaButton = new System.Windows.Forms.Button();
            this.baigtiDarbaButton = new System.Windows.Forms.Button();
            this.userEntryPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registracijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationTimer = new System.Windows.Forms.Timer(this.components);
            this.notificationLabel = new System.Windows.Forms.Label();
            this.pavadinimas = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sysTime
            // 
            this.sysTime.AutoSize = true;
            this.sysTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sysTime.Location = new System.Drawing.Point(8, 363);
            this.sysTime.Name = "sysTime";
            this.sysTime.Size = new System.Drawing.Size(59, 20);
            this.sysTime.TabIndex = 0;
            this.sysTime.Text = "Laikas:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Darbuotojo ID:";
            // 
            // userEntryID
            // 
            this.userEntryID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userEntryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userEntryID.Location = new System.Drawing.Point(12, 96);
            this.userEntryID.Name = "userEntryID";
            this.userEntryID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userEntryID.Size = new System.Drawing.Size(257, 29);
            this.userEntryID.TabIndex = 1;
            // 
            // pradetiDarbaButton
            // 
            this.pradetiDarbaButton.BackColor = System.Drawing.Color.LawnGreen;
            this.pradetiDarbaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pradetiDarbaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pradetiDarbaButton.Location = new System.Drawing.Point(11, 260);
            this.pradetiDarbaButton.Name = "pradetiDarbaButton";
            this.pradetiDarbaButton.Size = new System.Drawing.Size(130, 100);
            this.pradetiDarbaButton.TabIndex = 3;
            this.pradetiDarbaButton.Text = "Pradėti darbą";
            this.pradetiDarbaButton.UseVisualStyleBackColor = false;
            this.pradetiDarbaButton.Click += new System.EventHandler(this.pradetiDarbaButton_Click);
            // 
            // baigtiDarbaButton
            // 
            this.baigtiDarbaButton.BackColor = System.Drawing.Color.Red;
            this.baigtiDarbaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.baigtiDarbaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baigtiDarbaButton.Location = new System.Drawing.Point(138, 260);
            this.baigtiDarbaButton.Name = "baigtiDarbaButton";
            this.baigtiDarbaButton.Size = new System.Drawing.Size(130, 100);
            this.baigtiDarbaButton.TabIndex = 4;
            this.baigtiDarbaButton.Text = "Baigti darbą";
            this.baigtiDarbaButton.UseVisualStyleBackColor = false;
            this.baigtiDarbaButton.Click += new System.EventHandler(this.baigtiDarbaButton_Click);
            // 
            // userEntryPass
            // 
            this.userEntryPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userEntryPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userEntryPass.Location = new System.Drawing.Point(12, 150);
            this.userEntryPass.Name = "userEntryPass";
            this.userEntryPass.PasswordChar = '*';
            this.userEntryPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userEntryPass.Size = new System.Drawing.Size(257, 29);
            this.userEntryPass.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Slaptažodis:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registracijaToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
            this.toolStripMenuItem1.Text = "Daugiau";
            // 
            // registracijaToolStripMenuItem
            // 
            this.registracijaToolStripMenuItem.Name = "registracijaToolStripMenuItem";
            this.registracijaToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.registracijaToolStripMenuItem.Text = "Registracija";
            // 
            // notificationTimer
            // 
            this.notificationTimer.Interval = 5000;
            this.notificationTimer.Tick += new System.EventHandler(this.notificationTimer_Tick);
            // 
            // notificationLabel
            // 
            this.notificationLabel.AutoSize = true;
            this.notificationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.notificationLabel.Location = new System.Drawing.Point(12, 196);
            this.notificationLabel.Name = "notificationLabel";
            this.notificationLabel.Size = new System.Drawing.Size(131, 18);
            this.notificationLabel.TabIndex = 8;
            this.notificationLabel.Text = "notificationLabel";
            this.notificationLabel.TextChanged += new System.EventHandler(this.notificationLabel_TextChange);
            // 
            // pavadinimas
            // 
            this.pavadinimas.AutoSize = true;
            this.pavadinimas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pavadinimas.Location = new System.Drawing.Point(7, 37);
            this.pavadinimas.Name = "pavadinimas";
            this.pavadinimas.Size = new System.Drawing.Size(263, 24);
            this.pavadinimas.TabIndex = 9;
            this.pavadinimas.Text = "Darbo laiko sekimo sistema";
            // 
            // attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(284, 389);
            this.Controls.Add(this.pavadinimas);
            this.Controls.Add(this.notificationLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userEntryPass);
            this.Controls.Add(this.baigtiDarbaButton);
            this.Controls.Add(this.pradetiDarbaButton);
            this.Controls.Add(this.userEntryID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sysTime);
            this.Controls.Add(this.menuStrip1);
            this.Name = "attendance";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sysTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userEntryID;
        private System.Windows.Forms.Button pradetiDarbaButton;
        private System.Windows.Forms.Button baigtiDarbaButton;
        private System.Windows.Forms.TextBox userEntryPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registracijaToolStripMenuItem;
        private System.Windows.Forms.Timer notificationTimer;
        private System.Windows.Forms.Label notificationLabel;
        private System.Windows.Forms.Label pavadinimas;
    }
}

