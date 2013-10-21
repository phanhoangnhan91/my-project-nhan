namespace Prim
{
    using System.Collections.Generic;
  

    public interface IPrim
    {
        

        //IList<Edge> RandMST(IList<Edge> graph, IList<Vertex> vertices, out int totalCost);

        IList<Edge> Prim(IList<Edge> _graph, out int totalCost);

        IList<Edge> DetailPrim(IList<Edge> _graph, out int totalCost, out string str);
    }
}
