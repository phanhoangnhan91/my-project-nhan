namespace RandomizedAlgorithm
{
    partial class Form1
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
            this.bttQuicksort = new System.Windows.Forms.Button();
            this.bttPrime = new System.Windows.Forms.Button();
            this.bttSpanningTree = new System.Windows.Forms.Button();
            this.bttMutiplyMatrix = new System.Windows.Forms.Button();
            this.bttCP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttQuicksort
            // 
            this.bttQuicksort.Location = new System.Drawing.Point(41, 30);
            this.bttQuicksort.Name = "bttQuicksort";
            this.bttQuicksort.Size = new System.Drawing.Size(106, 50);
            this.bttQuicksort.TabIndex = 10;
            this.bttQuicksort.Text = "Quicksort";
            this.bttQuicksort.UseVisualStyleBackColor = true;
            this.bttQuicksort.Click += new System.EventHandler(this.bttQuicksort_Click);
            // 
            // bttPrime
            // 
            this.bttPrime.Location = new System.Drawing.Point(167, 30);
            this.bttPrime.Name = "bttPrime";
            this.bttPrime.Size = new System.Drawing.Size(117, 50);
            this.bttPrime.TabIndex = 20;
            this.bttPrime.Text = "Primality Test";
            this.bttPrime.UseVisualStyleBackColor = true;
            this.bttPrime.Click += new System.EventHandler(this.bttPrime_Click);
            // 
            // bttSpanningTree
            // 
            this.bttSpanningTree.Location = new System.Drawing.Point(238, 105);
            this.bttSpanningTree.Name = "bttSpanningTree";
            this.bttSpanningTree.Size = new System.Drawing.Size(184, 53);
            this.bttSpanningTree.TabIndex = 50;
            this.bttSpanningTree.Text = "Minimum spanning tree";
            this.bttSpanningTree.UseVisualStyleBackColor = true;
            this.bttSpanningTree.Click += new System.EventHandler(this.bttSpanningTree_Click);
            // 
            // bttMutiplyMatrix
            // 
            this.bttMutiplyMatrix.Location = new System.Drawing.Point(41, 105);
            this.bttMutiplyMatrix.Name = "bttMutiplyMatrix";
            this.bttMutiplyMatrix.Size = new System.Drawing.Size(191, 53);
            this.bttMutiplyMatrix.TabIndex = 40;
            this.bttMutiplyMatrix.Text = "Verify matrix multiplication";
            this.bttMutiplyMatrix.UseVisualStyleBackColor = true;
            this.bttMutiplyMatrix.Click += new System.EventHandler(this.bttMutiplyMatrix_Click);
            // 
            // bttCP
            // 
            this.bttCP.Location = new System.Drawing.Point(304, 30);
            this.bttCP.Name = "bttCP";
            this.bttCP.Size = new System.Drawing.Size(117, 50);
            this.bttCP.TabIndex = 30;
            this.bttCP.Text = "Closest Pair";
            this.bttCP.UseVisualStyleBackColor = true;
            this.bttCP.Click += new System.EventHandler(this.bttCP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 197);
            this.Controls.Add(this.bttMutiplyMatrix);
            this.Controls.Add(this.bttSpanningTree);
            this.Controls.Add(this.bttCP);
            this.Controls.Add(this.bttPrime);
            this.Controls.Add(this.bttQuicksort);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application of randomzied algorithms";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttQuicksort;
        private System.Windows.Forms.Button bttPrime;
        private System.Windows.Forms.Button bttSpanningTree;
        private System.Windows.Forms.Button bttMutiplyMatrix;
        private System.Windows.Forms.Button bttCP;
    }
}

