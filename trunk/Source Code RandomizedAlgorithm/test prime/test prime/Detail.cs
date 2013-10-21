using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Client;

namespace Client
{
    public partial class Detail : Form
    {
        public Detail(String str, string title)
        {
           
            InitializeComponent();
            txt1.Text = str;
            this.Text = title;
        }

        private void Detail_Load(object sender, EventArgs e)
        {
            
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0112) // WM_SYSCOMMAND
            {
                // Check your window state here
                if (m.WParam == new IntPtr(0xF030)) // Maximize event - SC_MAXIMIZE from Winuser.h
                {
                    this.WindowState = FormWindowState.Maximized;
                    this.txt1.Size = new System.Drawing.Size(this.Size.Width -30, this.Size.Height -40 );
                    
                }
            }
            base.WndProc(ref m);
        }
    }
}
