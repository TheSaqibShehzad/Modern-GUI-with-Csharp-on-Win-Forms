using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MonitoringSystemUI
{
    public partial class mainForm : Form
    {
        private Form activeForm;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int mLeftRect,
            int mTopRect,
            int mRightRect,
            int mBottomRect,
            int mWidthEllise,
            int mHeightEllipse
            
        );
        public void show1()
        {
            Visible = true;
            openCildForm(new node1());
        }
        
        public mainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0,Width,Height,50,50));
        }

        public void openCildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelChildForm.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        bool menuExpand = false;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Extras.Drag.dragPage(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openCildForm(new LogoTitleForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openCildForm(new LogoTitleForm());
        }


     

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false) {
                menuContainer.Height += 25;
                if(menuContainer.Height >= 210)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
                
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 67)
                {
                    menuTransition.Stop();
                    menuExpand = false;

                }
            }
        }

   

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NodeMenu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();

        }

        bool sideBarExpand = true;
        private void sideBarTransition_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand == true)
            {
                SideBarPanel.Width -= 10;
                if(SideBarPanel.Width <= 60)
                {
                    sideBarExpand = false;
                    sideBarTransition.Stop();

                    pnDashboard.Width = SideBarPanel.Width;
                    pnAbout.Width = SideBarPanel.Width;
                    pnLogout.Width = SideBarPanel.Width;
                    pnSummary.Width = SideBarPanel.Width;
                    pnSettings.Width = SideBarPanel.Width;
                    menuContainer.Width = SideBarPanel.Width;

                }
            }
            else
            {
                SideBarPanel.Width += 10;
                if (SideBarPanel.Width >= 197)
                {
                    sideBarExpand = true;
                    sideBarTransition.Stop();

                    pnDashboard.Width = SideBarPanel.Width;
                    pnAbout.Width = SideBarPanel.Width;
                    pnLogout.Width = SideBarPanel.Width;
                    pnSummary.Width = SideBarPanel.Width;
                    pnSettings.Width = SideBarPanel.Width;
                    menuContainer.Width = SideBarPanel.Width;


                }
            }
        }

        private void SideButton_Click(object sender, EventArgs e)
        {
            sideBarTransition.Start();
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void subNode1_Click(object sender, EventArgs e)
        {
            openCildForm(new node1());
        }

       

        private void subNode2_Click(object sender, EventArgs e)
        {
            openCildForm(new node2());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openCildForm(new summaryForm());

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;

        }

        private void topbarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Extras.Drag.dragPage(this);
        }
    }
}
