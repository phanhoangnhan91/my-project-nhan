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

namespace ProjectClosestPair
{
    public partial class FindClosestPair : Form
    {
       Random random;
        public FindClosestPair()
        {
            InitializeComponent();
            random = new Random();
            lbresult.Text = "";

            //first running
            IPoint[] testP = new IPoint[6] { new IPoint(2, 2), new IPoint(5, 5),new IPoint(4,2),new IPoint(3,4),new IPoint(2,6),new IPoint(10,11) };
            double testdistanceBF = double.MaxValue,testdistanceDC,testdistanceRa;
            IPoint[] resultBF = bruteForce(testP, ref testdistanceBF);
            IPoint[] resultDC = closestDC(testP, out testdistanceDC);
            IPoint[] resultRA = RandomizedAl(testP, out testdistanceRa);

            listViewDuLieu.ListViewItemSorter = new IntegerComparer(1);
            listViewDuLieu.Sort();
        }


        private void FindClosestPair_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //Nút sinh mảng điểm ngẫu nhiên
        private void btInput_Click(object sender, EventArgs e)
        {
            try
            {
                int countP;

                string inputK = Microsoft.VisualBasic.Interaction.InputBox("The size of input array:", "Random input", "2", 500, 200);
                if ((!int.TryParse(inputK, out countP)||countP<=0) && inputK!="" )
                {
                    throw new Exception("Invalid value!");
                }

                //refresh 
                tbInput.Clear();
                lbresult.Text = "";
                
                IPoint[] P = new IPoint[countP];

                for (int i = 0; i < P.Length; i++)
                {
                    P[i] = new IPoint(random.Next(0,P.Length*10), random.Next(0,P.Length*10));
                }
                tbInput.Text = PrintArrP(P);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private string PrintArrP(IPoint[] P)
        {
            StringBuilder strInput = new StringBuilder();
            for (int i = 0; i < P.Length; i++)
            {
                strInput.Append(string.Format("({0},{1})\t", P[i]._X, P[i]._Y));
            }
            return strInput.ToString();
        }

        private IPoint[] ReadArrP()
        {
            string[] chuoi_cat =tbInput.Text.Trim().Split('\t','\t');
            IPoint[] dsdiem = new IPoint[chuoi_cat.Length];
            try
            {
                for (int i = 0; i < chuoi_cat.Length; i++)
                {
                    chuoi_cat[i] = chuoi_cat[i].Replace("(", "");
                    chuoi_cat[i] = chuoi_cat[i].Replace(")", "");
                    string[] xy = chuoi_cat[i].Split(',');
                    dsdiem[i] = new IPoint(Convert.ToInt32(xy[0]), Convert.ToInt32(xy[1]));
                    
                }
                return dsdiem;
            }
            catch
            {
                MessageBox.Show("The input has a invalid point");
                return null;
            }
         
        }
        #region Brute Force
        private void btBF_Click(object sender, EventArgs e)
        {
            try
            {
                //Đọc mảng từ input
                IPoint[] inputP = ReadArrP();

                //có lỗi xảy ra
                if (inputP == null)
                    return;
                Stopwatch swBF = new Stopwatch();
                swBF.Start();
                double distance = double.MaxValue;
                IPoint[] result = bruteForce(inputP, ref distance);
                swBF.Stop();
                long microsecondsBF = swBF.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
                ThemDuLieuVaoList(inputP.Length, "Brute Force", microsecondsBF.ToString());
                lbresult.Text = string.Format("[Brute Force]\nThe closest pair of points:({0},{1})---({2},{3}). Distance: {4}\nThe running time: {5} microseconds", result[0]._X, result[0]._Y, result[1]._X, result[1]._Y,Math.Round(distance,3),microsecondsBF.ToString());
                if (chk_detail.Checked)
                {
                    strDetail = new StringBuilder();
                    Detail f = new Detail();
                    distance = double.MaxValue;
                    strDetail.AppendLine("Input: " + PrintArrP(inputP));
                    strDetail.AppendLine("-------------------------------------------");
                    bruteForceDetail(inputP, ref distance);
                    f.result =strDetail.ToString();
                    f.ShowDialog();
                }
            }
            catch
            {
            }
        }
         // A Brute Force method to return the smallest distance between two points
        //in array P[]
        private IPoint[] bruteForce(IPoint[] P,ref double minDist)
        {
            double distTmp = minDist;
            IPoint[] result = new IPoint[2];
            for (int i = 0; i < P.Length; ++i)
            {
                for (int j = i + 1; j < P.Length; ++j)
                {
                    double distXY = distanceXY(P[i], P[j]);
                    if (distXY < minDist)
                    {
                        minDist = distXY;
                        result[0] = P[i];
                        result[1] = P[j];
                    }
                }
            }
            if (distTmp == minDist)
                return null;
            return result;
        }

        private void bruteForceDetail(IPoint[] P, ref double minDist)
        {
            int countDis = 0;
            IPoint[] result = new IPoint[2];
            for (int i = 0; i < P.Length; ++i)
            {
                for (int j = i + 1; j < P.Length; ++j)
                {
                    double distXY = distanceXY(P[i], P[j]);
                    countDis++;
                    strDetail.Append(String.Format("Distance between ({0}, {1}) and ({2}, {3}): {4}",P[i]._X,P[i]._Y,P[j]._X,P[j]._Y,Math.Round(distXY,3)));
                    if (distXY < minDist)
                    {
                        strDetail.Append("-->now we choose this pair");
                        minDist = distXY;
                        result[0] = P[i];
                        result[1] = P[j];
                    }
                    strDetail.AppendLine();
                    strDetail.AppendLine();
                }
            }
            strDetail.AppendLine("--------------------------------------");           
            strDetail.AppendLine(String.Format("Number of distance computation: {0}", countDis));           
            strDetail.AppendLine(String.Format("Closest pair:({0}, {1}) - ({2}, {3}). Distance: {4} ", result[0]._X, result[0]._Y, result[1]._X, result[1]._Y, Math.Round(minDist, 3)));            
        }

        #endregion

        #region Divide and Conquer
        private void btDC_Click(object sender, EventArgs e)
        {
            try
            {
                //Đọc mảng từ textbox input
                IPoint[] inputP = ReadArrP();

                //có lỗi xảy ra
                if (inputP == null)
                    return;

                
                double distance;
                Stopwatch swDC = new Stopwatch();
                
                //Sắp xếp mảng điểm theo hoành độ
                var sortedX = (from arr in inputP
                               orderby arr._X
                               select arr).ToArray();
                swDC.Start();
                IPoint[] result = closestDC(sortedX, out distance);
                swDC.Stop();
                long microsecondsDC = swDC.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
                lbresult.Text = string.Format("[Divide and Conquer]\nThe closest pair of points:({0},{1})---({2},{3}). Distance: {4}\nThe running time: {5} microseconds", result[0]._X, result[0]._Y, result[1]._X, result[1]._Y, Math.Round(distance, 3), microsecondsDC.ToString());
                ThemDuLieuVaoList(inputP.Length, "Divide-Conquer", microsecondsDC.ToString());
                if (chk_detail.Checked)
                {
                    recursiveTime = 0;
                    strDetail = new StringBuilder();
                    Detail f = new Detail();

                    inputP = ReadArrP();
                    sortedX = (from arr in inputP
                                   orderby arr._X
                                   select arr).ToArray();
                    strDetail.AppendLine("Input: " + PrintArrP(inputP));
                    strDetail.AppendLine("Pre-processing: sorted according to x coordinates");
                    strDetail.AppendLine(PrintArrP(sortedX));
                    strDetail.AppendLine("---------------------------------------------");

                    IPoint[] pointDetai = closestDCDetail(sortedX, out distance);
                    f.result = strDetail.ToString();
                    f.ShowDialog();
                }
            }
            catch(Exception ex)
            {
            }
        }
        private IPoint[] closestDC(IPoint[] P,out double distance)
        {
             distance = double.MaxValue;

            //Nếu đầu vào có 2 hoặc 3 điểm sử dụng chiến lược trực tiếp
            if (P.Length <= 3)
            {             
                return bruteForce(P,ref distance);
            }
            IPoint[] result = new IPoint[2];

            //Chia mảng làm hai phần
            int mid = (int)P.Length / 2;
            IPoint[] pointLeft = new IPoint[mid];
            IPoint[] pointRight = new IPoint[P.Length - mid];
            for (int i = 0; i < mid; i++)
                pointLeft[i] = P[i];
            for (int i = 0; i < P.Length - mid; i++)
                pointRight[i] = P[i + mid];

            //Tiến hành đệ qui để tìm khoảng cách ngắn nhất của mỗi mảnh
            // Tìm khoảng cách ngắn nhất ở mảng trái và mảng phải
            IPoint[] pairLeft = new IPoint[2];
            IPoint[] pairRight = new IPoint[2];
            double distanceL , distanceR ;

            pairLeft = closestDC(pointLeft,out distanceL);
            pairRight = closestDC(pointRight,out distanceR);
            //Chọn khoảng cách ngắn nhất giữa 2 kết quả
            if (distanceL > distanceR)
            {
                result = pairRight;
                distance = distanceR;
            }
            else
            {
                result = pairLeft;
                distance = distanceL;
            }

            //Tạo mảng gồm các điểm có hoành độ đến điểm giữa mảng nhỏ hơn khoảng cách được chọn ở trên
            //Tạo tập điểm midPoints
            int midCoordinate = P[mid]._X;
            double xDown = midCoordinate - distance;
            double xUpper = midCoordinate + distance;
            var midPoints = (from arr in P
                             where arr._X > xDown && arr._X < xUpper
                             orderby arr._Y
                             select arr).ToArray();

            // Khoảng cách ngắn nhất là khoảng cách ngắn nhất được tìm thấy trong tập hợp điểm midPoints
            if (midPoints.Length > 1)
            {
                IPoint[] resultTmp = bruteForce(midPoints,ref distance);
                if (resultTmp != null)
                    return resultTmp;
            }
            return result;
        }

        private string PrintTab(int recursiveT)
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < recursiveT; i++)
                str.Append("   ");
            return str.ToString();
        }

