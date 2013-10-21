using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class FormInputNumberEdge : Form
    {
        public int n, m;
        public FormInputNumberEdge()
        {
            InitializeComponent();
        }

        private void FormInputNumberEdge_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.n = Convert.ToInt32(txtN.Text);
            this.m = Convert.ToInt32(txtM.Text);
            this.Hide();
        }
    }
}
