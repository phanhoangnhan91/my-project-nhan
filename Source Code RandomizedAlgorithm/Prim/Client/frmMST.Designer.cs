namespace Prim
{
    partial class frmMinimuSpanningStree
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRandomGraph = new System.Windows.Forms.Button();
            this.lbRunningTime2 = new System.Windows.Forms.Label();
            this.lbRunningTime = new System.Windows.Forms.Label();
            this.lbGT = new System.Windows.Forms.Label();
            this.btopen = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.lbTongchiphi = new System.Windows.Forms.Label();
            this.btRA = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btPrim = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btDel = new System.Windows.Forms.Button();
            this.listViewDuLieu = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chkDetail = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(720, 453);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkDetail);
            this.tabPage1.Controls.Add(this.btnRandomGraph);
            this.tabPage1.Controls.Add(this.lbRunningTime2);
            this.tabPage1.Controls.Add(this.lbRunningTime);
            this.tabPage1.Controls.Add(this.lbGT);
            this.tabPage1.Controls.Add(this.btopen);
            this.tabPage1.Controls.Add(this.btSave);
            this.tabPage1.Controls.Add(this.lbTongchiphi);
            this.tabPage1.Controls.Add(this.btRA);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.btPrim);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(712, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Algorithm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRandomGraph
            // 
            this.btnRandomGraph.Location = new System.Drawing.Point(591, 9);
            this.btnRandomGraph.Name = "btnRandomGraph";
            this.btnRandomGraph.Size = new System.Drawing.Size(118, 28);
            this.btnRandomGraph.TabIndex = 63;
            this.btnRandomGraph.Text = "Random Graph";
            this.btnRandomGraph.UseVisualStyleBackColor = true;
            this.btnRandomGraph.Click += new System.EventHandler(this.btnRandomGraph_Click);
            // 
            // lbRunningTime2
            // 
            this.lbRunningTime2.AutoSize = true;
            this.lbRunningTime2.Location = new System.Drawing.Point(588, 379);
            this.lbRunningTime2.Name = "lbRunningTime2";
            this.lbRunningTime2.Size = new System.Drawing.Size(48, 17);
            this.lbRunningTime2.TabIndex = 62;
            this.lbRunningTime2.Text = "12456";
            // 
            // lbRunningTime
            // 
            this.lbRunningTime.AutoSize = true;
            this.lbRunningTime.Location = new System.Drawing.Point(590, 350);
            this.lbRunningTime.Name = "lbRunningTime";
            this.lbRunningTime.Size = new System.Drawing.Size(100, 17);
            this.lbRunningTime.TabIndex = 61;
            this.lbRunningTime.Text = "Running Time:";
            // 
            // lbGT
            // 
            this.lbGT.AutoSize = true;
            this.lbGT.Location = new System.Drawing.Point(594, 289);
            this.lbGT.Name = "lbGT";
            this.lbGT.Size = new System.Drawing.Size(44, 17);
            this.lbGT.TabIndex = 34;
            this.lbGT.Text = "[Prim]";
            // 
            // btopen
            // 
            this.btopen.Location = new System.Drawing.Point(607, 43);
            this.btopen.Name = "btopen";
            this.btopen.Size = new System.Drawing.Size(81, 32);
            this.btopen.TabIndex = 20;
            this.btopen.Text = "Open file";
            this.btopen.UseVisualStyleBackColor = true;
            this.btopen.Click += new System.EventHandler(this.btopen_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(608, 81);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(81, 32);
            this.btSave.TabIndex = 30;
            this.btSave.Text = "Save file";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // lbTongchiphi
            // 
            this.lbTongchiphi.AutoSize = true;
            this.lbTongchiphi.Location = new System.Drawing.Point(590, 321);
            this.lbTongchiphi.Name = "lbTongchiphi";
            this.lbTongchiphi.Size = new System.Drawing.Size(70, 17);
            this.lbTongchiphi.TabIndex = 30;
            this.lbTongchiphi.Text = "Total cost";
            // 
            // btRA
            // 
            this.btRA.Location = new System.Drawing.Point(608, 214);
            this.btRA.Name = "btRA";
            this.btRA.Size = new System.Drawing.Size(81, 32);
            this.btRA.TabIndex = 60;
            this.btRA.Text = "&RA ";
            this.btRA.UseVisualStyleBackColor = true;
            this.btRA.Click += new System.EventHandler(this.btRA_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(608, 119);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(81, 32);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btPrim
            // 
            this.btPrim.Location = new System.Drawing.Point(608, 166);
            this.btPrim.Name = "btPrim";
            this.btPrim.Size = new System.Drawing.Size(81, 32);
            this.btPrim.TabIndex = 50;
            this.btPrim.Text = "&Prim";
            this.btPrim.UseVisualStyleBackColor = true;
            this.btPrim.Click += new System.EventHandler(this.btPrim_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 404);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Controls.Add(this.btDel);
            this.tabPage2.Controls.Add(this.listViewDuLieu);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(712, 424);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Running time chart";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(310, 20);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(390, 368);
            this.chart1.TabIndex = 20;
            this.chart1.Text = "chart1";
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(90, 367);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(106, 31);
            this.btDel.TabIndex = 19;
            this.btDel.Text = "Clear all";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click_1);
            // 
            // listViewDuLieu
            // 
            this.listViewDuLieu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.listViewDuLieu.Location = new System.Drawing.Point(9, 20);
            this.listViewDuLieu.Name = "listViewDuLieu";
            this.listViewDuLieu.Size = new System.Drawing.Size(295, 341);
            this.listViewDuLieu.TabIndex = 17;
            this.listViewDuLieu.UseCompatibleStateImageBehavior = false;
            this.listViewDuLieu.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Algorithm";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Vertices";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Running time";
            this.columnHeader2.Width = 100;
            // 
            // chkDetail
            // 
            this.chkDetail.AutoSize = true;
            this.chkDetail.Location = new System.Drawing.Point(607, 252);
            this.chkDetail.Name = "chkDetail";
            this.chkDetail.Size = new System.Drawing.Size(106, 21);
            this.chkDetail.TabIndex = 64;
            this.chkDetail.Text = "Show details";
            this.chkDetail.UseVisualStyleBackColor = true;
            // 
            // frmMinimuSpanningStree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(718, 449);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMinimuSpanningStree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minimum spanning tree";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMinimuSpanningStree_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btopen;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label lbTongchiphi;
        private System.Windows.Forms.Button btRA;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btPrim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.ListView listViewDuLieu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbGT;
        private System.Windows.Forms.Label lbRunningTime2;
        private System.Windows.Forms.Label lbRunningTime;
        private System.Windows.Forms.Button btnRandomGraph;
        private System.Windows.Forms.CheckBox chkDetail;



    }
}