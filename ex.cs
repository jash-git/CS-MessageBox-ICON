using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test
{
    public partial class Form_test : Form
    {
        public Form_test()
        {
            InitializeComponent();
        }

        private void Form_test_Load(object sender, EventArgs e)
        {
            MessageBox.Show("MessageBoxIcon.Asterisk", "MessageBox.Show", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            MessageBox.Show("MessageBoxIcon.Error", "MessageBox.Show", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show("MessageBoxIcon.Exclamation", "MessageBox.Show", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            MessageBox.Show("MessageBoxIcon.Hand", "MessageBox.Show", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            MessageBox.Show("MessageBoxIcon.Information", "MessageBox.Show", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("MessageBoxIcon.None", "MessageBox.Show", MessageBoxButtons.OK, MessageBoxIcon.None);
            MessageBox.Show("MessageBoxIcon.Question", "MessageBox.Show", MessageBoxButtons.OK, MessageBoxIcon.Question);
            MessageBox.Show("MessageBoxIcon.Stop", "MessageBox.Show", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            MessageBox.Show("MessageBoxIcon.Warning", "MessageBox.Show", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}