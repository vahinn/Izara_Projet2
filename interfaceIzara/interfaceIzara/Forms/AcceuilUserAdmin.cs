using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaceIzara.Forms
{
    public partial class AcceuilUserAdmin : UserControl
    {
        public AcceuilUserAdmin()
        {
            InitializeComponent();
        }
        private void customizeDisgn()
        {
            panelMenuHorizontal.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelMenuHorizontal.Visible == true)
                panelMenuHorizontal.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonListPro_Click(object sender, EventArgs e)
        {
            openChildForm(new AffichageProf());
        }

        private void buttonMenuDash_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMenuHorizontal);
        }
    }
}
