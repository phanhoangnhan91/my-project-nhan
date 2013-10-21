using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace tetst_prime
{
    public partial class dothi : Form
    {
        ListView lv1 = new ListView();
        public dothi( ListView lv)
        {
            InitializeComponent();
            this.lv1 = lv;
        }
        private void DrawChart(Chart output)
        {
            
            output.Series.RemoveAt(0);
            output.Visible = true;
            Series s = new Series();
            //for (int i = 1; i <= 5; i++)
            //{
            //    s.Points.AddXY(i, i);
            //}
            for (int i = 0; i < lv1.Items.Count; i++)
            {
                int x =Convert.ToInt32( lv1.Items[i].Text);
                int y = Convert.ToInt32(lv1.Items[i].SubItems[1].Text);
                s.Points.AddXY(x, y);
                
            }

            
            output.Series.Add(s);
            output.Series[0].Color = Color.Red;
            output.Series[0].ChartType = SeriesChartType.Line;
            output.Series[0].BorderWidth = 2;
           
        }

        private void dothi_Load(object sender, EventArgs e)
        {
            DrawChart(chart1);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
