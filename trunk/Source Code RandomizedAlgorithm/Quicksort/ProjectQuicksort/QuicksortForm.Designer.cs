namespace ProjectQuicksort
{
    partial class QuicksortForm
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
            this.lbRQS = new System.Windows.Forms.Label();
            this.lbQS = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_RAQuicksort = new System.Windows.Forms.Button();
            this.bt_QuickSort = new System.Windows.Forms.Button();
            this.bt_RandomArray = new System.Windows.Forms.Button();
            this.tb_OutputRQS = new System.Windows.Forms.TextBox();
            this.tb_OutputQS = new System.Windows.Forms.TextBox();
            this.tb_Input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listViewDuLieu = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btDel = new System.Windows.Forms.Button();
            this.chkDetails = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(751, 480);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkDetails);
            this.tabPage1.Controls.Add(this.lbRQS);
            this.tabPage1.Controls.Add(this.lbQS);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.bt_RAQuicksort);
            this.tabPage1.Controls.Add(this.bt_QuickSort);
            this.tabPage1.Controls.Add(this.bt_RandomArray);
            this.tabPage1.Controls.Add(this.tb_OutputRQS);
            this.tabPage1.Controls.Add(this.tb_OutputQS);
            this.tabPage1.Controls.Add(this.tb_Input);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(743, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Algorithm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbRQS
            // 
            this.lbRQS.AutoSize = true;
            this.lbRQS.Location = new System.Drawing.Point(387, 422);
            this.lbRQS.Name = "lbRQS";
            this.lbRQS.Size = new System.Drawing.Size(0, 17);
            this.lbRQS.TabIndex = 144;
            // 
            // lbQS
            // 
            this.lbQS.AutoSize = true;
            this.lbQS.Location = new System.Drawing.Point(68, 422);
            this.lbQS.Name = "lbQS";
            this.lbQS.Size = new System.Drawing.Size(0, 17);
            this.lbQS.TabIndex = 144;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(489, 17);
            this.label4.TabIndex = 143;
            this.label4.Text = "*This is an integer array. And numbers in array are seperated by one space.";
            // 
            // bt_RAQuicksort
            // 
            this.bt_RAQuicksort.Location = new System.Drawing.Point(500, 223);
            this.bt_RAQuicksort.Margin = new System.Windows.Forms.Padding(4);
            this.bt_RAQuicksort.Name = "bt_RAQuicksort";
            this.bt_RAQuicksort.Size = new System.Drawing.Size(175, 33);
            this.bt_RAQuicksort.TabIndex = 40;
            this.bt_RAQuicksort.Text = "Randomized Quicksort";
            this.bt_RAQuicksort.UseVisualStyleBackColor = true;
            this.bt_RAQuicksort.Click += new System.EventHandler(this.bt_RAQuicksort_Click);
            // 
            // bt_QuickSort
            // 
            this.bt_QuickSort.Location = new System.Drawing.Point(68, 225);
            this.bt_QuickSort.Margin = new System.Windows.Forms.Padding(4);
            this.bt_QuickSort.Name = "bt_QuickSort";
            this.bt_QuickSort.Size = new System.Drawing.Size(175, 31);
            this.bt_QuickSort.TabIndex = 30;
            this.bt_QuickSort.Text = "Quicksort";
            this.bt_QuickSort.UseVisualStyleBackColor = true;
            this.bt_QuickSort.Click += new System.EventHandler(this.bt_QuickSort_Click);
            // 
            // bt_RandomArray
            // 
            this.bt_RandomArray.Location = new System.Drawing.Point(68, 7);
            this.bt_RandomArray.Margin = new System.Windows.Forms.Padding(4);
            this.bt_RandomArray.Name = "bt_RandomArray";
            this.bt_RandomArray.Size = new System.Drawing.Size(150, 30);
            this.bt_RandomArray.TabIndex = 10;
            this.bt_RandomArray.Text = "Randomly Generate";
            this.bt_RandomArray.UseVisualStyleBackColor = true;
            this.bt_RandomArray.Click += new System.EventHandler(this.bt_RandomArray_Click);
            // 
            // tb_OutputRQS
            // 
            this.tb_OutputRQS.Location = new System.Drawing.Point(390, 265);
            this.tb_OutputRQS.Margin = new System.Windows.Forms.Padding(4);
            this.tb_OutputRQS.Multiline = true;
            this.tb_OutputRQS.Name = "tb_OutputRQS";
            this.tb_OutputRQS.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_OutputRQS.Size = new System.Drawing.Size(279, 153);
            this.tb_OutputRQS.TabIndex = 60;
            this.tb_OutputRQS.WordWrap = false;
            // 
            // tb_OutputQS
            // 
            this.tb_OutputQS.Location = new System.Drawing.Point(68, 265);
            this.tb_OutputQS.Margin = new System.Windows.Forms.Padding(4);
            this.tb_OutputQS.Multiline = true;
            this.tb_OutputQS.Name = "tb_OutputQS";
            this.tb_OutputQS.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_OutputQS.Size = new System.Drawing.Size(279, 153);
            this.tb_OutputQS.TabIndex = 50;
            this.tb_OutputQS.WordWrap = false;
            // 
            // tb_Input
            // 
            this.tb_Input.Location = new System.Drawing.Point(68, 43);
            this.tb_Input.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Input.Multiline = true;
            this.tb_Input.Name = "tb_Input";
            this.tb_Input.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_Input.Size = new System.Drawing.Size(607, 157);
            this.tb_Input.TabIndex = 20;
            this.tb_Input.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 137;
            this.label2.Text = "Input:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.listViewDuLieu);
            this.tabPage2.Controls.Add(this.btDel);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(743, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Running time chart";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(338, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 426);
            this.panel1.TabIndex = 22;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(10, 8);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(360, 405);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // listViewDuLieu
            // 
            this.listViewDuLieu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.listViewDuLieu.Location = new System.Drawing.Point(8, 6);
            this.listViewDuLieu.Name = "listViewDuLieu";
            this.listViewDuLieu.Size = new System.Drawing.Size(324, 390);
            this.listViewDuLieu.TabIndex = 20;
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
            this.columnHeader1.Text = "Size";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Running time (μs)";
            this.columnHeader2.Width = 120;
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(102, 402);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(102, 30);
            this.btDel.TabIndex = 100;
            this.btDel.Text = "Clear all";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // chkDetails
            // 
            this.chkDetails.AutoSize = true;
            this.chkDetails.Location = new System.Drawing.Point(317, 231);
            this.chkDetails.Name = "chkDetails";
            this.chkDetails.Size = new System.Drawing.Size(106, 21);
            this.chkDetails.TabIndex = 145;
            this.chkDetails.Text = "Show details";
            this.chkDetails.UseVisualStyleBackColor = true;
            // 
            // QuicksortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 480);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "QuicksortForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quicksort";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuicksortForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_RAQuicksort;
        private System.Windows.Forms.Button bt_QuickSort;
        private System.Windows.Forms.Button bt_RandomArray;
        private System.Windows.Forms.TextBox tb_OutputQS;
        private System.Windows.Forms.TextBox tb_Input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listViewDuLieu;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbQS;
        private System.Windows.Forms.TextBox tb_OutputRQS;
        private System.Windows.Forms.Label lbRQS;
        private System.Windows.Forms.CheckBox chkDetails;


    }
}