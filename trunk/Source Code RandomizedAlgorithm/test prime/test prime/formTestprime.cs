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
using tetst_prime;


namespace Client
{
    public partial class FrTestPrime : Form
    {
        public FrTestPrime()
        {
            InitializeComponent();
            //run first time
            BigInteger bi = new BigInteger("5",10);
            Boolean bl = bi.FermatLittleTest(2);
            Boolean laSonguyento = TestPrimeClassical(2);
            //Sort Listview 
            listViewDuLieu.ListViewItemSorter = new IntegerComparer(1);
            listViewDuLieu.Sort();
        }

        private void btKiemtra_Click(object sender, EventArgs e)
        {
            double N;
            try
            {
                 N = Convert.ToDouble(txtN.Text);
            }
            catch
            {
                MessageBox.Show("Invalid input!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtN.Focus();
                return;
            }
            Stopwatch sw = Stopwatch.StartNew();
            Boolean isPrime = TestPrimeClassical(N);
            sw.Stop();
            // hiển thị chi tiết nếu cần
            if (chkShowDetail.Checked)
            {
                ShowDetail(N);
            }
            long microseconds = sw.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
            AddDataIntoList("Classical",N, microseconds.ToString());
            if (isPrime)
                lbKQ.Text = N + " is prime. [Classical]";
            else
                lbKQ.Text = N + " is composite. [Classical]";
            DrawChart();

        }

        private void ShowDetail( Double N)
        {
            string detail = "";
            bool flag = true;
            if (N == 0 || N == 1)
            {
                detail += "Return FALSE because N=" + N;
                flag = false;
            }
            int dem=0;
            for (int i = 2; i <= Convert.ToInt32(Math.Sqrt(N)); i++)
            {

                dem=i-1;
                if (N % i == 0)
                {
                    detail += "Step "+(i-1)+": return FALSE (Because (" + N + " mod " + i + " = 0) is True)\r\n";
                    flag = false;
                    break;
                }
                else
                {
                    detail += "Step " + (i - 1) +": "+ N + " mod " + i + " = " + (N % i) + " => (" + N + " mod " + i + " = 0) is False \r\n";
                }

            }
            if (flag)
                detail += "return TRUE after test " + dem + " times";
            Detail de = new Detail(detail,"Primality test details");
            de.Show();

        }

        private void AddDataIntoList(string algorithm,double N, string TG)
        {
            ListViewItem i = new ListViewItem(algorithm);
            i.SubItems.Add(N.ToString());
            i.SubItems.Add(TG);
            this.listViewDuLieu.Items.Add(i);
        }

        private Boolean TestPrimeClassical(double N) // false là hợp số, true la so nguyen to
        {
            if (N == 0 || N == 1)
                return false;
            if (N == 2 || N == 3)
                return true;
            for (int i = 2; i <= Convert.ToInt32(Math.Sqrt(N)); i++)
                if (N % i == 0)
                {
                    return false;
                }
            return true;
        }
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form();
            prompt.StartPosition = FormStartPosition.CenterParent;
            prompt.Width = 500;
            prompt.Height = 150;
            prompt.Text = caption;
            prompt.FormBorderStyle = FormBorderStyle.FixedSingle;
            prompt.MaximizeBox = false;
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text, Width=400 };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70 };
            textBox.Text = "10";
            textBox.SelectAll();
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.ShowDialog();
            return textBox.Text;
        }
        private void btKiemtraRa_Click(object sender, EventArgs e)
        {
            double n;
            int m;
            try
            {
                 n = Convert.ToDouble(txtN.Text);
            }
            catch
            {
                MessageBox.Show("Invalid input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtN.Focus();
                return;
            }

            try
            {

               // FrTestPrime.StartPosition = FormStartPosition.CenterParent;
                m = Convert.ToInt32(FrTestPrime.ShowDialog("The number of times to test for primality:", "Test for primality"));
            }
            catch
            {
                MessageBox.Show("Invalid input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnFermat.Focus();
                return;
            }

            
            Stopwatch sw = Stopwatch.StartNew();     
            BigInteger bi = new BigInteger(txtN.Text,10);
            Boolean bl=  bi.FermatLittleTest(m);
            sw.Stop();
            if (chkShowDetail.Checked)
            {
                Detail de = new Detail(bi.ShowDetail(m), "Fermat primality test details");
                de.Show();
            }

            long microseconds = sw.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
            AddDataIntoList("Fermat",n, microseconds.ToString());
            if (bl)
                lbKQ.Text = n + " is prime. [Fermat]";
            else
                lbKQ.Text = n + " is composite. [Fermat]";
            DrawChart();
        }
        private int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        public decimal luythua_chiadetri(decimal a, decimal n)
        {

            if (n == 0) return 1;
            decimal u = luythua_chiadetri(a, n / 2);
            if (n % 2 == 1)
                return u * u * a;
            else
                return u * u;


        }
        public int luythua(decimal a, decimal n)
        {
            decimal kq=1;
            for (int i = 0; i < n; i++)
                kq = kq * a;
            int tam = (int)(kq % (n+1));
            return tam;
        }

        private Boolean KiemtrasonguyentoRA(int n, int m)
        {
            #region thuật toán 1
            //if (n == 1 || n == 2)
            //    return true;
            //int[] b = new int[m];
            //Random rd = new Random();
            //for (int i = 0; i < m; i++) // tu i den m random ra 
            //    b[i] = rd.Next(2, n);
            //int k = 0;
            ////if ((n - 1) % 2 == 0)
            //    k = (n - 1) / 2;
            ////else
            ////    return false; // n là số chẵn
            //foreach (var bi in b)
            //{
            //    int uc = GCD(n, (int)Math.Pow(bi, k) - 1);

            //    //if (1 < uc && uc < n)
            //    if (uc != 1)
            //    {
            //        return false;
            //    }
            //}
            #endregion

            #region thuat toan 2

            Random rd = new Random();
            //int k;
            //if (n % 2 == 0)
            //    return false;
            //else
            //    k = (n - 1) / 2;
            int b, tam;
            for (int i = 0; i < m; i++)
            {
                b = rd.Next(2, n - 1);
                tam = luythua(b,n-1);
                if (tam != 1)
                    return false;
            }
            #endregion



            //int compare = 1 % n;
            //foreach (int bi in b)
            //{
            //    if (Math.Pow(bi, (n - 1)) % n != compare)
            //        return false;
            //}

            //foreach (int i in b) // voi moi so trong tap hop b (tap hop cac so tu 2 den n-1) thi lay n chia cho no
            //    if (n % i == 0)
            //    { 
            //        return false;
            //    }

            return true;

        }

        private Boolean Primality2(int n, int t)
        {
            #region thuật toán 1
            //if (n == 1 || n == 2)
            //    return true;
            //int[] b = new int[m];
            //Random rd = new Random();
            //for (int i = 0; i < m; i++) // tu i den m random ra 
            //    b[i] = rd.Next(2, n);
            //int k = 0;
            ////if ((n - 1) % 2 == 0)
            //    k = (n - 1) / 2;
            ////else
            ////    return false; // n là số chẵn
            //foreach (var bi in b)
            //{
            //    int uc = GCD(n, (int)Math.Pow(bi, k) - 1);

            //    //if (1 < uc && uc < n)
            //    if (uc != 1)
            //    {
            //        return false;
            //    }
            //}
            #endregion

            #region thuat toan 2

            Random rd = new Random();
            //int k;
            //if (n % 2 == 0)
            //    return false;
            //else
            //    k = (n - 1) / 2;
            int b, tam;
            int dem = 0;

            for (int i = 0; i < t; i++)
            {
                b = rd.Next(2, n - 1);
                if (GCD(b, n) != 1)
                    return false;

                tam = (int)(Math.Pow(b, (n - 1) / 2) % n);
                if (tam != 1)
                    return false;
                if (tam == 1)
                    dem++;
            }
            if (dem == t)
                return true;
            #endregion



            //int compare = 1 % n;
            //foreach (int bi in b)
            //{
            //    if (Math.Pow(bi, (n - 1)) % n != compare)
            //        return false;
            //}

            //foreach (int i in b) // voi moi so trong tap hop b (tap hop cac so tu 2 den n-1) thi lay n chia cho no
            //    if (n % i == 0)
            //    { 
            //        return false;
            //    }

            return true;

        }

        private void btDel_Click(object sender, EventArgs e)
        {
            listViewDuLieu.Items.Clear();
            chart1.Series.Clear();
        }
        public void DrawChart()
        {
            chart1.Series.Clear();
            chart1.Visible = true;
            Series sBF = new Series("Classical");
            Series sF = new Series("Fermat");
            for (int i = 0; i < listViewDuLieu.Items.Count; i++)
            {
                double x = Convert.ToDouble(listViewDuLieu.Items[i].SubItems[1].Text);
                double y = Convert.ToDouble(listViewDuLieu.Items[i].SubItems[2].Text);
                if (listViewDuLieu.Items[i].SubItems[0].Text == "Classical")
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
        
        private void FrTestPrime_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FrTestPrime_Load(object sender, EventArgs e)
        {
            TestPrimeClassical(47);
            BigInteger bi = new BigInteger("47", 10);
            bi.FermatLittleTest(10);
            txtN.SelectAll();
        }
    }
}
