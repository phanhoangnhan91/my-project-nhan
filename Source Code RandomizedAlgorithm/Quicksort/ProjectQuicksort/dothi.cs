using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjectQuicksort
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
            Series sQS = new Series("quicksort");
            Series sRQS = new Series("randomized quicksort");
            for (int i = 0; i < lv1.Items.Count; i++)
            {
                int x =Convert.ToInt32( lv1.Items[i].Text);
                int y = Convert.ToInt32(lv1.Items[i].SubItems[2].Text);
                if(lv1.Items[i].SubItems[1].Text=="quicksort")
                    sQS.Points.AddXY(x, y);
                else
                    sRQS.Points.AddXY(x, y);
                
            }
            output.Series.Add(sQS);
            output.Series.Add(sRQS);
            output.Series[0].Color = Color.Blue;
            output.Series[0].ChartType = SeriesChartType.Line;
            output.Series[0].BorderWidth = 2;
            output.Series[1].Color = Color.Yellow;
            output.Series[1].ChartType = SeriesChartType.Line;
            output.Series[1].BorderWidth = 2;
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