        int recursiveTime;
        private IPoint[] closestDCDetail(IPoint[] P, out double distance)
        {
            recursiveTime++;
            distance = double.MaxValue;

            //Nếu đầu vào có 2 hoặc 3 điểm sử dụng chiến lược trực tiếp
            if (P.Length <= 3)
            {
                strDetail.AppendLine(String.Format("{0}Find closest pair in {1}",PrintTab(recursiveTime),PrintArrP(P)));
                recursiveTime--;
                return bruteForce(P, ref distance);
            }
            IPoint[] result = new IPoint[2];

            //Chia mảng làm hai phần
            int mid = (int)P.Length / 2;
            strDetail.AppendLine(PrintTab(recursiveTime)+"Devide array to 2 part:");
            IPoint[] pointLeft = new IPoint[mid];
            IPoint[] pointRight = new IPoint[P.Length - mid];
            for (int i = 0; i < mid; i++)
                pointLeft[i] = P[i];
            for (int i = 0; i < P.Length - mid; i++)
                pointRight[i] = P[i + mid];
          
            

            //Tiến hành đệ qui để tìm khoảng cách ngắn nhất của mỗi mảnh
            // Tìm khoảng cách ngắn nhất ở mảng trái và mảng phải
            IPoint[] pairLeft = new IPoint[2];
            IPoint[] pairRight = new IPoint[2];
            double distanceL, distanceR;
            strDetail.AppendLine(String.Format("{0}Left part: {1}", PrintTab(recursiveTime),PrintArrP(pointLeft)));
            pairLeft = closestDCDetail(pointLeft, out distanceL);
            strDetail.AppendLine(String.Format("{0}Right part: {1}", PrintTab(recursiveTime), PrintArrP(pointRight)));
            pairRight = closestDCDetail(pointRight, out distanceR);

            //Chọn khoảng cách ngắn nhất giữa 2 kết quả
            if (distanceL > distanceR)
            {
                result = pairRight;
                distance = distanceR;
            }
            else
            {
                result = pairLeft;
                distance = distanceL;
            }
            strDetail.AppendLine(String.Format("{0}Smallest distances in both subarrays: {1}",PrintTab(recursiveTime),distance));
            //Tạo mảng gồm các điểm có hoành độ đến điểm giữa mảng nhỏ hơn khoảng cách được chọn ở trên
            //Tạo tập điểm midPoints
            int midCoordinate = P[mid]._X;
            double xDown = midCoordinate - distance;
            double xUpper = midCoordinate + distance;
            var midPoints = (from arr in P
                             where arr._X > xDown && arr._X < xUpper
                             orderby arr._Y
                             select arr).ToArray();

            strDetail.AppendLine(String.Format("{0}Point(s) in middle part: {1}", PrintTab(recursiveTime), PrintArrP(midPoints)));
            // Khoảng cách ngắn nhất là khoảng cách ngắn nhất được tìm thấy trong tập hợp điểm midPoints
            if (midPoints.Length > 1)
            {
                strDetail.AppendLine(String.Format("{0}Find closest pair in middle part {1}",PrintTab(recursiveTime),PrintArrP(midPoints)));
                IPoint[] resultTmp = bruteForce(midPoints, ref distance);
                if (resultTmp != null)
                {
                    strDetail.AppendLine(string.Format("{0}Closest pair: ({1}, {2})-({3}, {4}). Distance: {5}", PrintTab(recursiveTime), result[0]._X, result[0]._Y, result[1]._X, result[1]._Y, distance));
                    recursiveTime--;
                    return resultTmp;
                }
            }
            else 
            {
                strDetail.AppendLine("No points whose x coordinate is closer than" + distance);
            }
            strDetail.AppendLine(string.Format("{0}Closest pair: ({1}, {2})-({3}, {4}). Distance: {5}", PrintTab(recursiveTime), result[0]._X, result[0]._Y, result[1]._X, result[1]._Y, distance));
            recursiveTime--;
            return result;
        }

