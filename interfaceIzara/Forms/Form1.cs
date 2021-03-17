using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaceIzara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
         
            panel.Height = buttonParent.Height;
            panel.Top = buttonParent.Top;
            buttonParrainage.Visible = false;
            buttonConnexion.Visible = true;
           buttonInscription.Visible = false;
            buttonCandidature.Visible = false;
            userControlMenu1.BringToFront();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void customizeDesign()
        {   // équivalent de mon menu qui n'a qu'un seul bouton menu
            subMenu.Visible = false;
        }

        public void hideSubMenu()
        {
            if (subMenu.Visible == true)
                subMenu.Visible = false;
        }

        public void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenu);
  
            buttonParrainage.Visible = false;
            buttonConnexion.Visible = false;
            buttonInscription.Visible = false;
            buttonCandidature.Visible = false;
            userControlMenu1.BringToFront();
            buttonConnexion.Visible = true;
           
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel.Height = buttonParent.Height;
            panel.Top = buttonParent.Top;
         
            buttonParrainage.Visible = true;
            buttonCandidature.Visible = false;
            buttonInscription.Visible = true;
            userControlParents1.BringToFront();
            
        }

        private void buttonProf_Click(object sender, EventArgs e)
        {
            panel.Height = buttonProf.Height;
            panel.Top = buttonProf.Top;
            
             buttonParrainage.Visible = false;
            
             buttonCandidature.Visible = true;
             userControlProf1.BringToFront();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonParrainage_Click(object sender, EventArgs e)
        {
            userControlParrainage1.BringToFront();
        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            userControlConnexion1.BringToFront();
        }


        private void buttonInscription_Click(object sender, EventArgs e)
        {
            userControlInscription1.BringToFront();
        }

        private void buttonContact_Click_1(object sender, EventArgs e)
        {
            userControlContact1.BringToFront();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReduire_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonAgrandir_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void buttonCandidature_Click(object sender, EventArgs e)
        {
            userControlCandidature1.BringToFront();
        }
    }
}
