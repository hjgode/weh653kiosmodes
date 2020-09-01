using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OEMTitleBarHandler
{
    public partial class LockDownTestForm : Form
    {
        public LockDownTestForm()
        {
            InitializeComponent();
            label1.Text = "This form will show without StartIcon. The registry changes are done before the form is shown. \r\nOn close, the registry changes are reverted.";
        }

        private void label2_ParentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LockDownTestForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}