using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjectQuicksort
{
    
    public partial class QuicksortForm : Form
    {
        Random random=new Random();
        int[] qsArray;
       // int count=1;
        string details="";
        public QuicksortForm()
        {
            InitializeComponent();
            listViewDuLieu.ListViewItemSorter = new IntegerComparer(1);
            listViewDuLieu.Sort();
            int[] startArr = new int[2] { 1, 2 };
            quickSort(startArr, 0, startArr.Length - 1);
            randomizedQuicksort(startArr, 0, startArr.Length - 1);
        }

       
        #region Random Array button
        private void bt_RandomArray_Click(object sender, EventArgs e)
        {
            try
            {
                tb_Input.Clear();
                tb_OutputQS.Clear();
                tb_OutputRQS.Clear();
                lbQS.Text = "";
                lbRQS.Text = "";
                int so_pt;
                string inputK = Microsoft.VisualBasic.Interaction.InputBox("The size of input array:", "Random input", "2", 500, 200);
                if (!int.TryParse(inputK, out so_pt)&&inputK!="")
                {
                    throw new Exception("Invalid value!");
                }
                qsArray = new int[so_pt];
                StringBuilder str = new StringBuilder();
                for (int i = 0; i < so_pt; i++)
                {
                    qsArray[i] = random.Next(-5000000, 5000000);

                }
                Array.Sort(qsArray);
                Array.Reverse(qsArray);
                tb_Input.Text = readArray(qsArray, 10);
                //foreach (int i in qsArray)
                //{
                //    str.Append(i.ToString() + " ");
                //    if(i%10==0 && i!=0)

                //}

                //tb_Input.Text = str.ToString().TrimEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Read write array 
        private bool createArray()
        {
            string[] chuoi_cat = tb_Input.Text.Trim().Split(' ');
            qsArray = new int[chuoi_cat.Length];
            try
            {
                for (int i = 0; i < chuoi_cat.Length; i++)
                {
                    int so = 0;
                    //if (i % index == 0)
                    //    chuoi_cat[i + 1] = chuoi_cat[i + 1].Substring(4, chuoi_cat[i + 1].Length);
                    if (!int.TryParse(chuoi_cat[i], out so))
                        throw new Exception("Invalid input!");
                    qsArray[i] = so;
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }
        private string readArray(int[] array,int index)
        {
            StringBuilder content = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                content.Append(array[i] + " ");
                if (i % index == 0 && i != 0)
                    content.AppendLine();
            }
            return content.ToString().TrimEnd();
        }
        #endregion
       
        #region Quicksort (classic)
        private void bt_QuickSort_Click(object sender, EventArgs e)
        {
            try
            {
                tb_OutputQS.Clear();
                lbQS.Text = "";
                if (!createArray())
                    return;
                else
                {
                    Stopwatch sw = Stopwatch.StartNew();
                    if (chkDetails.Checked)
                    {
                        details = "";
                        //count = 1;
                        details += "\r\nInput array: " + printA(qsArray); 
                        quickSortDetails(qsArray, 0, qsArray.Length - 1);
                        Detail dt = new Detail(details,"Quicksort Details");
                        dt.Show();
                    }
                    else
                    {
                        quickSort(qsArray, 0, qsArray.Length - 1);
                    }
                    sw.Stop();
                    long microseconds = sw.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
                    ThemDuLieuVaoList(qsArray.Length, "Quicksort", microseconds.ToString());
                    tb_OutputQS.Text = readArray(qsArray,4);
                    lbQS.Text = "Running time: " + microseconds.ToString() + " microseconds";
                }
            }
            catch
            {
            }
        }

        void quickSortDetails(int[] a, int l, int r)
        {
           
            //count++;
            
            if (l < r)
            {
                
                int q = ParttitionDetails(a, l, r);
                
                details += "\r\n";
                details += "Partition 1 (l to q): "+l+" to "+(q-1);
                details += "\r\nPartition 2 (q+1 to r): " + (q+1) + " to " + r+"\r\n";
                quickSortDetails(a, l, q - 1);
                quickSortDetails(a, q + 1, r);
            }
            
            
            
        }
        void quickSort(int[] a, int l, int r)
        {
            if (l < r)
            {
                int q = Parttition(a, l, r);
                quickSort(a, l, q - 1);
                quickSort(a, q + 1, r);
            }
          
        }
        #endregion

        #region Quicksort (randomized)
        private void bt_RAQuicksort_Click(object sender, EventArgs e)
        {
            try
            {

                tb_OutputRQS.Clear();
                lbRQS.Text = "";
                if (!createArray())
                    return;
                Stopwatch sw = Stopwatch.StartNew();

                if (chkDetails.Checked)
                {
                    details = "";
                    //count = 1;
                    details += "\r\nInput array: " + printA(qsArray); 
                    randomizedQuicksortDetails(qsArray, 0, qsArray.Length - 1);
                    Detail dt = new Detail(details, "Randomized Quicksort Details");
                    dt.Show();
                }
                else
                {
                    randomizedQuicksort(qsArray, 0, qsArray.Length - 1);
                }

               
                sw.Stop();
                long microseconds = sw.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
                ThemDuLieuVaoList(qsArray.Length, "Randomized quicksort", microseconds.ToString());
                tb_OutputRQS.Text = readArray(qsArray,4);
                lbRQS.Text = "Running time: " + microseconds.ToString() + " microseconds";

            }
            catch
            {
            }
        }

        private void randomizedQuicksortDetails(int[] a, int l, int r)
        {
            if (l < r)
            {
                int q = randomizedPartitionDetails(a, l, r);
                details += "\r\n";
                details += "Partition 1 (l to q): " + l + " to " + (q - 1);
                details += "\r\nPartition 2 (q+1 to r): " + (q + 1) + " to " + r + "\r\n";
                randomizedQuicksortDetails(a, l, q - 1);
                randomizedQuicksortDetails(a, q + 1, r);
            }
        }

        private int randomizedPartitionDetails(int[] a, int l, int r)
        {
            //Chọn chỉ mục i ngẫu nhiên trong mảng.
            int i = random.Next(l, r + 1);
            details += "\r\nSelect Pivot=a["+i+"]="+a[i];
            //Hoán vị trí của phần tử thứ i với phần tử cuối mảng.

            details += "\r\nSwap a[r] and Pivot (a[r]=a[" + r + "]=" + a[r] + ",Pivot=a[" + i + "]=" + a[i] + ")";
            details += "\r\nArray befor swap: " + printA(a); 
            permutation(ref a[i], ref a[r]);
            details += "\r\nArray after swap: " + printA(a);
            return ParttitionDetails(a, l, r);
        }

        private void randomizedQuicksort(int[] a, int p, int r)
        {
            if (p < r)
            {
                int q=randomizedPartition(a,p,r);
                randomizedQuicksort(a, p, q - 1);
                randomizedQuicksort(a, q + 1, r);
            }
        }
        //Chọn chốt
        private int randomizedPartition(int[] a, int p, int r)
        {
            //Chọn chỉ mục i ngẫu nhiên trong mảng.
            int i = random.Next(p, r+1);
            //Hoán vị trí của phần tử thứ i với phần tử cuối mảng.
            permutation(ref a[i],ref a[r]);
            return Parttition(a, p, r);
        }
        // Sắp xếp mảng: phần tử nhỏ hơn bằng chốt về bên trái chốt và phần tử lớn hơn chốt về bên phải chốt
        private int Parttition(int[] a, int p, int r)
        {
            int x = a[r];
            int i = p - 1;
            for (int j = p; j < r; j++)
            {
                if (a[j] <= x)
                {
                    i++;
                    permutation(ref a[i],ref a[j]);
                }
            }
            permutation(ref a[i + 1], ref a[r]);
            return i + 1;
        }
        public string printA(int[]a) // ham xuat mang
        {
            string s="";
            for (int i = 0; i < a.Length; i++)
                s += "a["+i+"]="+a[i] + ", ";
            return s;
        }
        private int ParttitionDetails(int[] a, int p, int r)
        {
            int x = a[r];
            details += "\r\nPivot=a["+r+"]="+a[r];
            int i = p - 1;
            details += "\r\ni = p - 1, i=" + i +"(p="+p+")";
            
            for (int j = p; j < r; j++)
            {
                if(j!=p)
                    details += "\r\nj++, j=" + j;
                else
                    details += "\r\nj = p , j=" + j + "(p=" + p + ")";
                details += "\r\n(a[j]=" + a[j] + " <= Pivot) is " + (a[j] <= x).ToString();
                if (a[j] <= x)
                {
                    i++;
                    details += "\r\ni++, i="+i;
                    details += "\r\nSwap a[i] and a[j] (a[i]=a["+i+"]="+a[i]+",a[j]=a["+j+"]="+a[j]+")";
                    details += "\r\nArray befor swap: "+printA(a);
                    permutation(ref a[i], ref a[j]);
                    details += "\r\nArray after swap: "+printA(a);

                }
            }
            details += "\r\nSwap a[i+1] and Pivot (a[i+1]=a[" + (i+1) + "]=" + a[i+1] + ",Pivot=a[" + r + "]=" + a[r] + ")";
            details += "\r\nArray befor swap: " + printA(a);
            permutation(ref a[i + 1], ref a[r]);
            details += "\r\nArray after swap: " + printA(a);
            details += "\r\nq = (i+1) = " + (i+1);
            return i + 1;
        }

        private void permutation(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
        #endregion

        private void ThemDuLieuVaoList(int N,string name, string time)
        {
            ListViewItem i = new ListViewItem(name);
            i.SubItems.Add(N.ToString());
            i.SubItems.Add(time);
            this.listViewDuLieu.Items.Add(i);
            DrawChart();
        }

        private void DrawChart()
        {
            chart1.Series.Clear();
            chart1.Visible = true;
            Series sQS = new Series("Quicksort");
            Series sRQS = new Series("Randomized quicksort");
            for (int i = 0; i < listViewDuLieu.Items.Count; i++)
            {
                int x = Convert.ToInt32(listViewDuLieu.Items[i].SubItems[1].Text);
                int y = Convert.ToInt32(listViewDuLieu.Items[i].SubItems[2].Text);
                if (listViewDuLieu.Items[i].SubItems[0].Text == "Quicksort")
                    sQS.Points.AddXY(x, y);
                else
                    sRQS.Points.AddXY(x, y);

            }
            chart1.Series.Add(sQS);
            chart1.Series.Add(sRQS);
            chart1.Series[0].Color = Color.Blue;
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[0].BorderWidth = 2;
            chart1.Series[1].Color = Color.Red;
            chart1.Series[1].ChartType = SeriesChartType.Line;
            chart1.Series[1].BorderWidth = 2;
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            listViewDuLieu.Items.Clear();
            chart1.Series.Clear();
        }

        //private void bt_SapXep_Click(object sender, EventArgs e)
        //{
        //    tb_OutputQS.Clear();
        //    createArray();
        //    int[] inputRA =(from inputArr in qsArray
        //                        select inputArr).ToArray();
        //    Stopwatch swRQS = Stopwatch.StartNew();
        //    // randomizedQuicksort(qsArray,0,qsArray.Length-1);
        //    randomizedQuicksort(qsArray, 0, qsArray.Length - 1);
        //    swRQS.Stop();
        //    long microsecondsRQS = swRQS.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
        //    Stopwatch sw = Stopwatch.StartNew();
        //    quickSort(qsArray, 0, qsArray.Length - 1);
        //    sw.Stop();
        //    long microseconds = sw.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
        //    ThemDuLieuVaoList(qsArray.Length, microseconds.ToString(), microsecondsRQS.ToString());
        //    tb_OutputQS.Text = readArray(qsArray,4);
        //}

        private void QuicksortForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