        #endregion

        #region Randomize Algorithm
        private void btRA_Click(object sender, EventArgs e)
        {
            try
            {
                //Đọc mảng từ textbox input
                IPoint[] inputP = ReadArrP();

                //có lỗi xảy ra
                if (inputP == null)
                    return;
                recursive = true;
                inrecurisve = false;

                Stopwatch swRa = new Stopwatch();
                swRa.Start();
                double distance;
                IPoint[] result = RandomizedAl(inputP, out distance);
                swRa.Stop();
                long microsecondsRa = swRa.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
                lbresult.Text = string.Format("[Randomized Algorithm]\nThe closest pair of points:({0},{1})---({2},{3}). Distance: {4}\nThe running time: {5} microseconds", result[0]._X, result[0]._Y, result[1]._X, result[1]._Y, Math.Round(distance, 3), microsecondsRa.ToString());
                ThemDuLieuVaoList(inputP.Length, "Randomized", microsecondsRa.ToString());
                if (chk_detail.Checked)
                {
                    recursive = true;
                    inrecurisve = false;
                    strDetail = new StringBuilder();
                    Detail f = new Detail();
                    f.Text = "Detail of Randomized Algorithm";
                    IPoint[] resultDetail = RandomizedAlDetail(inputP, out distance);
                    strDetail.AppendLine("-----------------------------");
                    strDetail.AppendLine(String.Format("Output:\r\nClosest pair: ({0}, {1})-({2}, {3}).Distance: {4}", resultDetail[0]._X, resultDetail[0]._Y, resultDetail[1]._X, resultDetail[1]._Y, distance));
                    f.result = strDetail.ToString();
                    f.ShowDialog();
                }
            }
            catch
            {
            }
           
        }


