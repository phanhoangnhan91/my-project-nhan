using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectQuicksort;
using Client;
using MultiplyMatrix;
using Prim;
using ProjectClosestPair;
namespace RandomizedAlgorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttQuicksort_Click(object sender, EventArgs e)
        {
            QuicksortForm form = new QuicksortForm();
            form.ShowDialog();
        }

        private void bttPrime_Click(object sender, EventArgs e)
        {
            Client.FrTestPrime form = new FrTestPrime();
            form.ShowDialog();
        }

        private void bttCP_Click(object sender, EventArgs e)
        {
            FindClosestPair form = new FindClosestPair();
            form.ShowDialog();
        }

        private void bttMutiplyMatrix_Click(object sender, EventArgs e)
        {
            MultiplyMatrix.MutiplyMtrx form = new MutiplyMtrx();
            form.ShowDialog();
        }

        private void bttSpanningTree_Click(object sender, EventArgs e)
        {
            frmMinimuSpanningStree form = new frmMinimuSpanningStree();
            form.ShowDialog();
        }
    }
}
