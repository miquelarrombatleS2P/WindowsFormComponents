using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Properties
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            refreshButton();
            
        }

        private void targetButton_Click(object sender, EventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            this.Text = "("+this.Location.X +","+ this.Location.Y+")"+ "Winforms Components - Common Controls";
        }

        private void refreshButton()
        {
            targetButton.Text = "Target" + Environment.NewLine + "X = " + $"{targetButton.Location.X}" +
                Environment.NewLine + "Y = " + $"{targetButton.Location.Y}";
        }

        private void right_Click(object sender, EventArgs e)
        {
            targetButton.Location = new Point(targetButton.Location.X + 5, targetButton.Location.Y);
            refreshButton();
            
        }

        private void left_Click(object sender, EventArgs e)
        {
            targetButton.Location = new Point(targetButton.Location.X - 5, targetButton.Location.Y);
            refreshButton();
        }

        private void up_Click(object sender, EventArgs e)
        {
            targetButton.Location = new Point(targetButton.Location.X, targetButton.Location.Y - 5);
            refreshButton();
        }

        private void down_Click(object sender, EventArgs e)
        {
            targetButton.Location = new Point(targetButton.Location.X, targetButton.Location.Y + 5);
            refreshButton();
        }

        private void visibility_Click(object sender, EventArgs e)
        {
            String text = visibility.Text;
            if (text == "Visibility = False")
            {
                targetButton.Visible = true;
                visibility.Text = "Visibility = True";
            }
            else
            {
                targetButton.Visible = false;
                visibility.Text = "Visibility = False";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String text = enabled.Text;
            if (text == "Enabled = False")
            {
                targetButton.Enabled = true;
                enabled.Text = "Enabled = True";
            }
            else
            {
                targetButton.Enabled = false;
                enabled.Text = "Enabled = False";
            }
        }

        private void mainForm_Resize(object sender, EventArgs e)
        {
            formSizeLabel.Text = $"Form Size: {this.Width}, {this.Height}";
        }

        private void mainForm_Move(object sender, EventArgs e)
        {
            this.Text = $"{this.Location.X}, {this.Location.Y} Winforms Components - Common Controls";
        }

        private void centerTarget_Click(object sender, EventArgs e)
        {
            targetButton.Location = new Point(this.Width / 2, this.Height / 2);
            refreshButton();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String value = comboBox1.SelectedItem.ToString();

            if (value == "None")
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            }
            else if (value == "Fixed3D")
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            }
            else if (value == "FixedDialog")
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            }
            else if (value == "FixedSingle")
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            }
            else if (value == "FixedToolWindow")
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            }
            else if (value == "Sizable")
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
            else
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            }

        }
    }
}