        StringBuilder strDetail;
        bool recursive = true,inrecurisve=false;
        private IPoint[] RandomizedAl(IPoint[] P, out double distanceRA)
        {
            distanceRA = double.MaxValue;

            if (P.Length <= 3 && !inrecurisve)
                return bruteForce(P, ref distanceRA);

            //Chọn ngẫu nhiên n^2/3 điểm từ input
            //Tạo thành mảng S[]
            int rp = (int)Math.Round(Math.Pow(P.Length, (2 * 1.0 / 3)), 0);
            IPoint[] S = new IPoint[rp];

            List<int> indexP = new List<int>();
            for (int i = 0; i < P.Length; i++)
            {
                indexP.Add(i);
            }

            for (int i = 0; i < S.Length; i++)
            {
                int r = random.Next(0, indexP.Count);
                S[i] = P[indexP[r]];
                indexP.RemoveAt(r);
            }

            //Tính khoảng cách ngắn nhất trong mảng S[], bằng cách đệ qui gọi hàm RandomizedAl 1 lần
            //Đặt làm delta
            double delta=double.MaxValue;
            //Trong lần đệ qui đó dùng chiến lược trực tiếp để tìm khoảng cách delta
            if (inrecurisve)
            {
                inrecurisve = false;
                IPoint[] tmp = bruteForce(S, ref delta);
            }
            if (recursive)
            {
                recursive = false;
                inrecurisve = true;
                IPoint[] resultS = RandomizedAl(S, out delta);
            }

            //Xác định số lượng ô vuông có cạnh bằng delta:
            //Xác định hoành độ lớn nhất và tung độ lớn nhất trong các điểm 
            //Chọn giá trị lớn và đem chia cho denta
            int maxX, maxY;
            FindMaxXY(P, out maxX, out maxY);
            int maxValue = maxX >= maxY ? maxX : maxY;
            int SquareInRow = (int)Math.Round(maxValue / delta); 
            if (SquareInRow * delta <= maxValue)
                SquareInRow++;

            //Xây dựng tập T
            Dictionary<int, List<IPoint>> boT = new Dictionary<int, List<IPoint>>();
            for (int i = 0; i < P.Length; i++)
            {
                double a = P[i]._X / delta;
                double b = P[i]._Y / delta;
                int index = ((int)a + SquareInRow * (int)b);
                if (!boT.ContainsKey(index))
                {
                    boT[index] = new List<IPoint>();
                }
                boT[index].Add(P[i]);
            }

            Dictionary<string, List<IPoint>> doubleSize = FindNeighbor(boT, SquareInRow);

            //Tìm khoảng cách ngắn nhất từ các hình vuông mở rộng
            IPoint[] resultP = new IPoint[2];
            foreach (var pair in doubleSize)
            {
                IPoint[] resultTmp = bruteForce(pair.Value.ToArray(), ref distanceRA);
                if (resultTmp != null)
                {
                    resultP = resultTmp;
                }
            }
            return resultP;        
        }

