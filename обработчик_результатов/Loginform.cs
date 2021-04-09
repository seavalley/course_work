using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace обработчик_результатов
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }
        public bool flag = false;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                pictureBox3.Image = Properties.Resources.closedeyes;
                flag = true;
                passbox.UseSystemPasswordChar = false;
            }
            else
            {
                pictureBox3.Image = Properties.Resources.openeye;
                flag = false;
                passbox.UseSystemPasswordChar = true;
            }
        }
        private void loginbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                passbox.Focus();
            }
        }
        private void passbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logbutton.Focus();
            }
        }
        private void logbutton_Enter(object sender, EventArgs e)
        {
            logbutton.BackColor = Color.FromName("PeachPuff");
        }
        private void logbutton_Click(object sender, EventArgs e)
        {
            if (loginbox.Text == "trpo")
                if (passbox.Text == "8k2491")
                {
                    Mainform mainform = new Mainform();
                    this.Hide();
                    mainform.ShowDialog();                 
                }
                else MessageBox.Show("Неверный логин или пароль");
            else MessageBox.Show("Неверный логин и пароль");
            logbutton.BackColor = Color.FromName("AntiqueWhite");
            loginbox.Focus();
        }
    }
}
