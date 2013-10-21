namespace Prim
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    


    public class Prim : IPrim
    {
       

        #region Prim
        IList<Edge> IPrim.Prim(IList<Edge> graph, out int totalCost)
        {
            totalCost = 0;
            IList<Edge> solvedGraph = new List<Edge>();
            IList<Edge> dsCanhnoilienvoimotdinh = new List<Edge>();
            // ds dinh da chon
            IList<int> dsdachon = new List<int>();
            // ds dinh con lai co the chon
            IList<int> dscl = new List<int>();
            

            

            #region luu ten đỉnh
            IList<int> tenDinh = new List<int>();// luu ten đỉnh
            foreach (Edge ed in graph)
            {
                //Vertex root1 = ed.V1.GetRoot();
                //Vertex root2 = ed.V2.GetRoot();
                //  ed.V1.Root.name = root1.Name;
                bool kt1 = false;

                foreach (int i in tenDinh)
                {
                    if (ed.V1.Name2 == i)
                    {
                        kt1 = true;
                        break;
                    }

                }
                if (kt1 == false)
                    tenDinh.Add(ed.V1.Name2);
                bool kt2 = false;
                if (ed.V1.Name2 != ed.V2.Name2)
                {
                    foreach (int i in tenDinh)
                    {
                        if (ed.V2.Name2 == i)
                        {
                            kt2 = true;
                            break;
                        }

                    }
                    if (kt2 == false)
                        tenDinh.Add(ed.V2.Name2);
                }
            }
            #endregion
            Random rd = new Random();
           // int Selected = tenDinh[rd.Next(0, tenDinh.Count)];
            int Selected = tenDinh[0];
            // tim ta ca cac canh noi lien voi mot dinh
            dsdachon.Add(Selected);

            while (dsdachon.Count< tenDinh.Count) // khi so dinh cua do thi ket qua bang so dinh cua do thi ban dau thi dung lai
            {
                // thiet lap lai
                dsCanhnoilienvoimotdinh.Clear();
                foreach (int dinh in dsdachon)
                {

                    dsCanhnoilienvoimotdinh = timtacacanh(dsCanhnoilienvoimotdinh,graph, dinh,solvedGraph);
                }
                // tim trong so nhat nhat trong cac canh nay
              

                // chon mot canh vao do thi ket qua

                choncanhvaoketqua(dsCanhnoilienvoimotdinh,solvedGraph,out solvedGraph,dsdachon,out dsdachon, tenDinh,out tenDinh);
                // luu ten dinh cua do thi ket qua
                #region luu ten đỉnh cua do thi ket qua
               
                foreach (Edge ed in solvedGraph)
                {
                    //Vertex root1 = ed.V1.GetRoot();
                    //Vertex root2 = ed.V2.GetRoot();
                    //  ed.V1.Root.name = root1.Name;
                    bool kt1 = false;

                    foreach (int i in dsdachon)
                    {
                        if (ed.V1.Name2 == i)
                        {
                            kt1 = true;
                            break;
                        }

                    }
                    if (kt1 == false)
                        dsdachon.Add(ed.V1.Name2);
                    bool kt2 = false;
                    if (ed.V1.Name2 != ed.V2.Name2)
                    {
                        foreach (int i in dsdachon)
                        {
                            if (ed.V2.Name2 == i)
                            {
                                kt2 = true;
                                break;
                            }

                        }
                        if (kt2 == false)
                            dsdachon.Add(ed.V2.Name2);
                    }
                }
                #endregion
                
                // cac dinh con lai


            };
            totalCost = 0;
            foreach (Edge ed in solvedGraph)
                totalCost += ed.Cost;
            return solvedGraph;
        }

        IList<Edge> IPrim.DetailPrim(IList<Edge> graph,out int totalCost, out string detail)
        {
            detail = "";
            IList<Edge> solvedGraph = new List<Edge>();
            IList<Edge> dsCanhnoilienvoimotdinh = new List<Edge>();
            // ds dinh da chon
            IList<int> dsdachon = new List<int>();
            // ds dinh con lai co the chon
            IList<int> dscl = new List<int>();




            #region luu ten đỉnh
            IList<int> tenDinh = new List<int>();// luu ten đỉnh
            foreach (Edge ed in graph)
            {
                //Vertex root1 = ed.V1.GetRoot();
                //Vertex root2 = ed.V2.GetRoot();
                //  ed.V1.Root.name = root1.Name;
                bool kt1 = false;

                foreach (int i in tenDinh)
                {
                    if (ed.V1.Name2 == i)
                    {
                        kt1 = true;
                        break;
                    }

                }
                if (kt1 == false)
                    tenDinh.Add(ed.V1.Name2);
                bool kt2 = false;
                if (ed.V1.Name2 != ed.V2.Name2)
                {
                    foreach (int i in tenDinh)
                    {
                        if (ed.V2.Name2 == i)
                        {
                            kt2 = true;
                            break;
                        }

                    }
                    if (kt2 == false)
                        tenDinh.Add(ed.V2.Name2);
                }
            }
            #endregion
            Random rd = new Random();
             int Selected = tenDinh[rd.Next(0, tenDinh.Count)];
           // int Selected = tenDinh[0];
            // tim ta ca cac canh noi lien voi mot dinh
            dsdachon.Add(Selected);

            while (dsdachon.Count < tenDinh.Count) // khi so dinh cua do thi ket qua bang so dinh cua do thi ban dau thi dung lai
            {
                // thiet lap lai
                dsCanhnoilienvoimotdinh.Clear();
                string listvertex = "List vertex U: ";
                string listEdge = "List Edge (u,v): ";
                foreach (int dinh in dsdachon)
                {
                    listvertex += dinh + ", ";
                    dsCanhnoilienvoimotdinh = timtacacanh(dsCanhnoilienvoimotdinh, graph, dinh, solvedGraph);

                   
                    

                }
                foreach (Edge ed in dsCanhnoilienvoimotdinh)
                {
                    listEdge += "(" + ed.V1.Name + "," + ed.V2.Name + "),";
                }
                detail += "Step " + dsdachon.Count + ": \r\n";
                detail += listvertex + "\r\n";
                detail += listEdge + "\r\n";
                detail += "Selected edge: ";
                // tim trong so nhat nhat trong cac canh nay


                // chon mot canh vao do thi ket qua

                choncanhvaoketqua(dsCanhnoilienvoimotdinh, solvedGraph, out solvedGraph, dsdachon, out dsdachon, tenDinh, out tenDinh);
                // luu ten dinh cua do thi ket qua
                #region luu ten đỉnh cua do thi ket qua

                foreach (Edge ed in solvedGraph)
                {
                    detail += "(" + ed.V1.Name + "," + ed.V2.Name + "), ";
                    //Vertex root1 = ed.V1.GetRoot();
                    //Vertex root2 = ed.V2.GetRoot();
                    //  ed.V1.Root.name = root1.Name;
                    bool kt1 = false;

                    foreach (int i in dsdachon)
                    {
                        if (ed.V1.Name2 == i)
                        {
                            kt1 = true;
                            break;
                        }

                    }
                    if (kt1 == false)
                        dsdachon.Add(ed.V1.Name2);
                    bool kt2 = false;
                    if (ed.V1.Name2 != ed.V2.Name2)
                    {
                        foreach (int i in dsdachon)
                        {
                            if (ed.V2.Name2 == i)
                            {
                                kt2 = true;
                                break;
                            }

                        }
                        if (kt2 == false)
                            dsdachon.Add(ed.V2.Name2);
                    }
                }
                detail += "\r\n";
                #endregion

                // cac dinh con lai


            };

           // #region ghichu
           

           // IList<Edge> solvedGraph = new List<Edge>();
           // IList<Edge> dsCanhnoilienvoimotdinh = new List<Edge>();
           // // ds dinh da chon
           // IList<int> dsdachon = new List<int>();
           // // ds dinh con lai co the chon
           // IList<int> dscl = new List<int>();




           // #region luu ten đỉnh
           // IList<int> tenDinh = new List<int>();// luu ten đỉnh
           // foreach (Edge ed in graph)
           // {
           //     //Vertex root1 = ed.V1.GetRoot();
           //     //Vertex root2 = ed.V2.GetRoot();
           //     //  ed.V1.Root.name = root1.Name;
           //     bool kt1 = false;

           //     foreach (int i in tenDinh)
           //     {
           //         if (ed.V1.Name2 == i)
           //         {
           //             kt1 = true;
           //             break;
           //         }

           //     }
           //     if (kt1 == false)
           //         tenDinh.Add(ed.V1.Name2);
           //     bool kt2 = false;
           //     if (ed.V1.Name2 != ed.V2.Name2)
           //     {
           //         foreach (int i in tenDinh)
           //         {
           //             if (ed.V2.Name2 == i)
           //             {
           //                 kt2 = true;
           //                 break;
           //             }

           //         }
           //         if (kt2 == false)
           //             tenDinh.Add(ed.V2.Name2);
           //     }
           // }
           // #endregion
           // //Random rd = new Random();
           // // int Selected = tenDinh[rd.Next(0, tenDinh.Count)];
           // int Selected = tenDinh[0];
           // // tim ta ca cac canh noi lien voi mot dinh
           // dsdachon.Add(Selected);
            


           // while (dsdachon.Count < tenDinh.Count) // khi so dinh cua do thi ket qua bang so dinh cua do thi ban dau thi dung lai
           // {
           //     // thiet lap lai
           //     dsCanhnoilienvoimotdinh.Clear();
           //     string listvertex = "List vertex U: ";
           //     string listEdge = "List Edge (u,v): ";
           //     foreach (int dinh in dsdachon)
           //     {
           //         listvertex += dinh+", ";
           //         dsCanhnoilienvoimotdinh = timtacacanh(dsCanhnoilienvoimotdinh, graph, dinh, solvedGraph);
           //         foreach (Edge ed in dsCanhnoilienvoimotdinh)
           //         {
           //             listEdge +="(" +ed.V1.Name+"," + ed.V2.Name+"),";
           //         }
           //     }
           //     // tim trong so nhat nhat trong cac canh nay


           //     // chon mot canh vao do thi ket qua

           //     choncanhvaoketqua(dsCanhnoilienvoimotdinh, solvedGraph, out solvedGraph, dsdachon, out dsdachon, tenDinh, out tenDinh);
           //     //
           //     detail += "Step "+dsdachon.Count+": \r\n";
           //     detail += listvertex +"\r\n";
           //     detail += listEdge + "\r\n";
           //     //detail += "Selected edge: " + canhdcChon+"\r\n";
           //     detail += "Selected vertex: ";

           //     // luu ten dinh cua do thi ket qua
           //     #region luu ten đỉnh cua do thi ket qua

           //     foreach (Edge ed in solvedGraph)
           //     {
           //         //Vertex root1 = ed.V1.GetRoot();
           //         //Vertex root2 = ed.V2.GetRoot();
           //         //  ed.V1.Root.name = root1.Name;
           //         bool kt1 = false;

           //         foreach (int i in dsdachon)
           //         {
           //             if (ed.V1.Name2 == i)
           //             {
           //                 kt1 = true;
           //                 break;
           //             }

           //         }
           //         if (kt1 == false)
           //         {
           //             dsdachon.Add(ed.V1.Name2);
           //             detail += ed.V1.Name2 + ", ";
           //         }
           //         bool kt2 = false;
           //         if (ed.V1.Name2 != ed.V2.Name2)
           //         {
           //             foreach (int i in dsdachon)
           //             {
           //                 if (ed.V2.Name2 == i)
           //                 {
           //                     kt2 = true;
           //                     break;
           //                 }

           //             }
           //             if (kt2 == false)
           //             {
           //                 dsdachon.Add(ed.V2.Name2);
           //                 detail += ed.V2.Name2 + ", ";
           //             }

           //         }
           //     }
           //     detail += "\r\n";
           //     #endregion

           //     // cac dinh con lai


           // };
           //// totalCost = 0;
           //// foreach (Edge ed in solvedGraph)
           //  //   totalCost += ed.Cost;
           // // return solvedGraph;
           // #endregion

            totalCost = 0;
            foreach (Edge ed in solvedGraph)
                totalCost += ed.Cost;
            return solvedGraph;
        }

       

        void choncanhvaoketqua(IList<Edge> dsCanhnoilienvoimotdinh, IList<Edge> solvedGraph1, out IList<Edge> solvedGraph2, IList<int> dsdachon1, out IList<int> dsdachon2, IList<int> tenDinh1, out IList<int> tenDinh2)
        {
            dsdachon2 = dsdachon1;
            tenDinh2 = tenDinh1;
            solvedGraph2 = solvedGraph1;
            Edge min = dsCanhnoilienvoimotdinh[0];
            foreach (Edge ed in dsCanhnoilienvoimotdinh)
                if (ed.cost2 < min.cost2)
                    min = ed;
            // neu tao thanh chu trinh thi khong chon

            Vertex root1 = min.V1.GetRoot();
            Vertex root2 = min.V2.GetRoot();


            if (root1.Name != root2.Name)
            {

                Vertex.Join(root1, root2);// làm cho các đỉnh của đồ thị thay đổi giá trị root
                solvedGraph2.Add(min);
               

            }
            else
            {
                // gan max value cho canh bi tao thanh chu trinh
                foreach (Edge ed in dsCanhnoilienvoimotdinh)
                    if (ed == min)
                        ed.cost2 = int.MaxValue;
                // lap lai
                choncanhvaoketqua(dsCanhnoilienvoimotdinh, solvedGraph1,out solvedGraph2,dsdachon1,out dsdachon2,tenDinh1,out tenDinh2);
            }
        }
        string choncanhvaoketquaDetail(IList<Edge> dsCanhnoilienvoimotdinh, IList<Edge> solvedGraph1, out IList<Edge> solvedGraph2, IList<int> dsdachon1, out IList<int> dsdachon2, IList<int> tenDinh1, out IList<int> tenDinh2)
        {
            string canhdcChon = "";
            dsdachon2 = dsdachon1;
            tenDinh2 = tenDinh1;
            solvedGraph2 = solvedGraph1;
            Edge min = dsCanhnoilienvoimotdinh[0];
            foreach (Edge ed in dsCanhnoilienvoimotdinh)
                if (ed.cost2 < min.cost2)
                    min = ed;
            // neu tao thanh chu trinh thi khong chon

            Vertex root1 = min.V1.GetRoot();
            Vertex root2 = min.V2.GetRoot();


            if (root1.Name != root2.Name)
            {

                Vertex.Join(root1, root2);// làm cho các đỉnh của đồ thị thay đổi giá trị root
                solvedGraph2.Add(min);
                canhdcChon+="("+min.V1.Name+","+min.V2.Name+")";


            }
            else
            {
                // gan max value cho canh bi tao thanh chu trinh
                foreach (Edge ed in dsCanhnoilienvoimotdinh)
                    if (ed == min)
                        ed.cost2 = int.MaxValue;
                // lap lai
                choncanhvaoketquaDetail(dsCanhnoilienvoimotdinh, solvedGraph1, out solvedGraph2, dsdachon1, out dsdachon2, tenDinh1, out tenDinh2);
            }
            return canhdcChon;
        }



        private IList<Edge> timtacacanh(IList<Edge> dauvaodscanh, IList<Edge> graph, int Selected,IList<Edge> Solvedgraph)
        {

             IList<Edge> dsCanhnoilienvoimotdinh = new List<Edge>();
             dsCanhnoilienvoimotdinh = dauvaodscanh;
            bool kt1=false;
            bool kt2=false;
            foreach (Edge ed in graph)
            {
                

                    // neu canh nay khong nam trong do thi ket qua va khong nam trong danh  noi lien voi mot canh
                    kt1=false;
                    kt2=false;
                foreach (Edge ed2 in Solvedgraph)
                    if (ed2 == ed)
                    {
                        kt1 = true;
                    }
                foreach (Edge ed3 in dsCanhnoilienvoimotdinh)
                    if (ed3== ed)
                        kt2 =true;
                if (ed.V1.Name == Selected || ed.V2.Name == Selected)
                    if( kt1==false && kt2==false)
                    dsCanhnoilienvoimotdinh.Add(ed);
            }
            return dsCanhnoilienvoimotdinh;
        } 

        #endregion

        #region randomize algorithm
        public IList<Edge> RandMST(IList<Edge> graph, out int totalCost)// graph là input
        {
             
          
            
            IList<Edge> solvedGraph = new List<Edge>(); // đồ thị KQ
             // boruvka step
            IList<Edge> g1 = Boruvka(graph, solvedGraph, out solvedGraph);// G1 là đồ thị hình 11.10
            IList<Edge> g2 = new List<Edge>(); // đồ thị hình 11.2
            IList<Edge> g3 = new List<Edge>();
            Boolean chk=false;
             
            
            
            if (g1.Count != 0)
            {
                if (g1.Count == 1) // nếu G1 chỉ có một cạnh thì add vào đồ thị kq
                    solvedGraph.Add(g1[0]);
                else
                {   // cau truc lai G1
                    Rename(g1);
                    g2 = Boruvka(g1, solvedGraph, out solvedGraph);

                }
            }

            if (g2.Count != 0)
            {
                if (g2.Count == 1) // nếu G2 chỉ có một cạnh thì add vào đồ thị kq
                    solvedGraph.Add(g2[0]);
                else
                {

                    Rename(g2);
                    g3 = Boruvka(g2, solvedGraph, out solvedGraph);

                }
                if (g3.Count == 1) // nếu G3 chỉ có một cạnh thì add vào đồ thị kq
                        solvedGraph.Add(g3[0]);
                else
                {
                    if (g3.Count != 0&&chk)
                    {

                        Rename(g3);
                        IList<Edge> G1 = new List<Edge>();
                        IList<Edge> G2 = new List<Edge>();
                        IList<Edge> H = new List<Edge>();
                        IList<Edge> F = new List<Edge>();
                        G1 = g3;
                        Random rd = new Random();
                        foreach (Edge ed in G1)
                        {
                            int isSelected = rd.Next(0, 2);
                            if (isSelected == 1)
                                H.Add(ed);

                        }
                        // giai thuat de qui
                        int totalCost1;
                        F = RandMST(H, out totalCost1);
                        foreach (Edge ed in F)
                            solvedGraph.Add(ed);

                        #region tao ma tran do thi G1

                        // tinh so dinh max
                        int max = 0;
                        foreach (Edge ed in G1)
                        {
                            if (ed.V1.Name2 > max)
                                max = ed.V1.Name2;
                            if (ed.V2.Name2 > max)
                                max = ed.V2.Name2;
                        }
                        int[,] a = new int[max + 1, max + 1];
                        foreach (Edge ed in G1)
                        {
                            a[ed.V1.Name2, ed.V2.Name2] = ed.Cost; // tao ma tran trong so cho do thi
                        }

                        #endregion

                        // tim nhung canh khong phai F trong G1, neu canh nay la Heavy thi khong add no vao G2
                        foreach (Edge ed in G1)
                        {
                            bool kt = false;
                            foreach (Edge ed2 in F)
                            {
                                if ((ed.V1.Name == ed2.V1.Name) && (ed.V2.Name == ed2.V2.Name))
                                    kt = true;
                            }
                            if (kt == false)
                            {
                                // tinh khoang cach tu v1 den v2
                                int kc = Dijkstra(a, max, ed.V1.Name2, ed.V2.Name2);
                                // neu khoang canh nay <cost thi canh nay la f heavy
                                if (kc == ed.Cost)
                                {
                                    G2.Add(ed);
                                    solvedGraph.Add(ed);
                                }

                            }
                        }
                        solvedGraph = RandMST(G2, out totalCost);
                    }
                    

                   
                }

            }
            #region ghi chu
            // dem so dinh cua G1
            //#region luu ten đỉnh
            //IList<int> tenDinh = new List<int>();// luu ten đỉnh
            //foreach (Edge ed in G1)
            //{
            //    //Vertex root1 = ed.V1.GetRoot();
            //    //Vertex root2 = ed.V2.GetRoot();
            //    //  ed.V1.Root.name = root1.Name;
            //    bool kt1 = false;

            //    foreach (int i in tenDinh)
            //    {
            //        if (ed.V1.Name2 == i)
            //        {
            //            kt1 = true;
            //            break;
            //        }

            //    }
            //    if (kt1 == false)
            //        tenDinh.Add(ed.V1.Name2);
            //    bool kt2 = false;
            //    if (ed.V1.Name2 != ed.V2.Name2)
            //    {
            //        foreach (int i in tenDinh)
            //        {
            //            if (ed.V2.Name2 == i)
            //            {
            //                kt2 = true;
            //                break;
            //            }

            //        }
            //        if (kt2 == false)
            //            tenDinh.Add(ed.V2.Name2);
            //    }
            //}
            //#endregion
            //int sodinh = tenDinh.Count;
            // Random rd= new Random();
            //for (int i = 0; i < sodinh - 1; i++)// chon canh trong G1 gan vao H
            //{
            //    int VtCanhDcChon = rd.Next(0, G1.Count);

            //}




           
            #endregion
            totalCost = 0;
            foreach (Edge ed in solvedGraph)
            {
                totalCost += ed.Cost;
            }

            return solvedGraph;
        }
        public int Dijkstra(int[,] a, int n, int s,int v) // khoang canh tu s den v
        {



            int[] Mark = new int[100];
            int[] d = new int[100];
            int[] pr = new int[100];
            int k = 0, min = 0, dem = 0;

            //Khoi tao theo ly thuyet slide hoc cua cac ban 
            for (int i = 0; i < n; i++)
            {
                d[i] = int.MaxValue;			//tu dinh goc s den cac dinh con lai la vocuc
                Mark[i] = 0; 			//chua co dinh nao dc chon vao cay T
                pr[i] = s;			//s la dinh truoc khi den tat ca dinh i con lai
            }

            //khoi tao
            for (int j = 0; j < n; j++)
            {
                if (a[s, j] != 0)		//neu co canh noi giua s va j
                    d[j] = a[s, j];	//luu lai khoang cach tu s->j vao mang d [d la mang luu lai khoang cach tinh tu s]
            }

            d[s] = 0;				//khoang cach s->s la 0  [d la mang luu lai khoang cach tinh tu s]
            Mark[s] = 1; 			//s la dinh dau tien dua vao cay T

            dem = n - 1;				//chuan bi lap n-1 lan, tuc chon n-1 dinh con lai vao cay T, [n-1: tru ra dinh s da dc chon roi]
            while (dem > 0)
            {			//lan luot chon n-1 dinh dua vao cay T [co n dinh, tru ra dinh s da dua vao cay T truoc do roi]
                min = int.MaxValue;
                for (int i = 0; i < n; i++)					//di tim dinh k, 
                    if ((Mark[i] == 0) && (d[i] < min))
                    {	//ma k o ngoai cay T, sao cho d[k] la nho nhat
                        min = d[i];
                        k = i;
                    }
                //if (min == int.MaxValue)
                //{
                //    Console.Write("Do thi khong lien thong");
                //    return 0;
                //}
                Mark[k] = 1;								//Chon dc k dua vao cay T
                for (int j = 0; j < n; j++) 					//Cap nhat lai gia tri
                    if ((Mark[j] == 0) && (d[k] + a[k, j] < d[j]) && (a[k, j] > 0))
                    {
                        d[j] = d[k] + a[k, j];
                        pr[j] = k;
                    }
                dem--;
            }


            ////In kq: dinh goc xp- > tat ca cac dinh con lai	
            //for (int i=0;i<n;i++)
            //    if (i!=s)				//neu la dinh goc ==> khong in ra man hinh
            //        if(d[i]==vocuc)		//khong co duong di tu s->i
            //            printf("ko co duong di tu %d->%d\n",s,i);
            //        else {
            //            printf("duong di tu %d->%d co do dai la: %d . ",s,i,d[i]);
            //            printf("Cac dinh di qua la : ");
            //            int mang[MAX];
            //            dem=0;
            //            int tam=pr[i];
            //            while (tam!=s) {
            //                mang[dem]=tam;
            //                tam=pr[tam];
            //                dem++;
            //            }
            //            printf("%d->",s);
            //            for (int j=dem;j>0;j--)
            //                printf("%d->",mang[j-1]);
            //            printf("%d\n",i);
            //        }
            return d[v];
        }
         private void Rename(IList<Edge> g)
         {
             foreach (Edge ed in g)
             {
                 Vertex root1 = ed.V1.GetRoot();
                 Vertex root2 = ed.V2.GetRoot();
                 ed.V1.Name2 = root1.Name;
                 ed.V2.Name2 = root2.Name;
             }
         }

         private IList<Edge> Boruvka(IList<Edge> graph, IList<Edge> solvedGraph_Input, out IList<Edge> solvedGraph)
         {
             solvedGraph = new List<Edge>();//  solvedGraph  là những cạnh gạch liền 
             foreach (Edge ed in solvedGraph_Input) // với mỗi cạnh từ solvedGraph_input thêm vào solvedGraph
                 solvedGraph.Add(ed);            
             IList<Edge> solvedGraphBoruvka = new List<Edge>();// kết quả của Boruvka Step
             // Tìm danh sách cạnh còn lại
             IList<Edge> remainListEdge = new List<Edge>(); // danh sách các cạnh không được chọn, (cạnh còn lại)
             #region Lấy danh sách tên đỉnh
             IList<int> vertexName=new List<int>(); // lưu tên đỉnh
             foreach (Edge ed in graph)
             {
                
                 bool check1 = false;
                 
                 foreach (int i in vertexName)
                 {
                     if ( ed.V1.Name2 == i)
                     {
                         check1 = true;
                         break;
                     }
                     
                 }
                 if (check1 == false)
                     vertexName.Add(ed.V1.Name2);
                 bool check2 = false;
                 if (ed.V1.Name2 != ed.V2.Name2)
                 {
                     foreach (int i in vertexName)
                     {
                         if (ed.V2.Name2 == i)
                         {
                             check2 = true;
                             break;
                         }

                     }
                     if (check2 == false)
                         vertexName.Add(ed.V2.Name2);
                 }
             }
             #endregion

             // Nếu số cạnh bằng số đỉnh -1 thì không phải giải tiếp
             if (vertexName.Count - 1 == graph.Count)
                 return graph;

             #region tính với mỗi đỉnh tìm cạnh có trọng số nhỏ nhất trả về solvedGraph
             for (int i = 0; i < vertexName.Count; i++)// với mỗi đỉnh tìm cạnh có trọng số nhỏ nhất
             {
                 int minCost=int.MaxValue;
                 Edge minCostEdge = graph[0]; // cạnh có trọng số nhỏ nhất liên thuộc với đỉnh i
                 foreach (Edge ed in graph) // Tìm minCostEdge
                 {
                     
                     if (ed.V1.Name2 == vertexName[i] || ed.V2.Name2 == vertexName[i]) // nếu cạnh này là liên thuộc với đỉnh i
                     {
                         if (minCost > ed.Cost)
                         {
                             minCost = ed.Cost;
                             minCostEdge = ed;
                         }
                     }
                 }
                 
                 // Kết hợp (join) lại, 

                 Vertex root1 = minCostEdge.V1.GetRoot();
                 Vertex root2 = minCostEdge.V2.GetRoot();
                 if (root1.Name != root2.Name)
                 {
                     Vertex.Join(root1, root2);
                     solvedGraph.Add(minCostEdge);
                 }


             }
             #endregion

             #region tìm danh sách các cạnh còn lại, trả về remainListEdge
             foreach (Edge ed in graph)
             {
                 bool kiemtra = false;
                 foreach (Edge ed2 in solvedGraph)
                 {
                     if (ed == ed2)
                     {
                         kiemtra = true;
                         break;
                     }
                 }
                 if (kiemtra == false) // nếu cạnh này không tồn tại trong solvegraph
                 {
                     remainListEdge.Add(ed);
                 }

             }
             #endregion

             #region tính đồ thị hình thành sau khi bỏ cạnh trùng và khuyên, trả về solvedGraphBoruvka
             // trong số các cạnh còn lại nếu một đỉnh thuộc root này, một thuộc root kia. tìm cạnh có trọng số nhỏ nhất
             foreach (Edge ed in remainListEdge)
             {
                
                 Vertex root1 = ed.V1.GetRoot();
                 Vertex root2 = ed.V2.GetRoot();
                 if (root1.Name != root2.Name)
                 {
                     Edge minCostListEgdeRemain = ed; // cạnh có trọng số nhỏ nhất trong các cạnh trùng
                     foreach (Edge ed2 in remainListEdge)
                     {
                         Vertex root3 = ed2.V1.GetRoot();
                         Vertex root4 = ed2.V2.GetRoot();
                         if (((root3.Name == root1.Name) && (root4.Name == root2.Name)) || ((root3.Name == root2.Name) && (root4.Name == root1.Name)))
                         {
                             if (minCostListEgdeRemain.Cost > ed2.Cost)
                                 minCostListEgdeRemain = ed2;
                         }
                     }
                     // kiểm tra nếu solvedGraphBoruvka không có cạnh này mới add cạnh này vô 
                     bool testResult = false; //
                     foreach (Edge ed3 in solvedGraphBoruvka)
                     {
                         
                         if (ed3 == minCostListEgdeRemain)
                         {
                             testResult = true;
                             break;
                         }

                         
                     }
                     if(testResult==false)
                        solvedGraphBoruvka.Add(minCostListEgdeRemain);

                 }

             }
             #endregion


             return solvedGraphBoruvka;
         }

        #endregion
       



        public IList<Edge> RandMSTDetail(IList<Edge> graph, out int totalCost, out string details)
        {
            details = "";

            IList<Edge> solvedGraph = new List<Edge>(); // đồ thị KQ
            // boruvka step
            int count = 0;
            IList<Edge> g1 = Boruvka(graph, solvedGraph, out solvedGraph);// G1 là đồ thị hình 11.10
            count++;
            IList<Edge> g2 = new List<Edge>(); // đồ thị hình 11.2
            IList<Edge> g3 = new List<Edge>();
            Boolean chk = false;
            details += "Step " + count + ": \r\n Selected Edge: ";
            foreach (Edge ed in solvedGraph)
            {
                details+="("+ed.V1.Name+","+ed.V2.Name+"), " ;
            }
            details += "\r\n";

            if (g1.Count != 0)
            {
                if (g1.Count == 1) // nếu G1 chỉ có một cạnh thì add vào đồ thị kq
                {
                    solvedGraph.Add(g1[0]);
                    details+="Add edge ("+g1[0].V1.Name+","+g1[0].V2.Name+")\r\n";
                }
                else
                {   // cau truc lai G1
                    Rename(g1);
                    g2 = Boruvka(g1, solvedGraph, out solvedGraph);
                    count++;
                    details += "Step " + count + ": \r\n Selected Edge: ";
                    foreach (Edge ed in solvedGraph)
                    {
                        details += "(" + ed.V1.Name + "," + ed.V2.Name + "), ";
                    }
                    details += "\r\n";

                }
            }

            if (g2.Count != 0)
            {
                if (g2.Count == 1) // nếu G2 chỉ có một cạnh thì add vào đồ thị kq
                {
                    solvedGraph.Add(g2[0]);
                    details += "Add edge (" + g2[0].V1.Name + "," + g2[0].V2.Name + ")\r\n";
                }
                else
                {

                    Rename(g2);
                    g3 = Boruvka(g2, solvedGraph, out solvedGraph);
                    count++;
                    details += "Step " + count + ": \r\n Selected Edge: ";
                    foreach (Edge ed in solvedGraph)
                    {
                        details += "(" + ed.V1.Name + "," + ed.V2.Name + "), ";
                    }
                    details += "\r\n";
                }
                if (g3.Count == 1) // nếu G3 chỉ có một cạnh thì add vào đồ thị kq
                {
                    solvedGraph.Add(g3[0]);
                    details += "Add edge (" + g3[0].V1.Name + "," + g3[0].V2.Name + ")\r\n";
                }
                else
                {
                    if (g3.Count != 0&&chk)
                    {

                        Rename(g3);
                        IList<Edge> G1 = new List<Edge>();
                        IList<Edge> G2 = new List<Edge>();
                        IList<Edge> H = new List<Edge>();
                        IList<Edge> F = new List<Edge>();
                        G1 = g3;
                        Random rd = new Random();
                        foreach (Edge ed in G1)
                        {
                            int isSelected = rd.Next(0, 2);
                            if (isSelected == 1)
                                H.Add(ed);

                        }
                        // giai thuat de qui
                        int totalCost1;
                        F = RandMST(H, out totalCost1);
                        foreach (Edge ed in F)
                            solvedGraph.Add(ed);

                        #region tao ma tran do thi G1

                        // tinh so dinh max
                        int max = 0;
                        foreach (Edge ed in G1)
                        {
                            if (ed.V1.Name2 > max)
                                max = ed.V1.Name2;
                            if (ed.V2.Name2 > max)
                                max = ed.V2.Name2;
                        }
                        int[,] a = new int[max + 1, max + 1];
                        foreach (Edge ed in G1)
                        {
                            a[ed.V1.Name2, ed.V2.Name2] = ed.Cost; // tao ma tran trong so cho do thi
                        }

                        #endregion

                        // tim nhung canh khong phai F trong G1, neu canh nay la Heavy thi khong add no vao G2
                        foreach (Edge ed in G1)
                        {
                            bool kt = false;
                            foreach (Edge ed2 in F)
                            {
                                if ((ed.V1.Name == ed2.V1.Name) && (ed.V2.Name == ed2.V2.Name))
                                    kt = true;
                            }
                            if (kt == false)
                            {
                                // tinh khoang cach tu v1 den v2
                                int kc = Dijkstra(a, max, ed.V1.Name2, ed.V2.Name2);
                                // neu khoang canh nay <cost thi canh nay la f heavy
                                if (kc == ed.Cost)
                                {
                                    G2.Add(ed);
                                    solvedGraph.Add(ed);
                                }

                            }
                        }
                        solvedGraph = RandMST(G2, out totalCost);
                    }



                }

            }
           
            totalCost = 0;
            foreach (Edge ed in solvedGraph)
            {
                totalCost += ed.Cost;
            }

            return solvedGraph;

        }
    }
}