using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prim
{
    public partial class frmCost : Form
    {
        public int _cost;

        public frmCost()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtCost.Text == string.Empty)
            {
                errorProvider1.SetError(txtCost, "Please enter value");
            }
            else
            {
                _cost = int.Parse(txtCost.Text);
                this.Close();
            }
        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !Char.IsDigit(e.KeyChar);

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmCost_Load(object sender, EventArgs e)
        {

        }
    }
}
