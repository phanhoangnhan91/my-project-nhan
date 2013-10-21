using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MultiplyMatrix
{
    public partial class Form1 : Form
    {
        int MTsize;
        int[,] MTA;
        int[,] MTB;
        int[,] MTC;
        Random random;
        bool startBF=true,startF=true;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            listViewDuLieu.ListViewItemSorter = new IntegerComparer(1);
            listViewDuLieu.Sort();
        }
        #region Phép tính ma trận
        //SO sánh hai ma trận
        private bool CompareMT(int[,] A, int[,] B)
        {
            for(int i=0;i<A.GetLength(0);i++)
                for (int j = 0; j <A.GetLength(1); j++)
                {
                    if (A[i, j] != B[i, j])
                        return false;
                }
            return true;
        }
        //Trừ ma trận
        private int[,] SubtractionMT(int[,] A, int[,] B,int d,int c)
        {
            int[,] Result = new int[d,c];
            for (int i = 0; i < d; i++)
                for (int j = 0; j < c; j++)
                    Result[i, j] = A[i, j] - B[i, j];
            return Result;
        }
        //Nhân ma trận
        private int[,] MultiplyMT(int[,] A, int[,] B, int dA, int cA, int cB)
        {
            int[,] Result= new int[cA, cB];
            for (int i = 0; i < dA; i++)
                for (int j = 0; j < cB; j++)
                {
                    for (int k = 0; k < cA; k++)
                    {
                        Result[i, j] += A[i, k] * B[k, j];
                    }
                }
            return Result;
        }
        #endregion

        #region Khởi tạo, xuất ma trận
        //In ma trận
        private string PrintMatrix(int[,] MT)
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < MT.GetLength(0); i++)
            {
                for (int j = 0; j < MT.GetLength(1); j++)
                {
                    str.Append(MT[i, j].ToString()+" ");
                }
                str.AppendLine();
            }
            return str.ToString().TrimEnd();
        }
        private void refreshAll()
        {
            try
            {
                if (!int.TryParse(tbSize.Text, out MTsize))
                {
                    throw new Exception("giá trị nhập phải là số nguyên dương");
                }
                if (MTsize < 2)
                {
                    throw new Exception("Kích thước ma trận phải lớn hơn 1");
                }
                tbResultBF.Text = "";
                lbResult1.Text = "";
                lbResult2.Text = "";
                MTA = new int[MTsize, MTsize];
                MTB = new int[MTsize, MTsize];
                MTC = new int[MTsize, MTsize];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        //tạo ma trận
        private int[,] createMT(string text)
        {
            try
            {
                int[,] error = new int[1, 1];
                int[,] Rs = new int[MTsize, MTsize];
                string[] Rows = text.Split('\n');
                int i = 0, j = 0;
                foreach (string row in Rows)
                {
                    string r = row.TrimEnd();
                    string[] number = r.Split(' ');
                    if (number.Length != MTsize)
                    {
                        return null;
                    }
                    for (j = 0; j < MTsize; j++)
                    {
                        if (!int.TryParse(number[j], out Rs[i, j]))
                        {
                            error[0, 0] = i * 10 + j;
                            return error;
                        }
                    }
                    i++;
                }
                return Rs;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region Nhân và so sánh
        #endregion

        #region Giải thuật ngẫu nhiên
        #endregion

        //bool compare;
        //private void bt_Click(object sender, EventArgs e)
        //{
        //  //  refreshAll();
        //    int[,] MTResult;
        //    string rs = "";
        //    compare = true;
        //    MTA = createMT(tbMTA.Text);
        //    MTB = createMT(tbMTB.Text);
        //    MTC = createMT(tbMTC.Text);
        //    switch (((Button)sender).Name)
        //    {
        //        case "btMultiply":
        //            Stopwatch sw = Stopwatch.StartNew();
        //            MTResult = MultiplyMT(MTA, MTB, MTsize, MTsize, MTsize);
        //            compare= CompareMT(MTResult, MTC);
        //             sw.Stop();
        //            long microseconds = sw.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
        //            ThemDuLieuVaoList(microseconds.ToString());
        //            rs = "Kết quả AxB:\r\n";
        //            rs += PrintMatrix(MTResult);
        //            if (compare)
        //                rs += "\r\nAxB=C";
        //            else
        //                rs += "\r\nAxB!=C";

        //            break;
        //        case "btRA":
        //            int k=1;
        //            bool[] kCompare= new bool[k];
        //            Stopwatch swR = Stopwatch.StartNew();
        //            //int[,] vector = new int[MTsize, 1];
        //            //int[,] result = new int[MTsize, 1];
        //            //for (int i = 0; i < result.GetLength(1); i++)
        //            //{
        //            //    result[i, 0] = 0;
        //            //}
        //            //for (int j = 0; j < k; j++)
        //            //{
        //            //    RandomizedCalculation(result);
        //            //    kCompare[j] = compare;
        //            //}
        //            //for (int i = 0; i < k; i++)
        //            //{
        //            //    if (kCompare[i] == false)
        //            //    {
        //            //        compare = false;
        //            //        break;
        //            //    }
        //            //}
        //            swR.Stop();
        //            long microsecondsR = swR.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
        //            ThemDuLieuVaoList(microsecondsR.ToString());
        //            //if (compare)
        //            //    rs += "\r\nKết luận: AxB=C";
        //            //else
        //            //    rs += "\r\nKết luận: AxB!=C";
        //            break;
        //    }
        //    tbResult.Text = rs;
        //}

        //private bool MatrixEqualityTest(int[] A,int[] B,int[] C,int k)  
        //{
        //    int[,] vector = new int[MTsize, 1];
        //    int[,] result = new int[MTsize, 1];
        //    for (int i = 0; i < result.GetLength(1); i++)
        //    {
        //        result[i, 0] = 0;
        //    }
        //    for (int j = 0; j < k; j++)
        //    {
        //        bool compare = false;
        //        RandomizedCalculation(result,ref compare);
        //    }
        //    return true;
        //}

        private int[,] RandomizedCalculation(int[,]result, ref bool compare)
        {
             int[,] MTResult;
             int[,] vector = new int[MTsize, 1];

            // vecto 0 được dùng để so sánh
             for (int i = 0; i < MTsize; i++)
             {
                 vector[i, 0] = random.Next(0, 2);
             }

            //A x B x r -C x r
             MTResult = MultiplyMT(MTB, vector, MTsize, MTsize,1);
             MTResult = MultiplyMT(MTA, MTResult, MTsize, MTsize, 1);
            MTResult =SubtractionMT(MTResult,MultiplyMT(MTC, vector, MTC.GetLength(0), MTC.GetLength(1), vector.GetLength(1)),MTResult.GetLength(0),MTResult.GetLength(1));

            //So sánh kết quả
            compare = CompareMT(MTResult, result);

            return MTResult;
        }


    

        #region Button Random Input
        private void btRInput_Click(object sender, EventArgs e)
        {
            refreshAll();           
            for(int i=0;i<MTsize;i++)
            {
                for (int j = 0; j < MTsize; j++)
                {
                    MTA[i, j] = random.Next(0, 10);
                    MTB[i, j] = random.Next(0, 10);
                    MTC[i, j] = random.Next(0, 1000);
                }
            }
            tbMTA.Text = PrintMatrix(MTA);
            tbMTB.Text = PrintMatrix(MTB);
            tbMTC.Text = PrintMatrix(MTC);
        }
        #endregion

        #region Brute Force
        private void btMultiply_Click(object sender, EventArgs e)
        {           
            tbResultBF.Clear();
            lbResult1.Text = "";
            int[,] MTResult;
            bool compare = true;

            MTA = createMT(tbMTA.Text);
            MTB = createMT(tbMTB.Text);
            MTC = createMT(tbMTC.Text);

            if (startBF)
            {
                startBF = false;
                MTResult = MultiplyMT(MTA, MTB, MTsize, MTsize, MTsize);
                compare = CompareMT(MTResult, MTC);
            }

            Stopwatch sw = Stopwatch.StartNew();
            MTResult = MultiplyMT(MTA, MTB, MTsize, MTsize, MTsize);
            compare = CompareMT(MTResult, MTC);
            sw.Stop();  
          
            //Thời gian chạy 
            long microseconds = sw.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
            ThemDuLieuVaoList(MTsize,"Brute Force", microseconds.ToString());

            //Xuất kết quả
            string rs = "Result: ";
            if (compare)
                rs += "AxB=C\r\n";
            else
                rs += "AxB!=C\r\n";
            rs += "Running time: " + microseconds.ToString()+ " microseconds" ;
            lbResult1.Text = rs;
            tbResultBF.Text = PrintMatrix(MTResult);
        }
        #endregion


        #region Freivalds
        private void btRA_Click(object sender, EventArgs e)
        {
            try
            {
                //Nhập số lần thử 
                string inputK = Microsoft.VisualBasic.Interaction.InputBox("Nhập k:", "Số lần thực hiện", "1", 320, 320);
                int k;
                if (!int.TryParse(inputK, out k))
                {
                    if (inputK == "")
                    {
                        k = 1;
                    }
                    else
                        throw new Exception ("Giá trị k không hợp lệ");
                }
                if (startF)
                {
                    startF = false;
                    bool[] compareDrafts = MatrixEqualityTest(MTA, MTB, MTC, k);                   
                }
                Stopwatch sw = Stopwatch.StartNew();
                bool[] compare= MatrixEqualityTest(MTA, MTB, MTC, k);
                bool compareResult=true;
                for (int i = 0; i < k; i++)
                {
                    if (!compare[i])
                    {
                        compareResult = false;
                        break;
                    }
                }
                sw.Stop();

                //Thời gian chạy 
                long microseconds = sw.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
                ThemDuLieuVaoList(MTsize, "Freivalds", microseconds.ToString());

                //Xuất kết quả
                string rs = "Number of trials " + k.ToString() + "\r\nResult: ";
                if (compareResult)
                    rs += "AxB=C\r\n";
                else
                    rs += "AxB!=C\r\n";
                rs += "Running time " + microseconds.ToString() + " microseconds";
                lbResult2.Text = rs;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private bool[] MatrixEqualityTest(int[,] A,int[,] B,int[,] C,int k)
        {
            bool[] compare = new bool[k];
            for (int j = 0; j < k; j++)
            {
                int[,] vectorR = new int[MTsize, 1];

                // vecto ngẫu nhiên r
                for (int i = 0; i < MTsize; i++)
                {
                    vectorR[i, 0] = random.Next(0, 2);
                }
                
                int[,] MTResultL,MTResultR;
                //Ax(Bxr)
                MTResultL = MultiplyMT(MTB, vectorR, MTsize, MTsize, 1);
                MTResultL = MultiplyMT(MTA, MTResultL, MTsize, MTsize, 1);
                //C x r
                MTResultR = MultiplyMT(MTC, vectorR, MTsize, MTsize, 1);
                compare[j] = CompareMT(MTResultR, MTResultL);
            }
            return compare;
        }
        #endregion
        private void btt_Copy_Click(object sender, EventArgs e)
        {
            string tmp = tbResultBF.Text.Remove(0, 14);
            tmp = tmp.Remove(tmp.Length - 7, 7);
            tbMTC.Text = tmp;
        }
     
        private void btdothi_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Visible = true;
            Series sBF = new Series("Brute Force");
            Series sF = new Series("Freivalds");
            for (int i = 0; i < listViewDuLieu.Items.Count; i++)
            {
                int x = Convert.ToInt32(listViewDuLieu.Items[i].SubItems[1].Text);
                int y = Convert.ToInt32(listViewDuLieu.Items[i].SubItems[2].Text);
                if (listViewDuLieu.Items[i].SubItems[0].Text == "Brute Force")
                    sBF.Points.AddXY(x, y);
                else
                    sF.Points.AddXY(x, y);

            }
            chart1.Series.Add(sBF);
            chart1.Series.Add(sF);
            chart1.Series[0].Color = Color.Blue;
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[0].BorderWidth = 2;
            chart1.Series[1].Color = Color.Red;
            chart1.Series[1].ChartType = SeriesChartType.Line;
            chart1.Series[1].BorderWidth = 2;
        }

        private void ThemDuLieuVaoList(int size,string name, string time)
        {
            ListViewItem i = new ListViewItem(name);
            i.SubItems.Add(size.ToString());
            i.SubItems.Add(time);
            this.listViewDuLieu.Items.Add(i);
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            listViewDuLieu.Items.Clear();
            chart1.Series.Clear();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit this program?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

     
    }
}
