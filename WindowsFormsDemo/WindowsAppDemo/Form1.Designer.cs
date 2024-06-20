namespace WindowsAppDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblName = new Label();
            lblTotalFees = new Label();
            chkC = new CheckBox();
            gbCourses = new GroupBox();
            chkDevOps = new CheckBox();
            chkMongoDB = new CheckBox();
            chkPHP = new CheckBox();
            chkDJango = new CheckBox();
            chkPython = new CheckBox();
            chkAWS = new CheckBox();
            chkOracle = new CheckBox();
            chkSpring = new CheckBox();
            chkAdvJava = new CheckBox();
            chkCoreJava = new CheckBox();
            chkReact = new CheckBox();
            chkAngular = new CheckBox();
            chkSQLServer = new CheckBox();
            chkASPDotNet = new CheckBox();
            chkCSharp = new CheckBox();
            chkAzure = new CheckBox();
            chkLinux = new CheckBox();
            chkUnix = new CheckBox();
            chkCPP = new CheckBox();
            txtName = new TextBox();
            txtTotalFees = new TextBox();
            gbTrack = new GroupBox();
            rdoSuperFast = new RadioButton();
            rdoFast = new RadioButton();
            rdoNormal = new RadioButton();
            txtAmtInWords = new TextBox();
            label2 = new Label();
            btnReset = new Button();
            btnClose = new Button();
            gbCourses.SuspendLayout();
            gbTrack.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Yellow;
            label1.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(539, -2);
            label1.Name = "label1";
            label1.Size = new Size(327, 42);
            label1.TabIndex = 0;
            label1.Text = "SUNARMS TECH";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Bookman Old Style", 11F);
            lblName.Location = new Point(12, 70);
            lblName.Name = "lblName";
            lblName.Size = new Size(74, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblTotalFees
            // 
            lblTotalFees.AutoSize = true;
            lblTotalFees.Font = new Font("Bookman Old Style", 11F);
            lblTotalFees.Location = new Point(374, 73);
            lblTotalFees.Name = "lblTotalFees";
            lblTotalFees.Size = new Size(122, 25);
            lblTotalFees.TabIndex = 2;
            lblTotalFees.Text = "Total Fees";
            // 
            // chkC
            // 
            chkC.AutoSize = true;
            chkC.Font = new Font("Bookman Old Style", 11F);
            chkC.Location = new Point(26, 25);
            chkC.Name = "chkC";
            chkC.Size = new Size(131, 29);
            chkC.TabIndex = 0;
            chkC.Tag = "1500";
            chkC.Text = "C (1500)";
            chkC.UseVisualStyleBackColor = true;
            chkC.CheckedChanged += chkBox_CheckedChanged;
            // 
            // gbCourses
            // 
            gbCourses.BackColor = Color.FromArgb(255, 255, 128);
            gbCourses.Controls.Add(chkDevOps);
            gbCourses.Controls.Add(chkMongoDB);
            gbCourses.Controls.Add(chkPHP);
            gbCourses.Controls.Add(chkDJango);
            gbCourses.Controls.Add(chkPython);
            gbCourses.Controls.Add(chkAWS);
            gbCourses.Controls.Add(chkOracle);
            gbCourses.Controls.Add(chkSpring);
            gbCourses.Controls.Add(chkAdvJava);
            gbCourses.Controls.Add(chkCoreJava);
            gbCourses.Controls.Add(chkReact);
            gbCourses.Controls.Add(chkAngular);
            gbCourses.Controls.Add(chkSQLServer);
            gbCourses.Controls.Add(chkASPDotNet);
            gbCourses.Controls.Add(chkCSharp);
            gbCourses.Controls.Add(chkAzure);
            gbCourses.Controls.Add(chkLinux);
            gbCourses.Controls.Add(chkUnix);
            gbCourses.Controls.Add(chkCPP);
            gbCourses.Controls.Add(chkC);
            gbCourses.Font = new Font("Bookman Old Style", 11F);
            gbCourses.Location = new Point(1, 113);
            gbCourses.Name = "gbCourses";
            gbCourses.Size = new Size(1442, 235);
            gbCourses.TabIndex = 4;
            gbCourses.TabStop = false;
            gbCourses.Text = "Courses Offered";
            // 
            // chkDevOps
            // 
            chkDevOps.AutoSize = true;
            chkDevOps.Font = new Font("Bookman Old Style", 11F);
            chkDevOps.Location = new Point(968, 181);
            chkDevOps.Name = "chkDevOps";
            chkDevOps.Size = new Size(200, 29);
            chkDevOps.TabIndex = 19;
            chkDevOps.Tag = "5000";
            chkDevOps.Text = "DevOps (5000)";
            chkDevOps.UseVisualStyleBackColor = true;
            chkDevOps.CheckedChanged += chkBox_CheckedChanged;
            // 
            // chkMongoDB
            // 
            chkMongoDB.AutoSize = true;
            chkMongoDB.Font = new Font("Bookman Old Style", 11F);
            chkMongoDB.Location = new Point(968, 142);
            chkMongoDB.Name = "chkMongoDB";
            chkMongoDB.Size = new Size(220, 29);
            chkMongoDB.TabIndex = 18;
            chkMongoDB.Tag = "2000";
            chkMongoDB.Text = "MongoDB (2000)";
            chkMongoDB.UseVisualStyleBackColor = true;
            chkMongoDB.CheckedChanged += chkBox_CheckedChanged;
            // 
            // chkPHP
            // 
            chkPHP.AutoSize = true;
            chkPHP.Font = new Font("Bookman Old Style", 11F);
            chkPHP.Location = new Point(968, 102);
            chkPHP.Name = "chkPHP";
            chkPHP.Size = new Size(161, 29);
            chkPHP.TabIndex = 17;
            chkPHP.Tag = "3000";
            chkPHP.Text = "PHP (3000)";
            chkPHP.UseVisualStyleBackColor = true;
            chkPHP.CheckedChanged += chkBox_CheckedChanged;
            // 
            // chkDJango
            // 
            chkDJango.AutoSize = true;
            chkDJango.Font = new Font("Bookman Old Style", 11F);
            chkDJango.Location = new Point(968, 67);
            chkDJango.Name = "chkDJango";
            chkDJango.Size = new Size(198, 29);
            chkDJango.TabIndex = 16;
            chkDJango.Tag = "4000";
            chkDJango.Text = "DJango (4000)";
            chkDJango.UseVisualStyleBackColor = true;
            chkDJango.CheckedChanged += chkBox_CheckedChanged;
            // 
            // chkPython
            // 
            chkPython.AutoSize = true;
            chkPython.Font = new Font("Bookman Old Style", 11F);
            chkPython.Location = new Point(968, 29);
            chkPython.Name = "chkPython";
            chkPython.Size = new Size(191, 29);
            chkPython.TabIndex = 15;
            chkPython.Tag = "4000";
            chkPython.Text = "Python (4000)";
            chkPython.UseVisualStyleBackColor = true;
            chkPython.CheckedChanged += chkBox_CheckedChanged;
            // 
            // chkAWS
            // 
            chkAWS.AutoSize = true;
            chkAWS.Font = new Font("Bookman Old Style", 11F);
            chkAWS.Location = new Point(617, 177);
            chkAWS.Name = "chkAWS";
            chkAWS.Size = new Size(166, 29);
            chkAWS.TabIndex = 14;
            chkAWS.Tag = "7500";
            chkAWS.Text = "AWS (7500)";
            chkAWS.UseVisualStyleBackColor = true;
            chkAWS.CheckedChanged += chkBox_CheckedChanged;
            // 
            // chkOracle
            // 
            chkOracle.AutoSize = true;
            chkOracle.Font = new Font("Bookman Old Style", 11F);
            chkOracle.Location = new Point(617, 142);
            chkOracle.Name = "chkOracle";
            chkOracle.Size = new Size(186, 29);
            chkOracle.TabIndex = 13;
            chkOracle.Tag = "2000";
            chkOracle.Text = "Oracle (2000)";
            chkOracle.UseVisualStyleBackColor = true;
            chkOracle.CheckedChanged += chkBox_CheckedChanged;
            // 
            // chkSpring
            // 
            chkSpring.AutoSize = true;
            chkSpring.Font = new Font("Bookman Old Style", 11F);
            chkSpring.Location = new Point(617, 103);
            chkSpring.Name = "chkSpring";
            chkSpring.Size = new Size(188, 29);
            chkSpring.TabIndex = 12;
            chkSpring.Tag = "3500";
            chkSpring.Text = "Spring (3500)";
            chkSpring.UseVisualStyleBackColor = true;
            chkSpring.CheckedChanged += chkBox_CheckedChanged;
            // 
            // chkAdvJava
            // 
            chkAdvJava.AutoSize = true;
            chkAdvJava.Font = new Font("Bookman Old Style", 11F);
            chkAdvJava.Location = new Point(617, 67);
            chkAdvJava.Name = "chkAdvJava";
            chkAdvJava.Size = new Size(221, 29);
            chkAdvJava.TabIndex = 11;
            chkAdvJava.Tag = "4500";
            chkAdvJava.Text = "Adv. Java (4500)";
            chkAdvJava.UseVisualStyleBackColor = true;
            chkAdvJava.CheckedChanged += chkBox_CheckedChanged;
            // 
            // chkCoreJava
            // 
            chkCoreJava.AutoSize = true;
            chkCoreJava.Font = new Font("Bookman Old Style", 11F);
            chkCoreJava.Location = new Point(617, 27);
            chkCoreJava.Name = "chkCoreJava";
            chkCoreJava.Size = new Size(223, 29);
            chkCoreJava.TabIndex = 10;
            chkCoreJava.Tag = "3500";
            chkCoreJava.Text = "Core Java (3500)";
            chkCoreJava.UseVisualStyleBackColor = true;
            chkCoreJava.CheckedChanged += chkBox_CheckedChanged;
            // 
            // chkReact
            // 
            chkReact.AutoSize = true;
            chkReact.Font = new Font("Bookman Old Style", 11F);
            chkReact.Location = new Point(310, 181);
            chkReact.Name = "chkReact";
            chkReact.Size = new Size(175, 29);
            chkReact.TabIndex = 9;
            chkReact.Tag = "4000";
            chkReact.Text = "React (4000)";
            chkReact.UseVisualStyleBackColor = true;
            chkReact.CheckedChanged += chkBox_CheckedChanged;
            // 
            // chkAngular
            // 
            chkAngular.AutoSize = true;
            chkAngular.Font = new Font("Bookman Old Style", 11F);
            chkAngular.Location = new Point(310, 146);
            chkAngular.Name = "chkAngular";
            chkAngular.Size = new Size(202, 29);
            chkAngular.TabIndex = 8;
            chkAngular.Tag = "4000";
            chkAngular.Text = "Angular (4000)";
            chkAngular.UseVisualStyleBackColor = true;
            chkAngular.CheckedChanged += chkBox_CheckedChanged;
            // 
            // chkSQLServer
            // 
            chkSQLServer.AutoSize = true;
            chkSQLServer.Font = new Font("Bookman Old Style", 11F);
            chkSQLServer.Location = new Point(310, 103);
            chkSQLServer.Name = "chkSQLServer";
            chkSQLServer.Size = new Size(239, 29);
            chkSQLServer.TabIndex = 7;
            chkSQLServer.Tag = "2000";
            chkSQLServer.Text = "SQL Server (2000)";
            chkSQLServer.UseVisualStyleBackColor = true;
            chkSQLServer.CheckedChanged += chkBox_CheckedChanged;
            // 
            // chkASPDotNet
            // 
            chkASPDotNet.AutoSize = true;
            chkASPDotNet.Font = new Font("Bookman Old Style", 11F);
            chkASPDotNet.Location = new Point(310, 64);
            chkASPDotNet.Name = "chkASPDotNet";
            chkASPDotNet.Size = new Size(202, 29);
            chkASPDotNet.TabIndex = 6;
            chkASPDotNet.Tag = "4000";
            chkASPDotNet.Text = "ASP.Net (4000)";
            chkASPDotNet.UseVisualStyleBackColor = true;
            chkASPDotNet.CheckedChanged += chkBox_CheckedChanged;
            // 
            // chkCSharp
            // 
            chkCSharp.AutoSize = true;
            chkCSharp.Font = new Font("Bookman Old Style", 11F);
            chkCSharp.Location = new Point(310, 25);
            chkCSharp.Name = "chkCSharp";
            chkCSharp.Size = new Size(146, 29);
            chkCSharp.TabIndex = 5;
            chkCSharp.Tag = "3500";
            chkCSharp.Text = "C# (3500)";
            chkCSharp.UseVisualStyleBackColor = true;
            chkCSharp.CheckedChanged += chkBox_CheckedChanged;
            // 
            // chkAzure
            // 
            chkAzure.AutoSize = true;
            chkAzure.Font = new Font("Bookman Old Style", 11F);
            chkAzure.Location = new Point(26, 181);
            chkAzure.Name = "chkAzure";
            chkAzure.Size = new Size(178, 29);
            chkAzure.TabIndex = 4;
            chkAzure.Tag = "6000";
            chkAzure.Text = "Azure (6000)";
            chkAzure.UseVisualStyleBackColor = true;
            chkAzure.CheckedChanged += chkBox_CheckedChanged;
            // 
            // chkLinux
            // 
            chkLinux.AutoSize = true;
            chkLinux.Font = new Font("Bookman Old Style", 11F);
            chkLinux.Location = new Point(26, 142);
            chkLinux.Name = "chkLinux";
            chkLinux.Size = new Size(177, 29);
            chkLinux.TabIndex = 3;
            chkLinux.Tag = "4000";
            chkLinux.Text = "Linux (4000)";
            chkLinux.UseVisualStyleBackColor = true;
            chkLinux.CheckedChanged += chkBox_CheckedChanged;
            // 
            // chkUnix
            // 
            chkUnix.AutoSize = true;
            chkUnix.Font = new Font("Bookman Old Style", 11F);
            chkUnix.Location = new Point(26, 103);
            chkUnix.Name = "chkUnix";
            chkUnix.Size = new Size(166, 29);
            chkUnix.TabIndex = 2;
            chkUnix.Tag = "2000";
            chkUnix.Text = "Unix (2000)";
            chkUnix.UseVisualStyleBackColor = true;
            chkUnix.CheckedChanged += chkBox_CheckedChanged;
            // 
            // chkCPP
            // 
            chkCPP.AutoSize = true;
            chkCPP.Font = new Font("Bookman Old Style", 11F);
            chkCPP.Location = new Point(26, 64);
            chkCPP.Name = "chkCPP";
            chkCPP.Size = new Size(157, 29);
            chkCPP.TabIndex = 1;
            chkCPP.Tag = "2500";
            chkCPP.Text = "C++ (2500)";
            chkCPP.UseVisualStyleBackColor = true;
            chkCPP.CheckedChanged += chkBox_CheckedChanged;
            // 
            // txtName
            // 
            txtName.Font = new Font("Bookman Old Style", 11F);
            txtName.Location = new Point(101, 64);
            txtName.Name = "txtName";
            txtName.Size = new Size(267, 33);
            txtName.TabIndex = 0;
            // 
            // txtTotalFees
            // 
            txtTotalFees.Font = new Font("Bookman Old Style", 11F);
            txtTotalFees.ForeColor = Color.Green;
            txtTotalFees.Location = new Point(502, 70);
            txtTotalFees.Name = "txtTotalFees";
            txtTotalFees.ReadOnly = true;
            txtTotalFees.Size = new Size(216, 33);
            txtTotalFees.TabIndex = 6;
            txtTotalFees.Tag = "0";
            txtTotalFees.Text = "0";
            txtTotalFees.TextAlign = HorizontalAlignment.Right;
            // 
            // gbTrack
            // 
            gbTrack.BackColor = Color.FromArgb(255, 255, 128);
            gbTrack.Controls.Add(rdoSuperFast);
            gbTrack.Controls.Add(rdoFast);
            gbTrack.Controls.Add(rdoNormal);
            gbTrack.Location = new Point(1, 373);
            gbTrack.Name = "gbTrack";
            gbTrack.Size = new Size(1442, 76);
            gbTrack.TabIndex = 7;
            gbTrack.TabStop = false;
            gbTrack.Text = "Track";
            // 
            // rdoSuperFast
            // 
            rdoSuperFast.AutoSize = true;
            rdoSuperFast.Location = new Point(1032, 24);
            rdoSuperFast.Name = "rdoSuperFast";
            rdoSuperFast.Size = new Size(164, 29);
            rdoSuperFast.TabIndex = 2;
            rdoSuperFast.TabStop = true;
            rdoSuperFast.Tag = "200";
            rdoSuperFast.Text = "Super Fast (200)";
            rdoSuperFast.UseVisualStyleBackColor = true;
            rdoSuperFast.CheckedChanged += rb_CheckedChanged;
            // 
            // rdoFast
            // 
            rdoFast.AutoSize = true;
            rdoFast.Location = new Point(538, 24);
            rdoFast.Name = "rdoFast";
            rdoFast.Size = new Size(113, 29);
            rdoFast.TabIndex = 1;
            rdoFast.TabStop = true;
            rdoFast.Tag = "100";
            rdoFast.Text = "Fast (100)";
            rdoFast.UseVisualStyleBackColor = true;
            rdoFast.CheckedChanged += rb_CheckedChanged;
            // 
            // rdoNormal
            // 
            rdoNormal.AutoSize = true;
            rdoNormal.Checked = true;
            rdoNormal.Location = new Point(3, 24);
            rdoNormal.Name = "rdoNormal";
            rdoNormal.Size = new Size(96, 29);
            rdoNormal.TabIndex = 0;
            rdoNormal.TabStop = true;
            rdoNormal.Tag = "0";
            rdoNormal.Text = "Normal";
            rdoNormal.UseVisualStyleBackColor = true;
            rdoNormal.CheckedChanged += rb_CheckedChanged;
            // 
            // txtAmtInWords
            // 
            txtAmtInWords.Font = new Font("Bookman Old Style", 11F);
            txtAmtInWords.ForeColor = Color.Green;
            txtAmtInWords.Location = new Point(913, 67);
            txtAmtInWords.Name = "txtAmtInWords";
            txtAmtInWords.ReadOnly = true;
            txtAmtInWords.Size = new Size(520, 33);
            txtAmtInWords.TabIndex = 9;
            txtAmtInWords.Tag = "0";
            txtAmtInWords.Text = "Rs.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 11F);
            label2.Location = new Point(752, 70);
            label2.Name = "label2";
            label2.Size = new Size(166, 25);
            label2.TabIndex = 8;
            label2.Text = "Fees In Words";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(128, 128, 255);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Location = new Point(842, 481);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(240, 66);
            btnReset.TabIndex = 10;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(128, 128, 255);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(1193, 481);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(240, 66);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1455, 579);
            Controls.Add(btnClose);
            Controls.Add(btnReset);
            Controls.Add(txtAmtInWords);
            Controls.Add(label2);
            Controls.Add(gbTrack);
            Controls.Add(label1);
            Controls.Add(txtTotalFees);
            Controls.Add(txtName);
            Controls.Add(gbCourses);
            Controls.Add(lblTotalFees);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Fees Calculator";
            gbCourses.ResumeLayout(false);
            gbCourses.PerformLayout();
            gbTrack.ResumeLayout(false);
            gbTrack.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblName;
        private Label lblTotalFees;
        private CheckBox chkC;
        private GroupBox gbCourses;
        private CheckBox chkAngular;
        private CheckBox chkSQLServer;
        private CheckBox chkASPDotNet;
        private CheckBox chkCSharp;
        private CheckBox chkAzure;
        private CheckBox chkLinux;
        private CheckBox chkUnix;
        private CheckBox chkCPP;
        private CheckBox chkDevOps;
        private CheckBox chkMongoDB;
        private CheckBox chkPHP;
        private CheckBox chkDJango;
        private CheckBox chkPython;
        private CheckBox chkAWS;
        private CheckBox chkOracle;
        private CheckBox chkSpring;
        private CheckBox chkAdvJava;
        private CheckBox chkCoreJava;
        private CheckBox chkReact;
        private TextBox txtName;
        private TextBox txtTotalFees;
        private GroupBox gbTrack;
        private RadioButton rdoSuperFast;
        private RadioButton rdoFast;
        private RadioButton rdoNormal;
        private TextBox txtAmtInWords;
        private Label label2;
        private Button btnReset;
        private Button btnClose;
    }
}
