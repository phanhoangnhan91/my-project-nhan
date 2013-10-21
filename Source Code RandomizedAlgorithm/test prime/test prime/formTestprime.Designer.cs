namespace Client
{
    partial class FrTestPrime
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
            this.txtN = new System.Windows.Forms.TextBox();
            this.lbKQ = new System.Windows.Forms.Label();
            this.btnClassical = new System.Windows.Forms.Button();
            this.btnFermat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.listViewDuLieu = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chkShowDetail = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(119, 38);
            this.txtN.Margin = new System.Windows.Forms.Padding(4);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(132, 23);
            this.txtN.TabIndex = 10;
            this.txtN.Text = "68718952433";
            this.txtN.TextChanged += new System.EventHandler(this.txtN_TextChanged);
            this.txtN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
            // 
            // lbKQ
            // 
            this.lbKQ.AutoSize = true;
            this.lbKQ.Location = new System.Drawing.Point(71, 87);
            this.lbKQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(0, 17);
            this.lbKQ.TabIndex = 1;
            // 
            // btnClassical
            // 
            this.btnClassical.Location = new System.Drawing.Point(272, 38);
            this.btnClassical.Margin = new System.Windows.Forms.Padding(4);
            this.btnClassical.Name = "btnClassical";
            this.btnClassical.Size = new System.Drawing.Size(100, 28);
            this.btnClassical.TabIndex = 20;
            this.btnClassical.Text = "Classical";
            this.btnClassical.UseVisualStyleBackColor = true;
            this.btnClassical.Click += new System.EventHandler(this.btKiemtra_Click);
            // 
            // btnFermat
            // 
            this.btnFermat.Location = new System.Drawing.Point(391, 38);
            this.btnFermat.Margin = new System.Windows.Forms.Padding(4);
            this.btnFermat.Name = "btnFermat";
            this.btnFermat.Size = new System.Drawing.Size(100, 28);
            this.btnFermat.TabIndex = 30;
            this.btnFermat.Text = "Fermat";
            this.btnFermat.UseVisualStyleBackColor = true;
            this.btnFermat.Click += new System.EventHandler(this.btKiemtraRa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Output:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.listViewDuLieu);
            this.groupBox2.Location = new System.Drawing.Point(19, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 391);
            this.groupBox2.TabIndex = 114;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Running time chart";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 8);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(406, 307);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(333, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 328);
            this.panel1.TabIndex = 22;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(336, 356);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 33);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "Clear all";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btDel_Click);
            // 
            // listViewDuLieu
            // 
            this.listViewDuLieu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.listViewDuLieu.Location = new System.Drawing.Point(6, 30);
            this.listViewDuLieu.Name = "listViewDuLieu";
            this.listViewDuLieu.Size = new System.Drawing.Size(321, 307);
            this.listViewDuLieu.TabIndex = 16;
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
            this.columnHeader1.Text = "Input";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Running time (μs)";
            this.columnHeader2.Width = 129;
            // 
            // chkShowDetail
            // 
            this.chkShowDetail.AutoSize = true;
            this.chkShowDetail.Location = new System.Drawing.Point(531, 43);
            this.chkShowDetail.Name = "chkShowDetail";
            this.chkShowDetail.Size = new System.Drawing.Size(106, 21);
            this.chkShowDetail.TabIndex = 115;
            this.chkShowDetail.Text = "Show details";
            this.chkShowDetail.UseVisualStyleBackColor = true;
            // 
            // FrTestPrime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 548);
            this.Controls.Add(this.chkShowDetail);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnFermat);
            this.Controls.Add(this.btnClassical);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.txtN);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrTestPrime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primality Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrTestPrime_FormClosing);
            this.Load += new System.EventHandler(this.FrTestPrime_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label lbKQ;
        private System.Windows.Forms.Button btnClassical;
        private System.Windows.Forms.Button btnFermat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListView listViewDuLieu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckBox chkShowDetail;
    }
}

