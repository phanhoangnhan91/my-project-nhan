namespace ProjectClosestPair
{
    partial class FindClosestPair
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btDel = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.lbresult = new System.Windows.Forms.Label();
            this.btRA = new System.Windows.Forms.Button();
            this.btDC = new System.Windows.Forms.Button();
            this.btInput = new System.Windows.Forms.Button();
            this.btBF = new System.Windows.Forms.Button();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewDuLieu = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbInput = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(126, 368);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(78, 30);
            this.btDel.TabIndex = 100;
            this.btDel.Text = "Clear all";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Size";
            this.columnHeader1.Width = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "*Points in array are seperated by a tab.";
            // 
            // lbresult
            // 
            this.lbresult.AutoSize = true;
            this.lbresult.Location = new System.Drawing.Point(80, 353);
            this.lbresult.Name = "lbresult";
            this.lbresult.Size = new System.Drawing.Size(55, 17);
            this.lbresult.TabIndex = 3;
            this.lbresult.Text = "Output:";
            // 
            // btRA
            // 
            this.btRA.Location = new System.Drawing.Point(414, 306);
            this.btRA.Name = "btRA";
            this.btRA.Size = new System.Drawing.Size(159, 36);
            this.btRA.TabIndex = 50;
            this.btRA.Text = "Randomized Algorithm";
            this.btRA.UseVisualStyleBackColor = true;
            this.btRA.Click += new System.EventHandler(this.btRA_Click);
            // 
            // btDC
            // 
            this.btDC.Location = new System.Drawing.Point(248, 306);
            this.btDC.Name = "btDC";
            this.btDC.Size = new System.Drawing.Size(160, 36);
            this.btDC.TabIndex = 40;
            this.btDC.Text = "Divide and Conquer";
            this.btDC.UseVisualStyleBackColor = true;
            this.btDC.Click += new System.EventHandler(this.btDC_Click);
            // 
            // btInput
            // 
            this.btInput.Location = new System.Drawing.Point(83, 18);
            this.btInput.Name = "btInput";
            this.btInput.Size = new System.Drawing.Size(159, 27);
            this.btInput.TabIndex = 10;
            this.btInput.Text = "Randomly Generate";
            this.btInput.UseVisualStyleBackColor = true;
            this.btInput.Click += new System.EventHandler(this.btInput_Click);
            // 
            // btBF
            // 
            this.btBF.Location = new System.Drawing.Point(82, 305);
            this.btBF.Name = "btBF";
            this.btBF.Size = new System.Drawing.Size(160, 36);
            this.btBF.TabIndex = 30;
            this.btBF.Text = "Brute Force";
            this.btBF.UseVisualStyleBackColor = true;
            this.btBF.Click += new System.EventHandler(this.btBF_Click);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Algorithm";
            this.columnHeader3.Width = 120;
            // 
            // listViewDuLieu
            // 
            this.listViewDuLieu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.listViewDuLieu.Location = new System.Drawing.Point(8, 6);
            this.listViewDuLieu.Name = "listViewDuLieu";
            this.listViewDuLieu.Size = new System.Drawing.Size(327, 356);
            this.listViewDuLieu.TabIndex = 22;
            this.listViewDuLieu.UseCompatibleStateImageBehavior = false;
            this.listViewDuLieu.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Running time (μs)";
            this.columnHeader2.Width = 120;
            // 
            // tbInput
            // 
            this.tbInput.AcceptsTab = true;
            this.tbInput.Location = new System.Drawing.Point(83, 51);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInput.Size = new System.Drawing.Size(628, 222);
            this.tbInput.TabIndex = 20;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.listViewDuLieu);
            this.tabPage2.Controls.Add(this.btDel);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(739, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Running time chart";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(341, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 404);
            this.panel1.TabIndex = 23;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(13, 13);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(354, 379);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Points:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lbresult);
            this.tabPage1.Controls.Add(this.btRA);
            this.tabPage1.Controls.Add(this.btDC);
            this.tabPage1.Controls.Add(this.btInput);
            this.tabPage1.Controls.Add(this.btBF);
            this.tabPage1.Controls.Add(this.tbInput);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(739, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Algorithm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(747, 445);
            this.tabControl1.TabIndex = 1;
            // 
            // FindClosestPair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 445);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FindClosestPair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find closest pair";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindClosestPair_FormClosing);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbresult;
        private System.Windows.Forms.Button btRA;
        private System.Windows.Forms.Button btDC;
        private System.Windows.Forms.Button btInput;
        private System.Windows.Forms.Button btBF;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listViewDuLieu;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}