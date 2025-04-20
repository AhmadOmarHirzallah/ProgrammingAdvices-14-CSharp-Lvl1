using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1st_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // You can use this for reaching the Form1 explicitly from other forms !
        //Form1 myForm = new Form1();

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text;
        }

        private void cpyMsEntrB1toB2(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void cpyMsEntrB2toB1(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = textBox2.Text;
        }

        private void button_disable_txt2_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
        }

        private void button_enable_txt2_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }

        private void buttonHideUnnecessary_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox3.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        private void buttonDisplayHidden_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox3.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
        }


        private void applyDarkMode()
        {
            BackColor = Color.FromArgb(30, 30, 30); // Dark gray (close to system dark mode)
            ForeColor = Color.White; // Text color for contrast
            updateControlsTheme(this, Color.FromArgb(45, 45, 48), Color.White); // Update all controls
        }

        private void applyLightMode()
        {
            BackColor = Color.White; // Light background
            ForeColor = Color.Black; // Dark text for contrast
            updateControlsTheme(this, Color.WhiteSmoke, Color.Black); // Update all controls
        }

        private void updateControlsTheme(Control parent, Color backColor, Color foreColor)
        {
            foreach (Control control in parent.Controls)
            {
                control.BackColor = backColor;
                control.ForeColor = foreColor;

                // Recursive call for container controls (e.g., Panels, GroupBoxes)
                if (control.HasChildren)
                {
                    updateControlsTheme(control, backColor, foreColor);
                }
            }
        }

        private void buttonChangeTheme_MouseClick(object sender, MouseEventArgs e)
        {
            if (BackColor == Color.White) // Light Mode
            {
                applyDarkMode();
            }
            else // Dark Mode
            {
                applyLightMode();
            }
        }

        private void buttonApplyFormTitle_Click(object sender, EventArgs e)
        {
            this.Text = txtFormTitle.Text;
        }

        private void btnApplyFormHeader_Click(object sender, EventArgs e)
        {
            labelFormHeader.Text = txtFormHeader.Text;
            labelFormHeader.ForeColor = Color.Blue;
        }

        private void txtFormHeaderAuto_TextChanged(object sender, EventArgs e)
        {
            labelFormHeader.Text = txtFormHeaderAuto.Text;
            labelFormHeader.ForeColor = Color.Blue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void msgBoxBtn(object sender, EventArgs e)
        {
            MessageBox.Show("ahmad", "omar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3, MessageBoxOptions.RightAlign);
        }
    }
}