        private Dictionary<string, List<IPoint>> FindNeighbor(Dictionary<int,List<IPoint>> boT,int SquareInRow )
        {
            Dictionary<string, List<IPoint>> doubleSize = new Dictionary<string, List<IPoint>>();
            //Mở rộng các hình vuông trong bộ T -Xây dựng T1,T2,T3,T4
            foreach (var s in boT)
            {
                int keyT = s.Key, rightN = keyT + 1, aboveN = keyT + SquareInRow, arN = aboveN + 1, alN = aboveN - 1;
                string key = keyT.ToString();

                //Nếu s hiện tại có hai điểm hoặc tồn tại các tập điểm lân cận s-không tính các s ở biên phải
                if (s.Value.Count > 1 || ((keyT % SquareInRow != SquareInRow - 1) && (boT.ContainsKey(rightN) || boT.ContainsKey(aboveN) || boT.ContainsKey(arN))))
                {
                    doubleSize[key] = new List<IPoint>();
                    doubleSize[key].AddRange(s.Value);

                    //Thêm neighbor
                    if (boT.ContainsKey(rightN))
                        doubleSize[key].AddRange(boT[rightN]);
                    if (boT.ContainsKey(aboveN))
                        doubleSize[key].AddRange(boT[aboveN]);
                    if (boT.ContainsKey(arN))
                        doubleSize[key].AddRange(boT[arN]);
                }

                //Trường hợp s có tập điểm lân cận nằm chéo trái trên, không tính các s ở biên trái
                if (boT.ContainsKey(alN) && keyT % SquareInRow != 0)
                {
                    string specialKey = key + "_special";
                    doubleSize[specialKey] = new List<IPoint>();
                    doubleSize[specialKey].AddRange(boT[keyT]);
                    doubleSize[specialKey].AddRange(boT[alN]);
                }
            }
            return doubleSize;
        }

