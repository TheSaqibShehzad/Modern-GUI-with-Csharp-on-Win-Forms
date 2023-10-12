namespace MonitoringSystemUI
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.SideBarPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pnDashboard = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.NodeMenu = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.subNode1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.subNode2 = new System.Windows.Forms.Button();
            this.pnSummary = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.pnSettings = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pnAbout = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.pnLogout = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.topbarPanel = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SideButton = new System.Windows.Forms.PictureBox();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sideBarTransition = new System.Windows.Forms.Timer(this.components);
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.SideBarPanel.SuspendLayout();
            this.pnDashboard.SuspendLayout();
            this.menuContainer.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnSummary.SuspendLayout();
            this.pnSettings.SuspendLayout();
            this.pnAbout.SuspendLayout();
            this.pnLogout.SuspendLayout();
            this.topbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SideButton)).BeginInit();
            this.SuspendLayout();
            // 
            // SideBarPanel
            // 
            this.SideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.SideBarPanel.Controls.Add(this.pnDashboard);
            this.SideBarPanel.Controls.Add(this.menuContainer);
            this.SideBarPanel.Controls.Add(this.pnSummary);
            this.SideBarPanel.Controls.Add(this.pnSettings);
            this.SideBarPanel.Controls.Add(this.pnAbout);
            this.SideBarPanel.Controls.Add(this.pnLogout);
            this.SideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBarPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SideBarPanel.Location = new System.Drawing.Point(0, 30);
            this.SideBarPanel.Name = "SideBarPanel";
            this.SideBarPanel.Size = new System.Drawing.Size(197, 640);
            this.SideBarPanel.TabIndex = 0;
            this.SideBarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // pnDashboard
            // 
            this.pnDashboard.Controls.Add(this.button1);
            this.pnDashboard.Location = new System.Drawing.Point(3, 3);
            this.pnDashboard.Name = "pnDashboard";
            this.pnDashboard.Size = new System.Drawing.Size(197, 68);
            this.pnDashboard.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-10, -14);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(246, 101);
            this.button1.TabIndex = 4;
            this.button1.Text = "          Dashboard";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuContainer
            // 
            this.menuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.menuContainer.Controls.Add(this.panel6);
            this.menuContainer.Controls.Add(this.panel9);
            this.menuContainer.Controls.Add(this.panel5);
            this.menuContainer.Location = new System.Drawing.Point(3, 77);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(197, 67);
            this.menuContainer.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.NodeMenu);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(197, 67);
            this.panel6.TabIndex = 6;
            // 
            // NodeMenu
            // 
            this.NodeMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.NodeMenu.FlatAppearance.BorderSize = 0;
            this.NodeMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NodeMenu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NodeMenu.ForeColor = System.Drawing.Color.White;
            this.NodeMenu.Image = ((System.Drawing.Image)(resources.GetObject("NodeMenu.Image")));
            this.NodeMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NodeMenu.Location = new System.Drawing.Point(-13, -14);
            this.NodeMenu.Name = "NodeMenu";
            this.NodeMenu.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.NodeMenu.Size = new System.Drawing.Size(246, 92);
            this.NodeMenu.TabIndex = 4;
            this.NodeMenu.Text = "          Nodes";
            this.NodeMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NodeMenu.UseVisualStyleBackColor = false;
            this.NodeMenu.Click += new System.EventHandler(this.NodeMenu_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.subNode1);
            this.panel9.Location = new System.Drawing.Point(3, 76);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(197, 67);
            this.panel9.TabIndex = 9;
            // 
            // subNode1
            // 
            this.subNode1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.subNode1.FlatAppearance.BorderSize = 0;
            this.subNode1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subNode1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subNode1.ForeColor = System.Drawing.Color.White;
            this.subNode1.Image = ((System.Drawing.Image)(resources.GetObject("subNode1.Image")));
            this.subNode1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subNode1.Location = new System.Drawing.Point(-13, -14);
            this.subNode1.Name = "subNode1";
            this.subNode1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.subNode1.Size = new System.Drawing.Size(246, 92);
            this.subNode1.TabIndex = 4;
            this.subNode1.Text = "          Node 1";
            this.subNode1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subNode1.UseVisualStyleBackColor = false;
            this.subNode1.Click += new System.EventHandler(this.subNode1_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.subNode2);
            this.panel5.Location = new System.Drawing.Point(3, 149);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(197, 67);
            this.panel5.TabIndex = 8;
            // 
            // subNode2
            // 
            this.subNode2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.subNode2.FlatAppearance.BorderSize = 0;
            this.subNode2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subNode2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subNode2.ForeColor = System.Drawing.Color.White;
            this.subNode2.Image = ((System.Drawing.Image)(resources.GetObject("subNode2.Image")));
            this.subNode2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subNode2.Location = new System.Drawing.Point(-13, -14);
            this.subNode2.Name = "subNode2";
            this.subNode2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.subNode2.Size = new System.Drawing.Size(246, 92);
            this.subNode2.TabIndex = 4;
            this.subNode2.Text = "          Node 2";
            this.subNode2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subNode2.UseVisualStyleBackColor = false;
            this.subNode2.Click += new System.EventHandler(this.subNode2_Click);
            // 
            // pnSummary
            // 
            this.pnSummary.Controls.Add(this.button3);
            this.pnSummary.Location = new System.Drawing.Point(3, 150);
            this.pnSummary.Name = "pnSummary";
            this.pnSummary.Size = new System.Drawing.Size(197, 67);
            this.pnSummary.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-13, -14);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(246, 92);
            this.button3.TabIndex = 4;
            this.button3.Text = "          Summary";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pnSettings
            // 
            this.pnSettings.Controls.Add(this.button2);
            this.pnSettings.Location = new System.Drawing.Point(3, 223);
            this.pnSettings.Name = "pnSettings";
            this.pnSettings.Size = new System.Drawing.Size(197, 67);
            this.pnSettings.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-13, -14);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(246, 92);
            this.button2.TabIndex = 4;
            this.button2.Text = "          Settings";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pnAbout
            // 
            this.pnAbout.Controls.Add(this.button5);
            this.pnAbout.Location = new System.Drawing.Point(3, 296);
            this.pnAbout.Name = "pnAbout";
            this.pnAbout.Size = new System.Drawing.Size(197, 67);
            this.pnAbout.TabIndex = 8;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-13, -14);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(246, 92);
            this.button5.TabIndex = 4;
            this.button5.Text = "          About";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // pnLogout
            // 
            this.pnLogout.Controls.Add(this.button7);
            this.pnLogout.Location = new System.Drawing.Point(3, 369);
            this.pnLogout.Name = "pnLogout";
            this.pnLogout.Size = new System.Drawing.Size(197, 67);
            this.pnLogout.TabIndex = 7;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(-13, -14);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(246, 92);
            this.button7.TabIndex = 4;
            this.button7.Text = "          Logout";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // topbarPanel
            // 
            this.topbarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.topbarPanel.Controls.Add(this.pictureBox4);
            this.topbarPanel.Controls.Add(this.pictureBox3);
            this.topbarPanel.Controls.Add(this.pictureBox1);
            this.topbarPanel.Controls.Add(this.SideButton);
            this.topbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbarPanel.Location = new System.Drawing.Point(0, 0);
            this.topbarPanel.Name = "topbarPanel";
            this.topbarPanel.Size = new System.Drawing.Size(1100, 30);
            this.topbarPanel.TabIndex = 1;
            this.topbarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topbarPanel_MouseDown);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1080, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1027, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1054, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SideButton
            // 
            this.SideButton.Image = ((System.Drawing.Image)(resources.GetObject("SideButton.Image")));
            this.SideButton.Location = new System.Drawing.Point(23, 4);
            this.SideButton.Name = "SideButton";
            this.SideButton.Size = new System.Drawing.Size(23, 21);
            this.SideButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SideButton.TabIndex = 7;
            this.SideButton.TabStop = false;
            this.SideButton.Click += new System.EventHandler(this.SideButton_Click);
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // sideBarTransition
            // 
            this.sideBarTransition.Interval = 6;
            this.sideBarTransition.Tick += new System.EventHandler(this.sideBarTransition_Tick);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(197, 30);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(903, 640);
            this.panelChildForm.TabIndex = 2;
            // 
            // mainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1100, 670);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.SideBarPanel);
            this.Controls.Add(this.topbarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.SideBarPanel.ResumeLayout(false);
            this.pnDashboard.ResumeLayout(false);
            this.menuContainer.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.pnSummary.ResumeLayout(false);
            this.pnSettings.ResumeLayout(false);
            this.pnAbout.ResumeLayout(false);
            this.pnLogout.ResumeLayout(false);
            this.topbarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SideButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel SideBarPanel;
        private System.Windows.Forms.Panel topbarPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnDashboard;
        private System.Windows.Forms.PictureBox SideButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button NodeMenu;
        private System.Windows.Forms.Panel pnLogout;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.FlowLayoutPanel menuContainer;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button subNode1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button subNode2;
        private System.Windows.Forms.Panel pnSummary;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pnSettings;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnAbout;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer sideBarTransition;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panelChildForm;
    }
}