        private void FindMaxXY(IPoint[] points, out int maxX, out int maxY)
        {
            maxX = points[0]._X;
            maxY = points[0]._Y;
            for (int i = 1; i < points.Length; i++)
            {
                if (points[i]._X > maxX)
                    maxX = points[i]._X;
                if (points[i]._Y > maxY)
                    maxY = points[i]._Y;
            }
        }

        private double distanceXY(IPoint p, IPoint q)
        {
            return Math.Sqrt(Math.Pow(p._X - q._X, 2) + Math.Pow(p._Y - q._Y, 2));
        }

        private IPoint[] RandomizedAlDetail(IPoint[] P, out double distanceRA)
        {
            distanceRA = double.MaxValue;

            if (P.Length <= 3 && !inrecurisve)
                return bruteForce(P, ref distanceRA);

            //Chọn ngẫu nhiên n^2/3 điểm từ input
            //Tạo thành mảng S[]
            int rp = (int)Math.Round(Math.Pow(P.Length, (2 * 1.0 / 3)), 0);
            IPoint[] S = new IPoint[rp];

            List<int> indexP = new List<int>();
            for (int i = 0; i < P.Length; i++)
            {
                indexP.Add(i);
            }

            for (int i = 0; i < S.Length; i++)
            {
                int r = random.Next(0, indexP.Count);
                S[i] = P[indexP[r]];
                indexP.RemoveAt(r);
            }
            strDetail.Append(String.Format("Choose random {0} point(s) from {1} points\r\n", S.Length, P.Length));
            strDetail.Append(PrintArrP(S)+"\r\n");
            //Tính khoảng cách ngắn nhất trong mảng S[], bằng cách đệ qui gọi hàm RandomizedAl 1 lần
            //Đặt làm delta
            double delta = double.MaxValue;
            //Trong lần đệ qui đó dùng chiến lược trực tiếp để tìm khoảng cách delta
            if (inrecurisve)
            {
                inrecurisve = false;
                IPoint[] tmp = bruteForce(S, ref delta);
                strDetail.Append(String.Format("Delta in recursive: {0}\r\n", delta));
            }
            if (recursive)
            {
                recursive = false;
                inrecurisve = true;
                IPoint[] resultS = RandomizedAlDetail(S, out delta);
                strDetail.Append(String.Format("Finish step 1\r\n--------------------------\r\nDelta:{0}\r\n", delta));
            }

            //Xác định số lượng ô vuông có cạnh bằng delta:
            //Xác định hoành độ lớn nhất và tung độ lớn nhất trong các điểm 
            //Chọn giá trị lớn và đem chia cho denta
            int maxX, maxY;
            FindMaxXY(P, out maxX, out maxY);
            int maxValue = maxX >= maxY ? maxX : maxY;
            int SquareInRow = (int)Math.Round(maxValue / delta);
            if (SquareInRow * delta <= maxValue)
                SquareInRow++;
            if (!inrecurisve)
            {
                strDetail.AppendLine("Number of square in T: "+ (SquareInRow * SquareInRow));
            }
            //Xây dựng tập T
            Dictionary<int, List<IPoint>> boT = new Dictionary<int, List<IPoint>>();
            for (int i = 0; i < P.Length; i++)
            {
                double a = P[i]._X / delta;
                double b = P[i]._Y / delta;
                int index = ((int)a + SquareInRow * (int)b);
                if (!boT.ContainsKey(index))
                {
                    boT[index] = new List<IPoint>();
                }
                boT[index].Add(P[i]);
            }
            strDetail.Append(PrintSquare(boT));
            Dictionary<string, List<IPoint>> doubleSize = FindNeighbor(boT, SquareInRow);
            strDetail.AppendLine("****");
            strDetail.Append("Constructor squares by double delta. We will find closest pair in those squares so they must contain at least 2 points \r\n");
            strDetail.Append(PrintSquare(doubleSize));
            //Tìm khoảng cách ngắn nhất từ các hình vuông mở rộng
            IPoint[] resultP = new IPoint[2];
            foreach (var pair in doubleSize)
            {
                IPoint[] resultTmp = bruteForce(pair.Value.ToArray(), ref distanceRA);
                if (resultTmp != null)
                {
                    resultP = resultTmp;
                }
            }
                int countCompair = 0;
                foreach (var pair in doubleSize)
                {
                    int countInPair=pair.Value.ToArray().Length;
                    countCompair += countInPair * (countInPair - 1) / 2;
                }
                strDetail.AppendLine(String.Format("Number of distance computation: {0} ", countCompair));
            
            strDetail.Append(String.Format("Closest pair: ({0}, {1}) - ({2}, {3}). Distance: {4}\r\n", resultP[0]._X, resultP[0]._Y, resultP[1]._X, resultP[1]._Y, distanceRA));
            return resultP;
        }

        private string PrintSquare(Dictionary<int, List<IPoint>> Squares)
        {
            StringBuilder str = new StringBuilder();
            foreach (KeyValuePair<int, List<IPoint>> pair in Squares)
            {
                str.Append(String.Format("List point in square {0}: ",pair.Key));
                foreach (IPoint p in pair.Value)
                {
                    str.Append(String.Format("({0}, {1}) ",p._X,p._Y));
                }
                str.AppendLine();
            }
            return str.ToString();
        }
        private string PrintSquare(Dictionary<string, List<IPoint>> Squares)
        {
            StringBuilder str = new StringBuilder();
            foreach (KeyValuePair<string, List<IPoint>> pair in Squares)
            {
                str.Append(String.Format("List point in square {0}: ", pair.Key));
                foreach (IPoint p in pair.Value)
                {
                    str.Append(String.Format("({0}, {1}) ", p._X, p._Y));
                }
                str.AppendLine();
            }
            return str.ToString();
        }
        #endregion

        private void ThemDuLieuVaoList(int N, string name, string time)
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
            Series sBF = new Series("Brute Force");
            Series sDC = new Series("Divide-Conquer");
            Series sRa = new Series("Randomized");
            for (int i = 0; i < listViewDuLieu.Items.Count; i++)
            {
                int x = Convert.ToInt32(listViewDuLieu.Items[i].SubItems[1].Text);
                int y = Convert.ToInt32(listViewDuLieu.Items[i].SubItems[2].Text);
                if (listViewDuLieu.Items[i].SubItems[0].Text == "Brute Force")
                    sBF.Points.AddXY(x, y);
                else if (listViewDuLieu.Items[i].SubItems[0].Text == "Divide-Conquer")
                    sDC.Points.AddXY(x, y);
                else
                    sRa.Points.AddXY(x, y);

            }
            chart1.Series.Add(sBF);
            chart1.Series.Add(sDC);
            chart1.Series.Add(sRa);
            chart1.Series[0].Color = Color.Blue;
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[0].BorderWidth = 2;
            chart1.Series[1].Color = Color.Orange;
            chart1.Series[1].ChartType = SeriesChartType.Line;
            chart1.Series[1].BorderWidth = 2;
            chart1.Series[2].Color = Color.Red;
            chart1.Series[2].ChartType = SeriesChartType.Line;
            chart1.Series[2].BorderWidth = 2;
        }


        private void btDel_Click(object sender, EventArgs e)
        {
            this.listViewDuLieu.Items.Clear();
            chart1.Series.Clear();
        } 
    }
   
}
